create database Music
go

use Music
go

drop table Artists
create table Artists(
	ArtistId int not null identity primary key,
	ArtistName nvarchar(50),
	BirthPlace nvarchar(50),
)

create table Songs(
	SongId int not null identity primary key,
	Title nvarchar(50),
	ArtistId int FOREIGN KEY REFERENCES Artists(ArtistId)
)

insert into Artists values ('Ozzy Osbourne', 'Birminghan'), ('Ronnie James Dio', 'Porthsmouth'), ('Led Zeppelin', 'London')
insert into Songs values ('Crazy Train', 1), ('Holy Diver', 2), ('Starway To Heaven', 3)

select * from Artists
select * from Songs
