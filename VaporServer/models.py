from sqlalchemy import Boolean, Column, ForeignKey, Integer, String
from sqlalchemy.orm import relationship
from database import Base


class Games(Base):
    __tablename__ = "games"

    id = Column(String, primary_key=True)
    title = Column(String,index=True)
    description = Column(String)
    version = Column(String)
    author = Column(String)
    zip_name = Column(String, unique=True)