

CREATE DATABASE LabCafeteria;
GO
USE [master]
GO
CREATE LOGIN [usrcafe] WITH PASSWORD = N'123456',
	DEFAULT_DATABASE = [LabCafeteria],
	CHECK_EXPIRATION = OFF,
	CHECK_POLICY = ON
GO
USE [LabCafeteria]
GO
CREATE USER [usrcafe] FOR LOGIN [usrcafe]
GO
ALTER ROLE [db_owner] ADD MEMBER [usrcafe]
GO

DROP TABLE Producto;
DROP TABLE Cliente;
DROP TABLE Empleado;
DROP TABLE Usuario;
DROP TABLE Pedido;
DROP TABLE DetallePedido;
DROP TABLE Categoria;

CREATE TABLE Producto (
    id INT PRIMARY KEY IDENTITY(1,1),
    idCategoria INT NOT NULL,
    codigo VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250),
    precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT FK_Producto_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria(id)
);

CREATE TABLE Categoria (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL UNIQUE,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1
);

CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL,
    nombres VARCHAR(100) NOT NULL,
    apellidos VARCHAR(100) NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
);

CREATE TABLE Empleado (
    id INT PRIMARY KEY IDENTITY(1,1),
    cedulaIdentidad VARCHAR(12) NOT NULL,
    nombres VARCHAR(30) NOT NULL,
    primerApellido VARCHAR(30) NULL,
    segundoApellido VARCHAR(30) NULL,
    direccion VARCHAR(250) NOT NULL,
    celular BIGINT NOT NULL,
    cargo VARCHAR(50) NOT NULL,  -- Ej: "Cajero", "Barista" etc se agregaran en una opcion cbx en windowns forms
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
);


CREATE TABLE Usuario (
    id INT PRIMARY KEY IDENTITY(1,1),
    idEmpleado INT NOT NULL, 
    usuario VARCHAR(50) UNIQUE NOT NULL,
    clave VARCHAR(255) NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Usuario_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);

CREATE TABLE Pedido (
    id INT PRIMARY KEY IDENTITY(1,1),
    idUsuario INT NOT NULL,
    idCliente INT NOT NULL,
    numeroTransaccion AS 'PED-' + CAST(id AS VARCHAR(10)),
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Venta_Usuario FOREIGN KEY(idUsuario) REFERENCES Usuario(id),
    CONSTRAINT fk_Venta_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
);

CREATE TABLE DetallePedido (
    id INT PRIMARY KEY IDENTITY(1,1),
    idPedido INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL,
    precioUnitario DECIMAL NOT NULL,
    total DECIMAL NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_DetallePedido_Pedido FOREIGN KEY(idPedido) REFERENCES Pedido(id),
    CONSTRAINT fk_DetallePedido_Producto FOREIGN KEY(idProducto) REFERENCES Producto(id)


);

-- DML
--Categorias
INSERT INTO Categoria(nombre)
VALUES ('Comida');

INSERT INTO Categoria(nombre)
VALUES ('Bebida Caliente');

INSERT INTO Categoria(nombre)
VALUES ('Postre');

--Productos
INSERT INTO Producto(idCategoria,codigo,nombre,descripcion,precioVenta)
VALUES (1,'HBR-M', 'Hamburguesa', 'Hamburguesa Mediana', 10);

INSERT INTO Producto(idCategoria,codigo,nombre,descripcion,precioVenta)
VALUES (2,'CF-NC', 'Café', 'Café extra Negro Caliente', 8);

INSERT INTO Producto(idCategoria,codigo,nombre,descripcion,precioVenta)
VALUES (3,'TRA-LP', 'Torta Porcion', 'Torta 3 leches Porcion', 10);

--Empleados
INSERT INTO Empleado(cedulaIdentidad, nombres, primerApellido, segundoApellido, direccion, celular, cargo)
VALUES ('1234567', 'Morty', 'Gato', 'Naranja', 'Calle Loa N° 50', 71717171, 'Cajero');

--Clientes
INSERT INTO Cliente(cedulaIdentidad,nombres,apellidos)
VALUES ('765421', 'Hachi', 'Blanco');

--Usuarios
INSERT INTO Usuario(idEmpleado,usuario,clave)
VALUES (1, 'MortyUser', 'morty123');

--Pedidos
INSERT INTO Pedido (idUsuario, idCliente)
VALUES (1, 1);

SELECT * FROM Categoria;
SELECT * FROM Producto;
SELECT * FROM Empleado;
SELECT * FROM Cliente;
SELECT * FROM Usuario;
SELECT * FROM Pedido;
