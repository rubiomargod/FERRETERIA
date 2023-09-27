CREATE DATABASE FERRETERIA;

USE FERRETERIA;

CREATE TABLE refacciones(
codigobarras INT PRIMARY KEY,
nombre VARCHAR(50),
descripcion VARCHAR(200),
marca VARCHAR(50));
INSERT INTO refacciones VALUES(54346,'Rines','para tornado 2008','apocalipsy');

CREATE TABLE taller(
codigoherramienta INT PRIMARY KEY,
nombre VARCHAR(50),
medida VARCHAR(10),
marca VARCHAR(50),
descripcion VARCHAR(200));
INSERT INTO taller VALUES(5454,'llave inglesa','27cm','truper','color plateada');
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