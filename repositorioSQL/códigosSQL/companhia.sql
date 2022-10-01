create schema if not exists companhia;

use companhia;

drop database companhia;

create table empregado(
	primeiroNome varchar(20) not null,
    nomeDoMeio varchar(20),
    ultimoNome varchar(20) not null,
    cpf int primary key,
    dataNascimento date not null,
    endereco varchar(60) not null,
    genero enum('M' , 'F') not null,
    salario decimal(6,2) not null,
    codigoSupervisor int not null unique,
    codigoDepartamento int not null,
    constraint chk_salarioEmpregado check (salario > 2000)
);

alter table empregado
	add foreign key(codigoSupervisor) references empregado(cpf) on delete set null on update cascade;

create table departamento(
	nomeDepartamento varchar(15) not null unique,
    numeroDepartamento int primary key,
    codigoGerente int,
    dataInicioGerente date,
    dataCriacaoDepartamento date,
    foreign key(codigoGerente) references empregado(cpf),
    constraint chk_dataDepartamento check (dataCriacaoDepartamento <= dataInicioGerente)
);

create table localDepartamento(
	numeroDepartamento int,
    localDepartamento varchar(20),
    primary key(numeroDepartamento, localDepartamento),
    foreign key(numeroDepartamento) references departamento(numeroDepartamento)
);

create table projeto(
	nomeProjeto varchar(30) not null unique,
    numeroProjeto int primary key,
    localProjeto varchar(20),
    numeroDepartamento int not null,
    foreign key(numeroDepartamento) references departamento(numeroDepartamento)
);

create table trabalhaEm(
	id int,
    numeroProjeto int,
    horas decimal(3,2) not null,
    primary key(id, numeroProjeto),
    foreign key(id) references empregado(cpf),
    foreign key(numeroProjeto) references projeto(numeroProjeto)
);

create table dependente(
	id int,
    nomeDependente varchar(30),
    genero enum('M' , 'F') not null,
    dataNascimento date not null,
    anoNascimento year not null,
    relacionamento varchar(10) not null,
    constraint chk_idadeDependente check (anoNascimento < 2000),
    primary key(id, nomeDependente),
    foreign key(id) references empregado(cpf)
);

show tables;

desc dependente;

desc empregado;

desc localDepartamento;

desc departamento;

desc projeto;

desc trabalhaEm;

delete from empregado where primeiroNome = 'Maria';

insert into empregado values('João', 'M.', 'Barreto', 46928017, '2002-09-05', 'Al. das Espatódeas, 2540', 'M', 3000, '1', '1'),
							('Maria', 'A.', 'Oliveira', 62814650, '1998-11-30', 'R. Jornalista Orlando Garcia, 158', 'F', 4500, '2', '2'),
							('Matheus', 'C.', 'Sales', 47286910, '1999-02-20', 'R. Aliomar Baleeiro, 426', 'M', 2500, '46928017', '3');
                            
insert into dependente values('46928017', 'Mário', 'M', '1992-02-20', 1992, 'Pai'),
							 ('62814650', 'Carla', 'F', '1990-12-07', 1990, 'Mãe'),
                             ('47286910', 'Miguel', 'M', '1996-05-23', 1996, 'Filho');
                             
insert into localDepartamento values(1, 'São Paulo'),
									(2, 'Rio de Janeiro'),
									(3, 'Recife');
                                     
insert into departamento values('Pesquisa', 1, 46928017, '2020-01-01', '2019-01-01'),
							   ('Administração', 2, 62814650, '2020-01-01', '2019-01-01'),
							   ('RH', 3, 47286910, '2018-01-01', '2017-01-01');
                               
insert into projeto values('Projeto 1', 1, 'São Paulo', 1),
						  ('Projeto 2', 2, 'Rio de Janeiro', 2),
                          ('Projeto 3', 3, 'Recife', 3);
                          
insert into trabalhaEm values(46928017, 1, 0.0),
							 (62814650, 2, 0.0),
                             (47286910, 3, 0.0);

select * from information_schema.table_constraints where constraint_schema = 'companhia';

select * from trabalhaEm;

-- create domain dNum as int check(dNum >= x and dNum <= y); // Domínio de numeros inteiros de x a y.
-- alter table - drop constraint / alter table - add // Modificar o nome de uma constraint (PK  e FK).
-- on delete cascade - on update cascade // Deleção e atualização da linha em cascata, passada em herança (filhas).
-- desc // Descreve uma tabela.
-- show // Mostra as tabelas existentes dentro da database.
-- insert into table values // Persistência de dados no schema.

-- Gerente e seu departamento
select cpf, primeiroNome, nomeDepartamento from empregado e, departamento d where e.cpf = d.codigoGerente;

-- Recuperando dependentes de empregados:
select primeiroNome, nomeDependente, relacionamento from empregado e, dependente d where e.cpf = d.id;

-- Procurando por pessoa específica usando operador lógico:
select primeiroNome, ultimoNome, dataNascimento, endereco from empregado where primeiroNome = 'João' and ultimoNome = 'Barreto';

-- Recuperando departamento específico:
select * from departamento where nomeDepartamento = 'Pesquisa';

-- Recuperando pessoa que trabalha em certo departamento:
select primeiroNome, ultimoNome, endereco from empregado e, departamento d where d.nomeDepartamento = 'Pesquisa' and d.numeroDepartamento = e.codigoDepartamento;

-- Query mesclada:
select nomeProjeto, cpf, primeiroNome, horas from projeto p, trabalhaEm t, empregado e where p.numeroProjeto = t.numeroProjeto and e.cpf = t.id;

-- Retirando a ambiguidade com o 'as':
select nomeDepartamento, localDepartamento from departamento d, localDepartamento l where d.numeroDepartamento = l.numeroDepartamento;

-- Concatenando atributos:

select concat(primeiroNome, ' ', nomeDoMeio, ' ', ultimoNome) as empregado from empregado;

-- Expressões e alias (funções renomeadoras/recuperadoras):

-- 1. INSS:

select primeiroNome, ultimoNome, salario, round(salario*0.011 , 2) as INSS from empregado;

-- 2. Aumento de salário para um cenário específico:

select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, salario as salarioAntigo, round(salario*1.15,2) as salarioNovo from empregado e, trabalhaEm t, projeto p where e.cpf = t.id and t.numeroProjeto = p.numeroProjeto and p.nomeProjeto = 'Projeto 1';

-- Recuperando mais informações:

select nomeDepartamento, codigoGerente, endereco from departamento d, localdepartamento l, empregado e where d.numeroDepartamento = l.numeroDepartamento and localDepartamento = 'Recife';

-- Operadores especiais (like, between, etc.):

select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, nomeDepartamento, endereco from empregado e, departamento d where e.codigoDepartamento = d.numeroDepartamento and endereco like '%Al. %';
select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, nomeDepartamento, endereco from empregado e, departamento d where salario between 2000 and 3000;
select * from departamento where nomeDepartamento = 'RH' or nomeDepartamento = 'Pesquisa';

-- Subqueries:

select distinct numeroProjeto from projeto where numeroProjeto in(select distinct numeroProjeto from empregado e, trabalhaEm t where t.id = e.cpf and e.ultimoNome = 'Barreto') or (select distinct numeroProjeto from empregado e, departamento d, projeto p where d.codigoGerente = e.cpf and e.ultimoNome = 'Barreto' and d.numeroDepartamento <> p.numeroProjeto);
select * from trabalhaEm where(numeroProjeto, horas) in(select numeroProjeto, horas from trabalhaEm where id = 46928017);

-- Unique e exists/not exists:

select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto from empregado e where exists(select * from dependente d where e.cpf = d.id and e.primeiroNome <> d.nomeDependente);
select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto from empregado e where not exists(select * from dependente d where e.cpf = d.id);
select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto from empregado e, departamento q where e.cpf = q.codigoGerente and exists(select * from empregado e, dependente d where e.cpf = d.id);

-- Cláusulas de ordenação:

