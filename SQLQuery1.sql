CREATE DATABASE Workers;

USE Workers;

CREATE TABLE Dzial (
	id int constraint pk1 primary key identity(1, 1),
	dzial varchar(20),
	stanowisko varchar(20),
	wyplata decimal,
)

CREATE TABLE Kraj_pochodzenia (
	id int constraint pk2 primary key identity(1, 1),
	kraj varchar(30),
)

CREATE TABLE Dni_urlopowe (
	id int constraint pk3 primary key identity(1, 1),
	dni_url integer,
)

CREATE TABLE Pracownik  (
	id int constraint pk primary key identity(1, 1),
	dzial_id int constraint fk foreign key references Dzial(id) NOT NULL,
	kraj_id int constraint fk1 foreign key references Kraj_pochodzenia(id) NOT NULL,
	urlop_id int constraint fk2 foreign key references Dni_urlopowe(id) NOT NULL,
	imie varchar(20),
	nazwisko varchar(20),
	PESEL varchar(11),
	nr_tel varchar(20),
)