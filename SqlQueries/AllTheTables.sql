CREATE DATABASE bilbase
go

use bilbase
go

CREATE TABLE usergroup
(
	groupID int PRIMARY KEY IDENTITY(1,1),
	groupName varchar(20) NOT NULL UNIQUE
)

CREATE TABLE users
(
	uID int PRIMARY KEY IDENTITY(1,1),
	username varchar(128) unique NOT NULL,
	password varchar(128) NOT NULL,
	usergroup int FOREIGN KEY REFERENCES usergroup(groupID),
	mail varchar(320),
	tlf int
)

CREATE TABLE maerke
(
	maerkeID int PRIMARY KEY IDENTITY(1,1),
	maerkeName varchar(32) NOT NULL UNIQUE
)

CREATE TABLE braendstof
(
	ID int PRIMARY KEY IDENTITY(1,1),
	type varchar(20)
)

CREATE TABLE cars
(
	carID int PRIMARY KEY IDENTITY(1,1),
	maerke int FOREIGN KEY REFERENCES maerke(maerkeID),
	braendstofType int FOREIGN KEY REFERENCES braendstof(ID),
	model varchar(50) NOT NULL,
	kmperliter float,
	pris int,
	aargang int,
	saeder int,
	doere int
)