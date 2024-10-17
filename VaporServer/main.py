from fastapi import FastAPI, Depends, HTTPException
from fastapi.responses import FileResponse
import uvicorn
from sqlalchemy.orm import Session,sessionmaker
import crud, models, schemas
from database import SessionLocal, engine
import os
import zipfile
import json
import hashlib

models.Base.metadata.drop_all(bind=engine)
models.Base.metadata.create_all(bind=engine)

# Path定義
base = os.path.dirname(__file__)
zip_path = os.path.join(base, "zips")


def init_DB():
    session = sessionmaker(bind=engine)()
    try:
        for files in os.listdir(zip_path):
            if files.endswith(".zip"):
                with zipfile.ZipFile(os.path.join(zip_path,files)) as zf:
                    with zf.open("meta.json") as f:
                        meta = json.loads(f.read().decode("utf-8"))
                        games = models.Games()
                        games.id = hashlib.sha256(meta["title"].encode("utf-8")).hexdigest()
                        games.title = meta["title"]
                        games.description = meta["description"]
                        games.version = meta["version"]
                        games.author = meta["author"]
                        games.zip_name = meta["zip_name"]
                        session.add(games)
                        session.commit()
    except:
        print("!!Json Parse failed!!")
    finally:
        session.close()


def db_debug():
    session = sessionmaker(bind=engine)()
    games = models.Games()
    games.id = hashlib.sha256("Sample Game".encode("utf-8")).hexdigest()
    games.title = "Sample Game"
    games.description = "For Sample"
    games.version = "0.0.0"
    games.author = "GAME KEN"
    games.zip_name = "sample.zip"
    games.image_name = "icon.png"
    session.add(games)
    session.commit()
    session.close()


db_debug()
init_DB()
app = FastAPI()

def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()


@app.get("/search")
async def search(q:str = None,db: Session = Depends(get_db)):
    if q:
        db_game = crud.search_game(db,q)

        if db_game is None:
            raise HTTPException(status_code=404,detail="Game not found")
        return db_game
    else:
        db_game = crud.search_game_all(db)
        if db_game is None:
            raise HTTPException(status_code=500,detail="Internal Server Error")
        return db_game


@app.get("/download/{uuid}")
async def download(uuid,db: Session = Depends(get_db)):
    zip_name = crud.download_game(db,uuid)
    if zip_name is None:
        raise HTTPException(status_code=404,detail="Game not found")
    else:
        zip_name = zip_name[0]
    print(os.path.join(zip_path,zip_name))
    response = FileResponse(
                            path=os.path.join(zip_path,zip_name),
                            filename=zip_name
                            )
    return response


if __name__ == "__main__":
    uvicorn.run(app, host="0.0.0.0", port=80, log_level="debug")