SET IDENTITY_INSERT [dbo].[Client] ON
INSERT INTO [dbo].[Client] ([Id], [Name], [MobilePhoneNumber]) VALUES (1, N'Jim Harris ', N'0219994567')
INSERT INTO [dbo].[Client] ([Id], [Name], [MobilePhoneNumber]) VALUES (2, N'Thomas Wilson', N'0224567889')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[HairDresser] ON
INSERT INTO [dbo].[HairDresser] ([Id], [Name], [IsPermanent]) VALUES (1, N'Silvia Kelly ', 1)
INSERT INTO [dbo].[HairDresser] ([Id], [Name], [IsPermanent]) VALUES (2, N'Liam  Thompson', 0)
SET IDENTITY_INSERT [dbo].[HairDresser] OFF
SET IDENTITY_INSERT [dbo].[HairDressingOption] ON
INSERT INTO [dbo].[HairDressingOption] ([Id], [OptionName], [Charge]) VALUES (1, N'Hair  cut ', CAST(40.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[HairDressingOption] ([Id], [OptionName], [Charge]) VALUES (2, N'Hair Care ', CAST(55.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[HairDressingOption] ([Id], [OptionName], [Charge]) VALUES (3, N'Hair Coloring ', CAST(40.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[HairDressingOption] OFF
SET IDENTITY_INSERT [dbo].[Appointment] ON
INSERT INTO [dbo].[Appointment] ([Id], [ClientId], [HairDresserId], [HairDressingOptionId]) VALUES (1, 1, 2, 1)
INSERT INTO [dbo].[Appointment] ([Id], [ClientId], [HairDresserId], [HairDressingOptionId]) VALUES (2, 2, 2, 3)
SET IDENTITY_INSERT [dbo].[Appointment] OFF
