CREATE DATABASE FilePilot
USE FilePilot
drop database FilePilot;
CREATE TABLE Usuario (
    idUsuario INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    correo VARCHAR(100) UNIQUE NOT NULL,
    rol VARCHAR(20) NOT NULL CHECK (rol IN ('General', 'Administrador', 'Desarrollador')),
    contraseña VARCHAR(255) NOT NULL,
    fechaRegistro DATE DEFAULT GETDATE()
);

CREATE TABLE Documento (
    idDocumento INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(255) NOT NULL,
    tipo VARCHAR(50),
    categoria VARCHAR(100),
    rutaArchivo VARCHAR(255),
    fechaSubida DATE DEFAULT GETDATE(),
    usuarioPropietario INT,
    FOREIGN KEY (usuarioPropietario) REFERENCES Usuario(idUsuario)
);

CREATE TABLE Autenticacion (
    idAutenticacion INT PRIMARY KEY IDENTITY(1,1),
    idUsuario INT,
    tokenSesion VARCHAR(255) UNIQUE NOT NULL,
    fechaExpiracion DATE,
    FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
);

CREATE TABLE LogSistema (
    idLog INT PRIMARY KEY IDENTITY(1,1),
    fechaEvento DATE DEFAULT GETDATE(),
    tipoEvento VARCHAR(50),
    descripcion TEXT,
    usuarioRelacionado INT,
    FOREIGN KEY (usuarioRelacionado) REFERENCES Usuario(idUsuario)
);

CREATE TABLE ErrorSistema (
    idError INT PRIMARY KEY IDENTITY(1,1),
    fecha DATETIME DEFAULT GETDATE(),
    descripcion TEXT,
    estado VARCHAR(20) DEFAULT 'Pendiente' CHECK (estado IN ('Pendiente', 'Resuelto')),
    usuarioReporta INT,
    FOREIGN KEY (usuarioReporta) REFERENCES Usuario(idUsuario)
);

CREATE TABLE Respaldo (
    idRespaldo INT PRIMARY KEY IDENTITY(1,1),
    fecha DATETIME DEFAULT GETDATE(),
    tipo VARCHAR(20) CHECK (tipo IN ('Automático', 'Manual')),
    usuarioResponsable INT NOT NULL,
    nombreArchivo VARCHAR(255) NOT NULL,
    tipoArchivo VARCHAR(50),
    contenido VARBINARY(MAX) NOT NULL,
    categoria VARCHAR(100),
    idDocumentoOriginal INT,
    FOREIGN KEY (idDocumentoOriginal) REFERENCES Documento(idDocumento),
    FOREIGN KEY (usuarioResponsable) REFERENCES Usuario(idUsuario) ON DELETE CASCADE
);


CREATE TABLE Migracion (
    idMigracion INT PRIMARY KEY IDENTITY(1,1),
    fecha DATE DEFAULT GETDATE(),
    scriptSQL TEXT,
    descripcion TEXT,
    usuarioResponsable INT,
    FOREIGN KEY (usuarioResponsable) REFERENCES Usuario(idUsuario)
);

CREATE TABLE Categoria (
    idCategoria INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL UNIQUE,
    idUsuario INT NOT NULL,
    FOREIGN KEY (idUsuario) REFERENCES Usuario(idUsuario)
);


select * from Respaldo;
drop table Usuario;
DBCC CHECKIDENT ('Usuario', RESEED, 0)
