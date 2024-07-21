from sqlalchemy.orm import Session
import models
import schemas


def search_game(db: Session,query: str):
    return db.query(models.Games).filter(models.Games.title == query).first()


def search_game_all(db: Session):
    return db.query(models.Games).all()

def download_game(db: Session,uuid: str):
    print(uuid)
    return db.query(models.Games.zip_name).filter(models.Games.id == uuid).first()

def create_game(db: Session, title: str, description: str, version: str,author: str):
    game = models.Games(title=title,description=description,version=version,author=author)
    db.add(game)
    db.commit()
    db.refresh(game)
    return game


def update_game(db: Session, now_title: str, title: str, description: str,version: str,author: str):
    data = db.query(models.Games).filter(models.Games.title == now_title).first()
    if title:
        data.title = title
    if description:
        data.description = description
    if version:
        data.version = version
    if author:
        data.author = author
    db.commit()


def delete_game(db: Session,title: str):
    pass
