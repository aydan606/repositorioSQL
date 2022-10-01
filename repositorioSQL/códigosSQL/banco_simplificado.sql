-- Explorando comandos DDL:

select now() as timestamp;

create database manipulation;

use manipulation;

create table contaBanco(
	idConta int auto_increment primary key,
    numeroAgencia int not null unique,
    numeroConta int not null unique,
    saldo float
);

insert into contaBanco(numeroAgencia, numeroConta, saldo) values(1025, 14956, 0);
insert into contaBanco(numeroAgencia, numeroConta, saldo) values(9814, 69428, 0);

alter table contaBanco add limiteCredito float;

create table clienteBanco(
	idCliente int auto_increment,
    conta int not null,
    cpf char(11) not null,
    rg char(10) not null,
    nome varchar(60) not null,
    endereco varchar(50) not null,
    rendaMensal float,
    primary key(idCliente, conta),
    constraint fk_contaCliente foreign key(conta) references contaBanco(idConta) on update cascade
    );
    
    alter table clienteBanco add column UF char(2) not null default 'BA';
    update clienteBanco set UF = 'BA' where endereco = 'Av. Luís Viana Filho';
    insert into clienteBanco(conta, cpf, rg, nome, endereco, rendaMensal) values(1, 58178174682, 5649845476, 'Carlos Araújo', 'Av. Luís Viana Filho', 6700);
    insert into clienteBanco(conta, cpf, rg, nome, endereco, rendaMensal) values(2, 14581461486, 2846984724, 'Matheus Oliveira', 'Av. Paulista', 3500);
    
    create table transacoesBanco(
		idTransacao int auto_increment primary key,
        ocorrencia timestamp,
        statusTransacao varchar(20),
        valorTransacao float,
        contaOrigem int,
        contaDestino int,
        constraint fk_contaOrigem foreign key(contaOrigem) references contaBanco(idConta),
        constraint fk_contaDestino foreign key(contaDestino) references contaBanco(idConta)
    );
    
    desc contaBanco;
    desc clienteBanco;
    desc transacoesBanco;
    
    select * from clienteBanco;
    select * from contaBanco;
    select * from transacoesBanco;
    
    -- Tabelas só serão removidas se não possuírem foreign key.