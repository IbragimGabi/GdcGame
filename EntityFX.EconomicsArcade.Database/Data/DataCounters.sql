USE [GdcGame]
GO
INSERT [dbo].[Counter] ([Id], [Name], [InitialValue], [UseInAutostep], [InflationIncreaseSteps], [MiningTimeSeconds], [DelayedValue], [Type]) VALUES (0, N'Communism', CAST(0 AS Decimal(18, 0)), 0, 1000, NULL, NULL, 0)
INSERT [dbo].[Counter] ([Id], [Name], [InitialValue], [UseInAutostep], [InflationIncreaseSteps], [MiningTimeSeconds], [DelayedValue], [Type]) VALUES (1, N'Production', CAST(10 AS Decimal(18, 0)), 0, 1000, NULL, CAST(10 AS Decimal(18, 0)), 1)
INSERT [dbo].[Counter] ([Id], [Name], [InitialValue], [UseInAutostep], [InflationIncreaseSteps], [MiningTimeSeconds], [DelayedValue], [Type]) VALUES (2, N'Tax', CAST(0 AS Decimal(18, 0)), 1, 2000, NULL, NULL, 2)
INSERT [dbo].[Counter] ([Id], [Name], [InitialValue], [UseInAutostep], [InflationIncreaseSteps], [MiningTimeSeconds], [DelayedValue], [Type]) VALUES (3, N'Five Year Plan', CAST(0 AS Decimal(18, 0)), 0, 1000, NULL, NULL, 3)