select * from empregado order by salario;
select distinct nomeDepartamento, concat(primeiroNome, ' ', ultimoNome) as nomeCompleto from departamento d, empregado e, trabalhaEm t, projeto p where d.numeroDepartamento = e.codigoDepartamento and e.cpf = d.codigoGerente and t.numeroProjeto = p.numeroProjeto order by d.nomeDepartamento, e.primeiroNome, e.ultimoNome;
select distinct nomeDepartamento, concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, nomeProjeto, endereco from departamento d, empregado e, trabalhaEm t, projeto p where d.numeroDepartamento = e.codigoDepartamento and e.cpf = t.id and t.numeroProjeto = p.numeroProjeto order by nomeCompleto desc;

-- Cláusulas de agrupamento:

select count(*) from empregado;
select count(*) from empregado e, departamento d where e.codigoDepartamento = d.numeroDepartamento and d.nomeDepartamento = 'RH';
select codigoDepartamento, count(*), round(avg(salario),2) as mediaSalarial from empregado group by codigoDepartamento;
select p.numeroProjeto, p.nomeProjeto, count(*) from projeto p, trabalhaEm t where p.numeroProjeto = t.numeroProjeto group by p.numeroProjeto, p.nomeProjeto;
select count(distinct salario) from empregado;
select sum(salario), max(salario), min(salario), round(avg(salario),2) as mediaSalarial from empregado;
select p.numeroProjeto, p.nomeProjeto, count(*), round(avg(salario),2) as mediaSalarial from projeto p, trabalhaEm t, empregado e where p.numeroProjeto = t.numeroProjeto and e.cpf = t.id group by p.numeroProjeto, p.nomeProjeto order by avg(salario) desc;

-- Having:

select p.numeroProjeto, p.nomeProjeto, count(*) from projeto p, trabalhaEm t where p.numeroProjeto = t.numeroProjeto group by p.numeroProjeto, p.nomeProjeto having count(*) < 2;
select codigoDepartamento, count(*) from empregado where salario > 2500 group by codigoDepartamento having count(*) < 2;
select codigoDepartamento, count(*) from empregado where salario > 2500 and codigoDepartamento in(select codigoDepartamento from empregado group by codigoDepartamento having count(*) < 6) group by codigoDepartamento;

-- Operador CASE:

select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, salario, codigoDepartamento from empregado;
update empregado set salario = case when codigoDepartamento = 1 then salario + 500 when codigoDepartamento = 2 then salario + 1000 when codigoDepartamento = 3 then salario + 750 else salario + 0 end;

-- JOINS

select * from empregado join projeto;
select * from empregado join trabalhaEm on cpf = id;
select * from empregado join departamento on cpf = codigoGerente;
select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, endereco from empregado join departamento on codigoDepartamento = numeroDepartamento where nomeDepartamento = 'RH';
select nomeDepartamento, dataCriacaoDepartamento, localDepartamento from departamento d join localDepartamento l using(numeroDepartamento) group by localDepartamento order by dataCriacaoDepartamento;
select * from empregado cross join dependente;

-- JOINS com 3 tabelas:

select cpf, concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, nomeProjeto, salario from empregado e inner join trabalhaEm t on e.cpf = t.id inner join projeto p on t.numeroProjeto = p.numeroProjeto where p.nomeProjeto like 'Projeto%' order by e.salario;
select concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, localDepartamento from departamento d inner join localDepartamento l using(numeroDepartamento) inner join empregado e on cpf = codigoGerente;
select q.numeroDepartamento, nomeDepartamento, concat(primeiroNome, ' ', ultimoNome) as nomeCompleto, round(salario*0.1,2) as bonus, round(salario*1.1,2) as salarioAtualizado from departamento q inner join localDepartamento l using(numeroDepartamento) inner join (dependente d inner join empregado e on e.cpf = d.id) on e.cpf = q.codigoGerente group by q.numeroDepartamento having count(*) > 0;

-- OUTER JOIN:

select * from empregado inner join dependente on cpf = id;
select * from empregado left join dependente on cpf = id;
select * from empregado left outer join dependente on cpf = id;

