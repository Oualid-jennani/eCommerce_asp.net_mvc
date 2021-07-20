create database aspLivre

use aspLivre

create table auteur (idAt int primary key identity,nomAt varchar(25),prenomAt varchar(25),dateN date,[login] varchar(255),[password] varchar(255))

create table livre (idL int primary key identity,titre varchar(25),reference varchar(255))

create table theme (idTh int primary key identity , discription varchar(255))

create table livreAuteur(idL int foreign key references livre(idL),idAt int foreign key references auteur(idAt), primary key (idL,idAt))

create table livreTheme (idL int foreign key references livre(idL),idTh int foreign key references theme(idTh) ,primary key (idL,idTh) )



insert into auteur values ('walid','jennani','2019-5-5','admin','admin'),('ahmed','jennani','2019-5-5','admin','admin'),('halim','laidl','2019-5-5','admin','admin');

insert into livre values ('livre1','refrefrefrefrefrefreffer'),('livre2','refrefrefrefrefrefreffer'),('livre3','refrefrefrefrefrefreffer'),('livre4','refrefrefrefrefrefreffer'),('livre5','refrefrefrefrefrefreffer')

insert into theme values ('dsc1'),('dsc1'),('dsc1'),('dsc1')


insert into livreAuteur values (2,2),(1,2),(1,3)

insert into livreTheme values (1,1),(1,2),(3,1)