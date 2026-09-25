CREATE DATABASE EmpresaDB;
  
USE EmpresaDB;
  
CREATE TABLE Clientes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Email VARCHAR(150) NOT NULL,
    Telefono VARCHAR(30) NULL
);

Select * from Clientes; 
