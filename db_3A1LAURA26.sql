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
cpf varchar(11) not null,
email varchar(120) not null,
senha varchar(30) not null,
nome varchar(80) not null,
telefone int(9) not null,
primary key(cpf)
)engine = InnoDB;

insert into tbl_usuario value("00000000000","usuario@gmail.com","123456","Usuário",999999999)
