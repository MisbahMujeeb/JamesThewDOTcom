
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/17/2019 15:43:43
-- Generated from EDMX file: C:\Users\haseeb\Desktop\eProject(JamesTHewDOTcom)\JamesThewDOTcom\WebApplication1\Models\myModels.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [JamesThewDOTcom];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RoleUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_RoleUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Subscription_TypeUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Subscription_TypeUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersParticipants]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participants] DROP CONSTRAINT [FK_UsersParticipants];
GO
IF OBJECT_ID(N'[dbo].[FK_ContestsParticipants]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Participants] DROP CONSTRAINT [FK_ContestsParticipants];
GO
IF OBJECT_ID(N'[dbo].[FK_FeedbacksUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Feedbacks] DROP CONSTRAINT [FK_FeedbacksUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_RecipesUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recipes1] DROP CONSTRAINT [FK_RecipesUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_TipsUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tips] DROP CONSTRAINT [FK_TipsUsers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Roles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Roles];
GO
IF OBJECT_ID(N'[dbo].[Subscription_Type]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subscription_Type];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Annoucments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Annoucments];
GO
IF OBJECT_ID(N'[dbo].[Contests1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contests1];
GO
IF OBJECT_ID(N'[dbo].[Participants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Participants];
GO
IF OBJECT_ID(N'[dbo].[Feedbacks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Feedbacks];
GO
IF OBJECT_ID(N'[dbo].[Recipes1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recipes1];
GO
IF OBJECT_ID(N'[dbo].[Tips]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tips];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Roles'
CREATE TABLE [dbo].[Roles] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Role_name] varchar(10)  NULL
);
GO

-- Creating table 'Subscription_Type'
CREATE TABLE [dbo].[Subscription_Type] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Sub_Type] varchar(10)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [User_Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Role_id] int  NOT NULL,
    [Subscription_Type_id] int  NOT NULL
);
GO

-- Creating table 'Annoucments'
CREATE TABLE [dbo].[Annoucments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [Date_Of_Annoucment] datetime  NOT NULL
);
GO

-- Creating table 'Contests1'
CREATE TABLE [dbo].[Contests1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NULL
);
GO

-- Creating table 'Participants'
CREATE TABLE [dbo].[Participants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Ingridiants] nvarchar(max)  NOT NULL,
    [Details] time  NOT NULL,
    [UsersId] int  NOT NULL,
    [ContestsId] int  NOT NULL
);
GO

-- Creating table 'Feedbacks'
CREATE TABLE [dbo].[Feedbacks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UsersId] int  NOT NULL,
    [Feedback] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Recipes1'
CREATE TABLE [dbo].[Recipes1] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Ingridiants] nvarchar(max)  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [UsersId] int  NOT NULL,
    [ImagePath] nvarchar(max)  NOT NULL,
    [FreeOrPaid] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Tips'
CREATE TABLE [dbo].[Tips] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Details] nvarchar(max)  NOT NULL,
    [UsersId] int  NOT NULL
);
GO

