-- Union, intersect and except

create database if not exists testes;
use testes;

create table x(
	a char(2)
);

create table y(
	a char(2)
);

insert into x values ('a1'), ('a2'), ('a2'), ('a3');
insert into y values ('a1'), ('a1'), ('a2'), ('a3'), ('a4'), ('a5');

select * from x;
select * from y;

-- Except:

select * from y where a not in(select * from x);

-- Union:

select distinct a from x union select distinct a from y;

-- Intersect:

select a from x where a in (select a from y);