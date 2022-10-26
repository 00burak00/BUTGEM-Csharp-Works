
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/22/2022 11:50:48
-- Generated from EDMX file: E:\yazilimpaylas\Model_first\Model_first\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [okul_db];
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

-- Creating table 'Ogrenciler'
CREATE TABLE [dbo].[Ogrenciler] (
    [ogno] int IDENTITY(1,1) NOT NULL,
    [ad_soyad] nvarchar(max)  NOT NULL,
    [dog_tar] datetime  NOT NULL
);
GO

-- Creating table 'Notlar'
CREATE TABLE [dbo].[Notlar] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [yaz1] tinyint  NOT NULL,
    [yaz2] tinyint  NOT NULL,
    [ogno] int  NOT NULL,
    [Ders_no] int  NOT NULL
);
GO

-- Creating table 'Dersler'
CREATE TABLE [dbo].[Dersler] (
    [Ders_no] int IDENTITY(1,1) NOT NULL,
    [Ders_adi] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ogno] in table 'Ogrenciler'
ALTER TABLE [dbo].[Ogrenciler]
ADD CONSTRAINT [PK_Ogrenciler]
    PRIMARY KEY CLUSTERED ([ogno] ASC);
GO

-- Creating primary key on [Id] in table 'Notlar'
ALTER TABLE [dbo].[Notlar]
ADD CONSTRAINT [PK_Notlar]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Ders_no] in table 'Dersler'
ALTER TABLE [dbo].[Dersler]
ADD CONSTRAINT [PK_Dersler]
    PRIMARY KEY CLUSTERED ([Ders_no] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ogno] in table 'Notlar'
ALTER TABLE [dbo].[Notlar]
ADD CONSTRAINT [FK_OgrencilerNotlar]
    FOREIGN KEY ([ogno])
    REFERENCES [dbo].[Ogrenciler]
        ([ogno])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OgrencilerNotlar'
CREATE INDEX [IX_FK_OgrencilerNotlar]
ON [dbo].[Notlar]
    ([ogno]);
GO

-- Creating foreign key on [Ders_no] in table 'Notlar'
ALTER TABLE [dbo].[Notlar]
ADD CONSTRAINT [FK_DerslerNotlar]
    FOREIGN KEY ([Ders_no])
    REFERENCES [dbo].[Dersler]
        ([Ders_no])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DerslerNotlar'
CREATE INDEX [IX_FK_DerslerNotlar]
ON [dbo].[Notlar]
    ([Ders_no]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------