CREATE DATABASE bibliothekverwaltung;

USE bibliothekverwaltung;

CREATE TABLE Buch(
	ISBN varchar(17) PRIMARY KEY NOT NULL,
    Titel varchar(255) NOT NULL,
    Jahr int NOT NULL,
    FK_AutorId int,
    FK_VerlagId int
);

CREATE TABLE Kunde(
	Id int AUTO_INCREMENT PRIMARY KEY,
    Titel varchar(255) NULL, 
    Vorname varchar(255) NOT NULL, 
    Nachname varchar(255) NOT NULL,
    Strasse varchar(255) NOT NULL, 
    Hausnummer int NOT NULL,
    Hausnummerzusatz varchar(10) NULL,
    Postleitzahl varchar(5) NOT NULL,
    Stadt varchar(255) NOT NULL, 
    Telefon varchar(20), 
    Beruf varchar(255)
);

CREATE TABLE Autor(
	Id int AUTO_INCREMENT PRIMARY KEY,
    Titel varchar(255) NULL, 
    Vorname varchar(255) NOT NULL, 
    Nachname varchar(255) NOT NULL
);

CREATE TABLE Ausleihe(
	Id varchar(36) PRIMARY KEY,
    Ausleihdatum Date, 
    Enddatum Date,
    FK_KundeId int
);

CREATE TABLE Verlag(
	Id int AUTO_INCREMENT PRIMARY KEY,
    Name varchar(255) NOT NULL
);

CREATE TABLE Bestand(
	Id varchar(36) PRIMARY KEY,
    Gekauft Tinyint, 
    Auflage int,
    FK_BuchISBN varchar(17)
);

CREATE TABLE Ausleihposition(
	Id varchar(36) PRIMARY KEY,
    FK_BestandId varchar(36),
    FK_AusleihId varchar(36)
);

ALTER table ausleihe ENGINE = INNODB;
ALTER table ausleihposition ENGINE = INNODB;
ALTER table autor ENGINE = INNODB;
ALTER table bestand ENGINE = INNODB;
ALTER table buch ENGINE = INNODB;
ALTER table kunde ENGINE = INNODB;
ALTER table verlag ENGINE = INNODB;

ALTER TABLE buch 
ADD CONSTRAINT FK_Buch_Autor
FOREIGN KEY (FK_AutorId) REFERENCES autor(Id)
ON UPDATE CASCADE
ON DELETE SET NULL;

ALTER TABLE buch 
ADD CONSTRAINT FK_Buch_Verlag
FOREIGN KEY (FK_VerlagId) REFERENCES verlag(Id)
ON UPDATE CASCADE
ON DELETE SET NULL;

ALTER TABLE ausleihe 
ADD CONSTRAINT FK_Ausleihe_Kunde
FOREIGN KEY (FK_KundeId) REFERENCES kunde(Id)
ON UPDATE CASCADE
ON DELETE SET NULL;

ALTER TABLE bestand 
ADD CONSTRAINT FK_Bestand_Buch
FOREIGN KEY (FK_BuchISBN) REFERENCES buch(ISBN)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE ausleihposition 
ADD CONSTRAINT FK_Ausleihposition_Bestand
FOREIGN KEY (FK_BestandId) REFERENCES bestand(Id)
ON UPDATE CASCADE
ON DELETE CASCADE;

ALTER TABLE ausleihposition 
ADD CONSTRAINT FK_Ausleihposition_Ausleihe
FOREIGN KEY (FK_AusleihId) REFERENCES ausleihe(Id)
ON UPDATE CASCADE
ON DELETE CASCADE;