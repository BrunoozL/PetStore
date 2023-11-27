create database db_petshop;
use db_petshop;

create table cliente (
id int auto_increment,
nome_do_cliente varchar(200),
telefone char(11),
cep char(8),
cpf char(11),
primary key(id)
);

create table animal (
id int auto_increment,
id_cliente int,
nome_do_animal varchar(100),
sexo varchar(100),
especie varchar(100),
data_nasc_animal date,
raça varchar(100),
observacoes varchar(300),
foto_do_animal bool,
foreign key (id_cliente) references cliente(id),
primary key(id)
);


create table tipo_produto (
id int auto_increment,
racao bool,
shampoo bool,
casinha bool,
primary key(id)
);

create table produto (
id int auto_increment,
id_tipo_produto int,
nome_do_produto varchar(200),
preco_produto double,
disponivel_p_venda bool,
validade date,
foto_do_produto bool,
foreign key (id_tipo_produto) references tipo_produto(id),
primary key(id)
);

create table servicos (
id int auto_increment,
id_animal int,
servico_disponivel bool,
preco_servico double,
horarios_disponiveis bool,
primary key(id),
foreign key (id_animal) references animal(id)
);