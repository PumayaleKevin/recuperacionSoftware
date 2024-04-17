create database turistas_software2
use turistas_software2

create table clientes 
(id_clientes int primary key not null ,
nombres varchar (100) not null,
edad  int not null,
)

create table lugarVisita
(id_lugarVisita int primary key not null,
nombre varchar(50) not null,
tipo_cliente varchar(50) not null,
precio decimal(10,2) not null,
id_clientes int, 
foreign key (id_clientes) references clientes (id_clientes)
)

