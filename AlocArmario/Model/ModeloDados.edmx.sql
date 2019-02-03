
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/02/2019 23:57:32
-- Generated from EDMX file: C:\Users\HOME\source\repos\AlocArmario\AlocArmario\Model\ModeloDados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AlocArmarioBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArmarioContrato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contrato] DROP CONSTRAINT [FK_ArmarioContrato];
GO
IF OBJECT_ID(N'[dbo].[FK_Aluga]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contrato] DROP CONSTRAINT [FK_Aluga];
GO
IF OBJECT_ID(N'[dbo].[FK_Possui]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Armario] DROP CONSTRAINT [FK_Possui];
GO
IF OBJECT_ID(N'[dbo].[FK_SecaoBloco]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bloco] DROP CONSTRAINT [FK_SecaoBloco];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Locatario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locatario];
GO
IF OBJECT_ID(N'[dbo].[Armario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Armario];
GO
IF OBJECT_ID(N'[dbo].[Contrato]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contrato];
GO
IF OBJECT_ID(N'[dbo].[Bloco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bloco];
GO
IF OBJECT_ID(N'[dbo].[Secao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Secao];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Locatario'
CREATE TABLE [dbo].[Locatario] (
    [IdLocatario] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Prontuario] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NULL,
    [Telefone] nvarchar(max)  NULL,
    [TemContrato] bit  NOT NULL
);
GO

-- Creating table 'Armario'
CREATE TABLE [dbo].[Armario] (
    [IdArmario] int IDENTITY(1,1) NOT NULL,
    [IdBloco] int  NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [TemContrato] bit  NOT NULL,
    [Danificado] bit  NOT NULL
);
GO

-- Creating table 'Contrato'
CREATE TABLE [dbo].[Contrato] (
    [IdContrato] int IDENTITY(1,1) NOT NULL,
    [Validade] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [IdArmario] int  NOT NULL,
    [IdLocatario] int  NOT NULL,
    [TipoContrato] nvarchar(max)  NOT NULL,
    [Terminado] bit  NOT NULL,
    [DataInicio] datetime  NOT NULL
);
GO

-- Creating table 'Bloco'
CREATE TABLE [dbo].[Bloco] (
    [IdBloco] int IDENTITY(1,1) NOT NULL,
    [Numero] nvarchar(max)  NOT NULL,
    [IdSecao] int  NULL
);
GO

-- Creating table 'Secao'
CREATE TABLE [dbo].[Secao] (
    [IdSecao] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Numero] int  NOT NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Prontuario] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdLocatario] in table 'Locatario'
ALTER TABLE [dbo].[Locatario]
ADD CONSTRAINT [PK_Locatario]
    PRIMARY KEY CLUSTERED ([IdLocatario] ASC);
GO

-- Creating primary key on [IdArmario] in table 'Armario'
ALTER TABLE [dbo].[Armario]
ADD CONSTRAINT [PK_Armario]
    PRIMARY KEY CLUSTERED ([IdArmario] ASC);
GO

-- Creating primary key on [IdContrato] in table 'Contrato'
ALTER TABLE [dbo].[Contrato]
ADD CONSTRAINT [PK_Contrato]
    PRIMARY KEY CLUSTERED ([IdContrato] ASC);
GO

-- Creating primary key on [IdBloco] in table 'Bloco'
ALTER TABLE [dbo].[Bloco]
ADD CONSTRAINT [PK_Bloco]
    PRIMARY KEY CLUSTERED ([IdBloco] ASC);
GO

-- Creating primary key on [IdSecao] in table 'Secao'
ALTER TABLE [dbo].[Secao]
ADD CONSTRAINT [PK_Secao]
    PRIMARY KEY CLUSTERED ([IdSecao] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdArmario] in table 'Contrato'
ALTER TABLE [dbo].[Contrato]
ADD CONSTRAINT [FK_ArmarioContrato]
    FOREIGN KEY ([IdArmario])
    REFERENCES [dbo].[Armario]
        ([IdArmario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArmarioContrato'
CREATE INDEX [IX_FK_ArmarioContrato]
ON [dbo].[Contrato]
    ([IdArmario]);
GO

-- Creating foreign key on [IdLocatario] in table 'Contrato'
ALTER TABLE [dbo].[Contrato]
ADD CONSTRAINT [FK_Aluga]
    FOREIGN KEY ([IdLocatario])
    REFERENCES [dbo].[Locatario]
        ([IdLocatario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Aluga'
CREATE INDEX [IX_FK_Aluga]
ON [dbo].[Contrato]
    ([IdLocatario]);
GO

-- Creating foreign key on [IdBloco] in table 'Armario'
ALTER TABLE [dbo].[Armario]
ADD CONSTRAINT [FK_Possui]
    FOREIGN KEY ([IdBloco])
    REFERENCES [dbo].[Bloco]
        ([IdBloco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Possui'
CREATE INDEX [IX_FK_Possui]
ON [dbo].[Armario]
    ([IdBloco]);
GO

-- Creating foreign key on [IdSecao] in table 'Bloco'
ALTER TABLE [dbo].[Bloco]
ADD CONSTRAINT [FK_SecaoBloco]
    FOREIGN KEY ([IdSecao])
    REFERENCES [dbo].[Secao]
        ([IdSecao])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SecaoBloco'
CREATE INDEX [IX_FK_SecaoBloco]
ON [dbo].[Bloco]
    ([IdSecao]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------