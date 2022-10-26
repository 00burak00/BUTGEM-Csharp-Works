
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/22/2022 15:35:10
-- Generated from EDMX file: E:\yazilimpaylas\Model_first\Model_first\Models\Hastane_model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Hastane];
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

-- Creating table 'Hastalar'
CREATE TABLE [dbo].[Hastalar] (
    [hasta_no] int IDENTITY(1,1) NOT NULL,
    [Hasta_adi] nvarchar(max)  NOT NULL,
    [Hasta_dogtar] datetime  NOT NULL,
    [Hasta_adres] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Hasta_yatis'
CREATE TABLE [dbo].[Hasta_yatis] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [yat_tarihi] datetime  NOT NULL,
    [cik_tarihi] datetime  NOT NULL,
    [oda_no] tinyint  NOT NULL,
    [hasta_no] int  NOT NULL,
    [Doktor_no] int  NOT NULL,
    [Dept_no] int  NOT NULL
);
GO

-- Creating table 'Departman'
CREATE TABLE [dbo].[Departman] (
    [Dept_no] int IDENTITY(1,1) NOT NULL,
    [Dept_adi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Doktorlar'
CREATE TABLE [dbo].[Doktorlar] (
    [Doktor_no] int IDENTITY(1,1) NOT NULL,
    [Doktor_adi] nvarchar(max)  NOT NULL,
    [Dept_no] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [hasta_no] in table 'Hastalar'
ALTER TABLE [dbo].[Hastalar]
ADD CONSTRAINT [PK_Hastalar]
    PRIMARY KEY CLUSTERED ([hasta_no] ASC);
GO

-- Creating primary key on [Id] in table 'Hasta_yatis'
ALTER TABLE [dbo].[Hasta_yatis]
ADD CONSTRAINT [PK_Hasta_yatis]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Dept_no] in table 'Departman'
ALTER TABLE [dbo].[Departman]
ADD CONSTRAINT [PK_Departman]
    PRIMARY KEY CLUSTERED ([Dept_no] ASC);
GO

-- Creating primary key on [Doktor_no] in table 'Doktorlar'
ALTER TABLE [dbo].[Doktorlar]
ADD CONSTRAINT [PK_Doktorlar]
    PRIMARY KEY CLUSTERED ([Doktor_no] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [hasta_no] in table 'Hasta_yatis'
ALTER TABLE [dbo].[Hasta_yatis]
ADD CONSTRAINT [FK_HastalarHasta_yatis]
    FOREIGN KEY ([hasta_no])
    REFERENCES [dbo].[Hastalar]
        ([hasta_no])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HastalarHasta_yatis'
CREATE INDEX [IX_FK_HastalarHasta_yatis]
ON [dbo].[Hasta_yatis]
    ([hasta_no]);
GO

-- Creating foreign key on [Doktor_no] in table 'Hasta_yatis'
ALTER TABLE [dbo].[Hasta_yatis]
ADD CONSTRAINT [FK_DoktorlarHasta_yatis]
    FOREIGN KEY ([Doktor_no])
    REFERENCES [dbo].[Doktorlar]
        ([Doktor_no])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoktorlarHasta_yatis'
CREATE INDEX [IX_FK_DoktorlarHasta_yatis]
ON [dbo].[Hasta_yatis]
    ([Doktor_no]);
GO

-- Creating foreign key on [Dept_no] in table 'Hasta_yatis'
ALTER TABLE [dbo].[Hasta_yatis]
ADD CONSTRAINT [FK_DepartmanlarHasta_yatis]
    FOREIGN KEY ([Dept_no])
    REFERENCES [dbo].[Departman]
        ([Dept_no])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmanlarHasta_yatis'
CREATE INDEX [IX_FK_DepartmanlarHasta_yatis]
ON [dbo].[Hasta_yatis]
    ([Dept_no]);
GO

-- Creating foreign key on [Dept_no] in table 'Doktorlar'
ALTER TABLE [dbo].[Doktorlar]
ADD CONSTRAINT [FK_DepartmanlarDoktorlar]
    FOREIGN KEY ([Dept_no])
    REFERENCES [dbo].[Departman]
        ([Dept_no])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmanlarDoktorlar'
CREATE INDEX [IX_FK_DepartmanlarDoktorlar]
ON [dbo].[Doktorlar]
    ([Dept_no]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------