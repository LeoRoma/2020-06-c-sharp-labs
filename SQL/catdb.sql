﻿--use master;

--drop database if exists CatDB
--go

--create database CatDB
--go

--use CatDB
--go

--drop table if exists Cats

--create table Cats(
--	CatID int not null identity primary key,
--	CatName nvarchar(50),
--	Age int,
--	Description nvarchar(50)
--)

--insert into Cats values ('Ozzy', 15, 'Mainecoon')
--insert into Cats values ('Lucy', 15, 'Sphinx')
--insert into Cats values ('Jasper', 15, 'Great cat')

select * from Cats