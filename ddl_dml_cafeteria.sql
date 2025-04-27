

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


CREATE TABLE Producto (
    id INT PRIMARY KEY IDENTITY(1,1),
    codigo VARCHAR(20) NOT NULL,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(250),
    precioVenta DECIMAL NOT NULL CHECK (precioVenta > 0),
    categoria VARCHAR(50) NOT NULL,  -- Ej: "Bebidas", "Comida", "Postres",etc se agregaran en una opcion cbx en windowns forms
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
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
--Productos
INSERT INTO Producto(codigo,nombre,descripcion,precioVenta,categoria)
VALUES ('HBR-M', 'Hamburguesa', 'Hamburguesa Mediana', 10, 'Comida');

INSERT INTO Producto(codigo,nombre,descripcion,precioVenta,categoria)
VALUES ('CF-NC', 'Café', 'Café extra Negro Caliente', 8, 'Bebida Caliente');

INSERT INTO Producto(codigo,nombre,descripcion,precioVenta,categoria)
VALUES ('TRA-LP', 'Torta Porcion', 'Torta 3 leches Porcion', 10, 'Postre');

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

SELECT * FROM Producto;
SELECT * FROM Empleado;
SELECT * FROM Cliente;
SELECT * FROM Usuario;
SELECT * FROM Pedido;
