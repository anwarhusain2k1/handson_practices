
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/29/2022 23:01:28
-- Generated from EDMX file: D:\practiceprojects\ConsoleApp1\bank_DAL\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Bank];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Borrowers'
CREATE TABLE [dbo].[Borrowers] (
    [borrower_Id] int IDENTITY(1,1) NOT NULL,
    [borr_name] nvarchar(max)  NOT NULL,
    [company_name] nvarchar(max)  NOT NULL,
    [jobname] nvarchar(max)  NOT NULL,
    [address_city] nvarchar(max)  NOT NULL,
    [address_state] nvarchar(max)  NOT NULL,
    [address_country] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'loans'
CREATE TABLE [dbo].[loans] (
    [loan_Id] int IDENTITY(1,1) NOT NULL,
    [loantype] nvarchar(max)  NOT NULL,
    [amount]  int  NOT NULL,
    [duration] nvarchar(max)  NOT NULL,
    [rateofintrest] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [borrower_Id] in table 'Borrowers'
ALTER TABLE [dbo].[Borrowers]
ADD CONSTRAINT [PK_Borrowers]
    PRIMARY KEY CLUSTERED ([borrower_Id] ASC);
GO

-- Creating primary key on [loan_Id] in table 'loans'
ALTER TABLE [dbo].[loans]
ADD CONSTRAINT [PK_loans]
    PRIMARY KEY CLUSTERED ([loan_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------