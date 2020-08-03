--use master;

--drop database if exists CatDB
--go

--create database CatDB
--go

--use CatDB
--go

--drop table if exists Cats
--drop table if exists Breeds

--create table Cats(
--	CatID int not null identity primary key,
--	CatName nvarchar(50),
--	Age int,
--	Description nvarchar(50)
--)

--insert into Cats values ('Ozzy', 15, 'Mainecoon')
--insert into Cats values ('Lucy', 15, 'Sphinx')
--insert into Cats values ('Jasper', 15, 'Great cat')

--use CatDB

--create table Breeds(
--	BreedId int not null identity primary key,
--	BreedName nvarchar(50),
--)

insert into Breeds (BreedName) values('Mainecoon'), ('Sphinx'), ('Tabby')
select * from breeds