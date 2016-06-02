
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2016 01:46:50
-- Generated from EDMX file: C:\Users\Ryan\Documents\Visual Studio 2015\Projects\PrototipoFuncional\PrototipoFuncional\InfoDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Info];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[InformationSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InformationSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'InformationSet'
CREATE TABLE [dbo].[InformationSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [Ocupation] nvarchar(max)  NOT NULL,
    [Symptoms] nvarchar(max)  NOT NULL,
    [Medication] nvarchar(max)  NOT NULL,
    [Diagnoses] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'InformationSet'
ALTER TABLE [dbo].[InformationSet]
ADD CONSTRAINT [PK_InformationSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------