-- Creating table 'Recipe_Feedback'
CREATE TABLE [dbo].[Recipe_Feedback] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RecipeFeedback] nvarchar(max)  NOT NULL,
    [RecipesId] int  NOT NULL,
    [UsersId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Roles'
ALTER TABLE [dbo].[Roles]
ADD CONSTRAINT [PK_Roles]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Subscription_Type'
ALTER TABLE [dbo].[Subscription_Type]
ADD CONSTRAINT [PK_Subscription_Type]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Annoucments'
ALTER TABLE [dbo].[Annoucments]
ADD CONSTRAINT [PK_Annoucments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Contests1'
ALTER TABLE [dbo].[Contests1]
ADD CONSTRAINT [PK_Contests1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Participants'
ALTER TABLE [dbo].[Participants]
ADD CONSTRAINT [PK_Participants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Feedbacks'
ALTER TABLE [dbo].[Feedbacks]
ADD CONSTRAINT [PK_Feedbacks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recipes1'
ALTER TABLE [dbo].[Recipes1]
ADD CONSTRAINT [PK_Recipes1]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tips'
ALTER TABLE [dbo].[Tips]
ADD CONSTRAINT [PK_Tips]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recipe_Feedback'
ALTER TABLE [dbo].[Recipe_Feedback]
ADD CONSTRAINT [PK_Recipe_Feedback]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Role_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_RoleUsers]
    FOREIGN KEY ([Role_id])
    REFERENCES [dbo].[Roles]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RoleUsers'
CREATE INDEX [IX_FK_RoleUsers]
ON [dbo].[Users]
    ([Role_id]);
GO

-- Creating foreign key on [Subscription_Type_id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Subscription_TypeUsers]
    FOREIGN KEY ([Subscription_Type_id])
    REFERENCES [dbo].[Subscription_Type]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Subscription_TypeUsers'
CREATE INDEX [IX_FK_Subscription_TypeUsers]
ON [dbo].[Users]
    ([Subscription_Type_id]);
GO

-- Creating foreign key on [UsersId] in table 'Participants'
ALTER TABLE [dbo].[Participants]
ADD CONSTRAINT [FK_UsersParticipants]
    FOREIGN KEY ([UsersId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersParticipants'
CREATE INDEX [IX_FK_UsersParticipants]
ON [dbo].[Participants]
    ([UsersId]);
GO

-- Creating foreign key on [ContestsId] in table 'Participants'
ALTER TABLE [dbo].[Participants]
ADD CONSTRAINT [FK_ContestsParticipants]
    FOREIGN KEY ([ContestsId])
    REFERENCES [dbo].[Contests1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContestsParticipants'
CREATE INDEX [IX_FK_ContestsParticipants]
ON [dbo].[Participants]
    ([ContestsId]);
GO

-- Creating foreign key on [UsersId] in table 'Feedbacks'
ALTER TABLE [dbo].[Feedbacks]
ADD CONSTRAINT [FK_FeedbacksUsers]
    FOREIGN KEY ([UsersId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FeedbacksUsers'
CREATE INDEX [IX_FK_FeedbacksUsers]
ON [dbo].[Feedbacks]
    ([UsersId]);
GO

-- Creating foreign key on [UsersId] in table 'Recipes1'
ALTER TABLE [dbo].[Recipes1]
ADD CONSTRAINT [FK_RecipesUsers]
    FOREIGN KEY ([UsersId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RecipesUsers'
CREATE INDEX [IX_FK_RecipesUsers]
ON [dbo].[Recipes1]
    ([UsersId]);
GO

-- Creating foreign key on [UsersId] in table 'Tips'
ALTER TABLE [dbo].[Tips]
ADD CONSTRAINT [FK_TipsUsers]
    FOREIGN KEY ([UsersId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipsUsers'
CREATE INDEX [IX_FK_TipsUsers]
ON [dbo].[Tips]
    ([UsersId]);
GO

-- Creating foreign key on [RecipesId] in table 'Recipe_Feedback'
ALTER TABLE [dbo].[Recipe_Feedback]
ADD CONSTRAINT [FK_Recipe_FeedbackRecipes]
    FOREIGN KEY ([RecipesId])
    REFERENCES [dbo].[Recipes1]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Recipe_FeedbackRecipes'
CREATE INDEX [IX_FK_Recipe_FeedbackRecipes]
ON [dbo].[Recipe_Feedback]
    ([RecipesId]);
GO

-- Creating foreign key on [UsersId] in table 'Recipe_Feedback'
ALTER TABLE [dbo].[Recipe_Feedback]
ADD CONSTRAINT [FK_Recipe_FeedbackUsers]
    FOREIGN KEY ([UsersId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Recipe_FeedbackUsers'
CREATE INDEX [IX_FK_Recipe_FeedbackUsers]
ON [dbo].[Recipe_Feedback]
    ([UsersId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------