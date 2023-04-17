Create Database imdbClone2
Go 
Use imdbClone2
go
Create Table Oyuncular
( 
   Id int identity (1,1) not null,
   Ad nvarchar(50) not null,
   Soyad nvarchar(50) not null
)
go
Alter Table Oyuncular
Add Constraint PK_Oyuncular
Primary Key (Id)
GO
CREATE TABLE Filmler
(
   
   Id int identity (1,1) not null PRIMARY KEY,
   Ad nvarchar(50) not null
)
GO
CREATE TABLE FilmlerOyuncular(
  FilmId int not null,
  OyuncuId int not null,
  Rol nvarchar(50) null
)
go
Alter Table FilmlerOyuncular
ADD Constraint PK_Oyuncular_Filmler
PRIMARY KEY (FilmId, OyuncuId)
GO
ALTER TABLE FilmlerOyuncular
ADD Constraint FK_Oyuncu_Film
FOREIGN KEY (FilmId)
REFERENCES  Filmler(Id)

ALTER TABLE FilmlerOyuncular
ADD Constraint FK_Film_Oyuncu
FOREIGN KEY (OyuncuId)
REFERENCES  Oyuncular(Id)









