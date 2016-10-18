create database BD_RumboAgil
use BD_RumboAgil

create table T_Estado (
	Id_Estado tinyint primary key identity(1,1) not null,
	Estado varchar(15) not null
)

create table T_Lugar (
	Id_Lugar tinyint primary key identity(1,1) not null,
	Nombre varchar(20) not null,
	Aforo int not null,
	Direccion varchar(60) not null,
	Descripción text not null
)

create table T_TipoEvento(
	Id_TipoEvento tinyint primary key identity(1,1) not null,
	TipoEvento varchar(20) not null
)

create table T_Persona(
	Id_Persona smallint primary key identity(1, 1) not null,
	Nombres varchar(30) not null,
	Apellidos varchar(30) not null,
	Cumpleaños date null,
	Direccion varchar(60) null,
	Telefono varchar(12) null,
	Correo varchar(20) null,
	Bautizado bit not null
)

create table T_Lider(
	Id_Lider smallint primary key not null,
	EnActividad bit not null,
	Llamado varchar(30) not null,
	foreign key (Id_Lider) references T_Persona(Id_Persona)
)

create table T_Miembro(
	Id_Miembro smallint primary key not null,
	TipoMiembro varchar(10) not null,
	foreign key (Id_Miembro) references T_Persona(Id_Persona)
)

create table T_Ministerio(
	Id_Ministerio tinyint primary key identity(10,10) not null,
	Nombre varchar(15) not null,
	Descripcion text not null
)

create table T_Miembro_Ministerio(
	Id_Ministerio tinyint not null,
	Id_Miembro smallint not null,
	primary key(Id_Ministerio, Id_Miembro),
	Rol varchar(20) not null,
	foreign key (Id_Ministerio) references T_Ministerio(Id_Ministerio),
	foreign key (Id_Miembro) references T_Miembro(Id_Miembro)
)

create table T_Lider_Ministerio(
	Id_Ministerio tinyint not null,
	Id_Lider smallint not null,
	primary key(Id_Ministerio, Id_Lider),
	FechaAsignacion date not null,
	foreign key (Id_Ministerio) references T_Ministerio(Id_Ministerio),
	foreign key (Id_Lider) references T_Lider(Id_Lider)
)

create table T_Usuario(
	Id_Usuario smallint primary key not null,
	Email varchar(20) not null,
	Clave varchar(5) not null,
	foreign key (Id_Usuario) references T_Persona(Id_Persona)
)

create table T_Evento(
	Id_Evento smallint primary key identity(20,20) not null,
	Nombre varchar(50) not null,
	Descripcion text not null,
	Fecha_Inicio date not null,
	Hora_Inicio time null,
	Fecha_fin date null,
	Hora_fin time null,
	Comentario text null,
	Id_Estado tinyint not null,
	Id_TipoEvento tinyint not null,
	Id_Lugar tinyint not null,
	Id_Lider smallint not null,
	foreign key (Id_Estado) references T_Estado(Id_Estado),
	foreign key (Id_TipoEvento) references T_TipoEvento(Id_TipoEvento),
	foreign key (Id_Lugar) references T_Lugar(Id_Lugar),
	foreign key (Id_Lider) references T_Lider(Id_Lider)
)

create table T_Operacion(
	Id_Usuario smallint not null,
	Id_Evento smallint not null,
	primary key(Id_Usuario, Id_Evento),
	Operacion varchar(15) not null,
	FechaOperacion date not null,
	Motivo text null,
	foreign key (Id_Usuario) references T_Usuario(Id_Usuario),
	foreign key (Id_Evento) references T_Evento(Id_Evento)
)

create table T_Participante(
	Id_Persona smallint not null,
	Id_Evento smallint not null,
	primary key(Id_Persona, Id_Evento),
	Responsabilidad varchar(20) not null,
	foreign key (Id_Persona) references T_Persona(Id_Persona),
	foreign key (Id_Evento) references T_Evento(Id_Evento)
)