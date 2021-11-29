create database 3A1LAURA26;
use 3A1LAURA26;

create table tbl_dados(
id int auto_increment not null,
lbm varchar(15) not null,
l5 varchar(15) not null,
m3 varchar(15) not null,
primary key(id)
)engine = InnoDB;

create table tbl_usuario(
nome varchar(80),
telefone int(9),
rua varchar(40),
numero int(6),
bairro varchar(40),
cidade varchar(40),
estado char(2),
pais varchar(40),
cpf int(11) not null,
rg char(10),
datanascimento date,
email varchar(120) not null,
senha varchar(30) not null,
primary key(cpf)
)engine = InnoDB;