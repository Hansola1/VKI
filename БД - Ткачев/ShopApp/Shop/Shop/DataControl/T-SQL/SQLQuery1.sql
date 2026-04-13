USE shop

CREATE TABLE [dbo].[customers](
	[customer_id] [int] PRIMARY KEY NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[pasword] [nvarchar](20) NULL)

CREATE TABLE [dbo].[products](
	[product_id] [int] PRIMARY KEY NOT NULL,
	[product_name] [nvarchar](250) NOT NULL,
	[price] [float] NOT NULL,
) 

CREATE TABLE [dbo].[orders](
	[order_id] [int] PRIMARY KEY NOT NULL,
	[fcustomer_id] [int] NOT NULL,
	[fproduct_id] [int] NOT NULL,
	[order_date] [datetime] NULL,
FOREIGN KEY([fcustomer_id]) REFERENCES [dbo].[customers] ([customer_id]),
FOREIGN KEY([fproduct_id]) REFERENCES [dbo].[products] ([product_id]) 
) 

INSERT [dbo].[customers] ([customer_id], [first_name], [last_name], [email], [pasword]) VALUES (1, N'Петр', N'Иванов', N'Login1@gmail.com', N'qwerty')
INSERT [dbo].[customers] ([customer_id], [first_name], [last_name], [email], [pasword]) VALUES (2, N'Василий', N'Петров', N'Login2@gmail.com', N'abc123')
INSERT [dbo].[customers] ([customer_id], [first_name], [last_name], [email], [pasword]) VALUES (3, N'Иван', N'Сидоров', N'Login3@gmail.com', N'abc321')
INSERT [dbo].[customers] ([customer_id], [first_name], [last_name], [email], [pasword]) VALUES (4, N'Матвей', N'Симанов', N'Login4@gmail.com', N'football')
INSERT [dbo].[customers] ([customer_id], [first_name], [last_name], [email], [pasword]) VALUES (5, N'Антон', N'Круглов', N'Login5@gmail.com', N'123456')

INSERT [dbo].[products] ([product_id], [product_name], [price]) VALUES (1, N'Notebook i7', 53999)
INSERT [dbo].[products] ([product_id], [product_name], [price]) VALUES (2, N'iphon 16 MAX', 98999)
INSERT [dbo].[products] ([product_id], [product_name], [price]) VALUES (3, N'Xiaomi 14', 48999)
INSERT [dbo].[products] ([product_id], [product_name], [price]) VALUES (4, N'Huawei 200p', 39999)
INSERT [dbo].[products] ([product_id], [product_name], [price]) VALUES (5, N'Philips 55AJL', 19999)

INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (1, 1, 1, N'12.05.2025')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (2, 2, 2, N'14.02.2025')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (3, 3, 3, N'19.07.2024')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (4, 4, 4, N'31.12.2024')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (5, 5, 5, N'09.11.2024')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (6, 5, 3, N'06.02.2025')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (7, 4, 2, N'28.09.2024')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (8, 3, 1, N'15.06.2023')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (9, 2, 5, N'18.05.2024')
INSERT [dbo].[orders] ([order_id], [fcustomer_id], [fproduct_id], [order_date]) VALUES (10, 1, 4, N'20.04.2025')