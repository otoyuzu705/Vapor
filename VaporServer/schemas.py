from pydantic import BaseModel
import uuid


class GameBase(BaseModel):
    id: str
    title: str
    description: str | None = None
    version: str
    author: str
    zip_name: str
    image_name: str


class CreateGame(BaseModel):
    pass


class UpdateGame(BaseModel):
    pass


class DeleteGame(BaseModel):
    pass





