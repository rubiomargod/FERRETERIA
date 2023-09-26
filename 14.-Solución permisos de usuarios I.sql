CREATE DATABASE FERRETERIA;

USE FERRETERIA;

CREATE TABLE REFACCIONES(
codigobarras INT PRIMARY KEY,
nombrer VARCHAR(50),
descripcion VARCHAR(200),
marca VARCHAR(50));

CREATE TABLE TALLER(
codigoherramienta INT PRIMARY KEY,
nombre VARCHAR(50),
medida VARCHAR(10),
marca VARCHAR(50),
descripcion VARCHAR(200));

CREATE TABLE USUARIOS(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(50),
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fechanacimiento VARCHAR(50),
rfc VARCHAR(13),
clave VARCHAR(12),
lectura BOOLEAN,
escritura BOOLEAN,
eliminacion BOOLEAN,
actualizar BOOLEAN);

        private int _CodigoBarras;
        private string _Nombre;
        private string _Descripcion;
        private string _Marca;