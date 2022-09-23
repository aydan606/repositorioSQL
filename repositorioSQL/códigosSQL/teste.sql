create database teste;

use teste;

create table pessoa(
	idPessoa smallint unsigned,
    primeiroNome varchar(30),
    ultimoNome varchar(20),
    genero enum('M', 'F'),
    dataNascimento date,
    rua varchar(30),
    cidade varchar(30),
    estado varchar(30),
    pais varchar(30),
    cep varchar(10),
    constraint pk_pessoa primary key (idPessoa)
);

create table comidaFavorita(
	idComida smallint unsigned,
    comida varchar(30),
    constraint pk_comidaFavorita primary key (idComida, comida),
    constraint fk_comidaFavorita_idPessoa foreign key (idComida) references pessoa (idPessoa)
);

insert into pessoa values('4','Laura','Andrade','F','1996-07-02','Av. Aliomar Baleeiro, 2556','Salvador','Bahia','Brasil','41253-000');

desc pessoa;

select * from pessoa;

select * from comidaFavorita;

delete from pessoa where idPessoa = 2;

insert into comidaFavorita values (1, 'Churrasco'), (3, 'Lasagna'), (4, 'Pizza');