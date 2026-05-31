-- ============================================================
-- Script de criação do banco de dados - Distribuidora de Água
-- Execute no SQL Server Management Studio ou Azure Data Studio
-- ============================================================

CREATE DATABASE AguaDistribuidora;
GO

USE AguaDistribuidora;
GO

-- Tabela de Clientes
CREATE TABLE clientes (
    id         INT IDENTITY(1,1) PRIMARY KEY,
    nome       NVARCHAR(100) NOT NULL,
    telefone   NVARCHAR(20),
    endereco   NVARCHAR(200),
    bairro     NVARCHAR(100),
    cidade     NVARCHAR(100),
    ativo      BIT DEFAULT 1
);

-- Tabela de Produtos (galões, copos, filtros, etc.)
CREATE TABLE produtos (
    id         INT IDENTITY(1,1) PRIMARY KEY,
    nome       NVARCHAR(100) NOT NULL,
    quantidade INT DEFAULT 0,
    preco      DECIMAL(10,2) DEFAULT 0
);

-- Tabela de Pedidos
CREATE TABLE pedidos (
    id             INT IDENTITY(1,1) PRIMARY KEY,
    cliente        NVARCHAR(100) NOT NULL,
    telefone       NVARCHAR(20),
    produto        NVARCHAR(100),
    quantidade     INT DEFAULT 1,
    endereco       NVARCHAR(200),
    bairro         NVARCHAR(100),
    data_pedido    DATE,
    data_entrega   DATE,
    status         NVARCHAR(50),
    valor          DECIMAL(10,2),
    observacao     NVARCHAR(300)
);

-- Dados de exemplo
INSERT INTO produtos (nome, quantidade, preco) VALUES
    ('Galão 20L', 100, 20.00),
    ('Galão 10L', 50,  12.00),
    ('Copo 200ml (pacote 100un)', 30, 8.50),
    ('Filtro Refil', 20, 45.00),
    ('Suporte/Bebedouro', 5, 150.00);

INSERT INTO clientes (nome, telefone, endereco, bairro, cidade) VALUES
    ('João Silva',   '(11) 99999-1111', 'Rua das Flores, 10',   'Centro',      'São Paulo'),
    ('Maria Santos', '(11) 99999-2222', 'Av. Brasil, 250',      'Jardins',     'São Paulo'),
    ('Pedro Lima',   '(11) 99999-3333', 'Rua 7 de Setembro, 5', 'Vila Nova',   'São Paulo');
GO
