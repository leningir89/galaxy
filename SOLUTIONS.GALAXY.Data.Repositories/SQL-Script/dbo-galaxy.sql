

-- ----------------------------
-- Table structure for Hologram
-- ----------------------------
CREATE TABLE [dbo].[Hologram] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] nvarchar(100) NOT NULL ,
[Status] bit NOT NULL DEFAULT ((1)) ,
[Duration] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Hologram]', RESEED, 6)
GO

-- ----------------------------
-- Records of Hologram
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Hologram] ON
GO
INSERT INTO [dbo].[Hologram] ([Id], [Name], [Status], [Duration]) VALUES (N'2', N'Darth Vader II', N'1', N'60')
GO
GO
INSERT INTO [dbo].[Hologram] ([Id], [Name], [Status], [Duration]) VALUES (N'3', N'La Galaxia Black', N'1', N'120')
GO
GO
INSERT INTO [dbo].[Hologram] ([Id], [Name], [Status], [Duration]) VALUES (N'4', N'Anakin Skywalker', N'1', N'50')
GO
GO
INSERT INTO [dbo].[Hologram] ([Id], [Name], [Status], [Duration]) VALUES (N'5', N'Shmi Skywalker', N'1', N'45')
GO
GO
INSERT INTO [dbo].[Hologram] ([Id], [Name], [Status], [Duration]) VALUES (N'6', N'Wedge Antilles', N'1', N'68')
GO
GO
SET IDENTITY_INSERT [dbo].[Hologram] OFF
GO

-- ----------------------------
-- Table structure for Jedi
-- ----------------------------
CREATE TABLE [dbo].[Jedi] (
[Id] int NOT NULL IDENTITY(1,1) ,
[Name] nvarchar(50) NOT NULL ,
[Age] smallint NOT NULL ,
[LightsaberColor] smallint NOT NULL ,
[Grade] smallint NOT NULL ,
[Status] bit NOT NULL DEFAULT ((1)) 
)


GO
DBCC CHECKIDENT(N'[dbo].[Jedi]', RESEED, 8)
GO

-- ----------------------------
-- Records of Jedi
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Jedi] ON
GO
INSERT INTO [dbo].[Jedi] ([Id], [Name], [Age], [LightsaberColor], [Grade], [Status]) VALUES (N'1', N'Luke Skywalker', N'35', N'1', N'1', N'1')
GO
GO
INSERT INTO [dbo].[Jedi] ([Id], [Name], [Age], [LightsaberColor], [Grade], [Status]) VALUES (N'2', N'Obi-Wan Kenobi', N'26', N'3', N'3', N'1')
GO
GO
INSERT INTO [dbo].[Jedi] ([Id], [Name], [Age], [LightsaberColor], [Grade], [Status]) VALUES (N'5', N'Dooku Ferrer', N'29', N'1', N'1', N'1')
GO
GO
INSERT INTO [dbo].[Jedi] ([Id], [Name], [Age], [LightsaberColor], [Grade], [Status]) VALUES (N'6', N'Yoda', N'35', N'1', N'2', N'1')
GO
GO
SET IDENTITY_INSERT [dbo].[Jedi] OFF
GO

-- ----------------------------
-- Table structure for OrdersHolograms
-- ----------------------------
CREATE TABLE [dbo].[OrdersHolograms] (
[Id] int NOT NULL IDENTITY(1,1) ,
[JediId] int NOT NULL ,
[HologramId] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[OrdersHolograms]', RESEED, 8)
GO

-- ----------------------------
-- Records of OrdersHolograms
-- ----------------------------
SET IDENTITY_INSERT [dbo].[OrdersHolograms] ON
GO
INSERT INTO [dbo].[OrdersHolograms] ([Id], [JediId], [HologramId]) VALUES (N'1', N'1', N'3')
GO
GO
INSERT INTO [dbo].[OrdersHolograms] ([Id], [JediId], [HologramId]) VALUES (N'2', N'1', N'5')
GO
GO
INSERT INTO [dbo].[OrdersHolograms] ([Id], [JediId], [HologramId]) VALUES (N'3', N'5', N'6')
GO
GO
INSERT INTO [dbo].[OrdersHolograms] ([Id], [JediId], [HologramId]) VALUES (N'4', N'2', N'6')
GO
GO
INSERT INTO [dbo].[OrdersHolograms] ([Id], [JediId], [HologramId]) VALUES (N'5', N'1', N'2')
GO
GO
INSERT INTO [dbo].[OrdersHolograms] ([Id], [JediId], [HologramId]) VALUES (N'8', N'1', N'6')
GO
GO
SET IDENTITY_INSERT [dbo].[OrdersHolograms] OFF
GO

-- ----------------------------
-- Indexes structure for table Hologram
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Hologram
-- ----------------------------
ALTER TABLE [dbo].[Hologram] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table Jedi
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Jedi
-- ----------------------------
ALTER TABLE [dbo].[Jedi] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Indexes structure for table OrdersHolograms
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table OrdersHolograms
-- ----------------------------
ALTER TABLE [dbo].[OrdersHolograms] ADD PRIMARY KEY ([Id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[OrdersHolograms]
-- ----------------------------
ALTER TABLE [dbo].[OrdersHolograms] ADD FOREIGN KEY ([HologramId]) REFERENCES [dbo].[Hologram] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[OrdersHolograms] ADD FOREIGN KEY ([JediId]) REFERENCES [dbo].[Jedi] ([Id]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO
