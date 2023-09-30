CREATE DATABASE FERRETERIA;

USE FERRETERIA;

CREATE TABLE refacciones(
codigobarras INT PRIMARY KEY,
nombre VARCHAR(50),
descripcion VARCHAR(200),
marca VARCHAR(50));
INSERT INTO refacciones VALUES(54346,'Rines','para tornado 2008','apocalipsy');
INSERT INTO refacciones VALUES(54357,'llanta','para chevy 2008','chevrolet');

CREATE TABLE taller(
codigoherramienta INT PRIMARY KEY,
nombre VARCHAR(50),
medida VARCHAR(10),
marca VARCHAR(50),
descripcion VARCHAR(200));
INSERT INTO taller VALUES(5454,'llave inglesa','27cm','truper','color plateada');
INSERT INTO taller VALUES(3232,'pinsas','19cm','hermex','color negro');
CREATE TABLE USUARIOS(
idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(50),
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fechanacimiento VARCHAR(50),
rfc VARCHAR(13),
clave VARCHAR(255),
lectura BOOLEAN,
escritura BOOLEAN,
eliminacion BOOLEAN,
actualizar BOOLEAN);
DROP TABLE usuarios;
INSERT INTO usuarios VALUES(NULL,'Luis Antonio','Zermeño','Muñoz','05/03/02','ZEML050302',SHA1('12345'),TRUE,TRUE,TRUE,TRUE);
INSERT INTO usuarios VALUES(NULL,'Luis','Zermeño','Muñoz','05/03/02','ZEML050302',SHA1('12345'),TRUE,TRUE,FALSE,TRUE);
INSERT INTO usuarios VALUES(NULL,'Antonio','Zermeño','Muñoz','05/03/02','ZEML050302',SHA1('12345'),TRUE,FALSE,FALSE,FALSE);
delimiter //
DROP PROCEDURE if EXISTS P_Validar;
CREATE PROCEDURE P_Validar(
IN _nombre VARCHAR(100),
IN _clave VARCHAR(255))
BEGIN
DECLARE x INT;
SELECT COUNT(*) FROM USUARIOS WHERE nombre=_nombre AND clave=_clave INTO X;
if X>0 then
SELECT 'C0rr3ct0' AS rs;
ELSE
SELECT 'Error' AS rs;
END if;
END;
//
CALL P_Validar('Luis Antonio',SHA1('12345'));
SELECT u.lectura,u.escritura,u.eliminacion,u.actualizar FROM usuarios u WHERE nombre='Luis Antonio' ;



delimiter //
DROP PROCEDURE if EXISTS P_Permisos;
CREATE PROCEDURE P_Permisos(
IN _nombre VARCHAR(100))
BEGIN
DECLARE _lectura BOOL;
DECLARE _escritura BOOLEAN;
DECLARE _eliminacion BOOLEAN;
DECLARE _actualizar BOOLEAN;
SELECT u.lectura FROM usuarios u WHERE nombre=_nombre INTO _lectura;
SELECT u.escritura FROM usuarios u WHERE nombre=_nombre INTO _escritura;
SELECT u.eliminacion FROM usuarios u WHERE nombre=_nombre INTO _eliminacion;
SELECT u.actualizar FROM usuarios u WHERE nombre=_nombre INTO _actualizar;

SELECT CONCAT(_lectura,',',_escritura,',',_eliminacion,',',_actualizar) AS rs;

END;
//
CALL P_Permisos('Luis Antonio');