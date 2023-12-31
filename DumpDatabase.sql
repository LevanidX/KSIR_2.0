USE [master]
GO
/****** Object:  Database [stroidtelstvo_i_remont]    Script Date: 22.06.2023 10:21:05 ******/
CREATE DATABASE [stroidtelstvo_i_remont]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'stroidtelstvo_i_remont', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\stroidtelstvo_i_remont.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'stroidtelstvo_i_remont_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\stroidtelstvo_i_remont_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [stroidtelstvo_i_remont].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET ARITHABORT OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET  ENABLE_BROKER 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET RECOVERY FULL 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET  MULTI_USER 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET DB_CHAINING OFF 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'stroidtelstvo_i_remont', N'ON'
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET QUERY_STORE = ON
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [stroidtelstvo_i_remont]
GO
/****** Object:  Table [dbo].[clients]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[client_ID] [int] IDENTITY(10000,1) NOT NULL,
	[client_name] [varchar](100) NOT NULL,
	[client_phone_number] [varchar](20) NOT NULL,
	[client_home_address] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[workers]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[workers](
	[worker_ID] [int] IDENTITY(1000,1) NOT NULL,
	[worker_name] [varchar](100) NOT NULL,
	[worker_phone_number] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[worker_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[companies]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[companies](
	[company_ID] [int] IDENTITY(500,1) NOT NULL,
	[company_name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[company_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jobs]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobs](
	[job_ID] [int] IDENTITY(100,1) NOT NULL,
	[job_name] [varchar](300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[job_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_ID] [int] IDENTITY(5000,1) NOT NULL,
	[order_client_ID] [int] NOT NULL,
	[order_company_ID] [int] NOT NULL,
	[order_job_name] [int] NOT NULL,
	[order_address] [varchar](200) NOT NULL,
	[order_price] [float] NOT NULL,
	[order_worker_ID] [int] NOT NULL,
	[order_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[orders_view]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[orders_view]
AS
SELECT order_ID, client_name, company_name, job_name,
	order_address, order_price, worker_name, order_date
FROM orders, clients, companies, workers, jobs
WHERE order_client_ID = client_ID AND
	order_company_ID = company_ID AND
	order_worker_ID = worker_ID AND
	order_job_name = job_id
GO
/****** Object:  Table [dbo].[completed_orders]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[completed_orders](
	[completed_order_ID] [int] NOT NULL,
	[completed_order_client_ID] [int] NOT NULL,
	[completed_order_company_ID] [int] NOT NULL,
	[completed_order_job_name] [int] NOT NULL,
	[completed_order_address] [varchar](200) NOT NULL,
	[completed_order_price] [float] NOT NULL,
	[completed_order_worker_ID] [int] NOT NULL,
	[completed_order_statement] [varchar](50) NULL,
	[completed_order_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[completed_order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[completed_orders_view]    Script Date: 22.06.2023 10:21:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[completed_orders_view]
AS
SELECT completed_order_ID, client_name, company_name, job_name,
	completed_order_address, completed_order_price, worker_name, 
	completed_order_statement, completed_order_date
FROM completed_orders, clients, companies, workers, jobs
WHERE completed_order_client_ID = client_ID AND
	completed_order_company_ID = company_ID AND
	completed_order_worker_ID = worker_ID AND
	completed_order_job_name = job_ID
GO
SET IDENTITY_INSERT [dbo].[clients] ON 

INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10000, N'Новикова Алёна Марковна', N'79905495582', N'Россия, г. Дмитров, Подъячева ул., д. 13 кв.16')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10001, N'Лебединская Александра Федоровна', N'79358591296', N'Россия, г. Дмитров, Советская ул., д. 19 кв.5')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10002, N'Краевский Константин Валерианович', N'79838415940', N'Россия, г. Дмитров, Маркова ул., д. 27 кв.35')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10003, N'Эскин Георгий Филиппович', N'79166897839', N'Россия, г. Дмитров, Ново-Рогачевская ул., д. 10')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10004, N'Беликов Роман Семенович', N'79108735322', N'Россия, г. Дмитров, Школьная ул., д. 7 кв.95')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10005, N'Артемьев Виталий Васильевич', N'79689503498', N'Россия, г. Яхрома, Ленина ул., д. 8А кв.42')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10006, N'Случевская Вероника Сергеевна', N'79867028676', N'Россия, г. Яхрома, Большевистская ул., д. 3 кв.103')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10007, N'Сиянковская Анна Игнатевна', N'79794136818', N'Россия, г. Яхрома, Бусалова ул., д. 15 кв.19')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10008, N'Енотов Семен Викторович', N'79679639726', N'Россия, г. Яхрома, Школьная ул., д. 6 кв.11')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10009, N'Гавриленкова Ирина Игнатьевна', N'79131085847', N'Россия, г. Яхрома, Большевистская ул., д. 22 кв.119')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10010, N'Филимонов Алексей Валерианович', N'79957305654', N'Россия, г. Яхрома, Ленина ул., д. 14 кв.130')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10011, N'Малыхина Галина Константиновна', N'79292258442', N'Россия, г. Яхрома, Ленина ул., д. 39 кв.91')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10012, N'Килина Виктория Никифоровна', N'79541971818', N'Россия, г. Яхрома, Ленина ул., д. 30А кв.53')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10013, N'Илюшкина Алена Герасимовна', N'79949929454', N'Россия, г. Дмитров, Московская ул., д. 5 кв.97')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10014, N'Абросимова Ника Никитьевна', N'79848875163', N'Россия, г. Дмитров, Маркова ул., д. 2А кв.186')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10015, N'Тихоненко Тимофей Ипполитович', N'79269718674', N'Россия, г. Дмитров, Оборонная ул., д. 12 кв.103')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10016, N'Грибанов Георгий Афанасьевич', N'79974705840', N'Россия, г. Дмитров, Аверьянова ул., д. 14 кв.112')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10017, N'Опринчук Давид Александрович', N'79855801431', N'Россия, г. Дмитров, Шлюзовая ул., д. 8к3 кв.52')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10018, N'Воронов Иван Валерианович', N'79327395196', N'Россия, г. Дмитров, Большевистская ул., д. 20 кв.83')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10019, N'Верясов Степан Егорович', N'79897356251', N'Россия, г. Дмитров, Космонавтов ул., д. 1А кв.87')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10020, N'Шестакова Карина Тимофеевна', N'79138749850', N'Россия, г. Дмитров, Комсомольская ул., д. 25 кв.145')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10021, N'Клименкова Алена Герасимовна', N'79199342256', N'Россия, г. Дмитров, Комсомольская ул., д. 16к4 кв.106')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10022, N'Кобзев Максим Ефимович', N'79731716762', N'Россия, г. Дмитров, Инженерная ул., д. 27 кв.43')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10023, N'Тихонов Михаил Евгениевич', N'79564891999', N'Россия, г. Дмитров, Космонавтов ул., д. 52 кв.185')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10024, N'Малинин Никита Павлович', N'79834877029', N'Россия, г. Дмитров, Сиреневая ул., д. 7 кв.162')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10025, N'Епископ Анатолий Павлович', N'79109832508', N'Москва, Кремль')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10026, N'Павлова Елена Анатольевна', N'79824919840', N'Москва, улица 1905 года, дом 34, кв. 33')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10027, N'Иванов Иван Иванович', N'79198205981', N'Дмитров, улица Советская, дом 47, кв. 45')
INSERT [dbo].[clients] ([client_ID], [client_name], [client_phone_number], [client_home_address]) VALUES (10028, N'Петрова Наталья Григорьевна', N'79857192410', N'Россия, г. Яхрома, Бусалова ул., д. 15 кв.19')
SET IDENTITY_INSERT [dbo].[clients] OFF
GO
SET IDENTITY_INSERT [dbo].[companies] ON 

INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (500, N'Мосэкострой')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (501, N'СК Битэкс')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (502, N'Рамгеострой')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (503, N'СП-Мастер')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (504, N'Диалог')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (505, N'СМУ-108')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (506, N'Энергия-плюс')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (507, N'ЧерБалтСтрой')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (508, N'Фирма Риксон')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (509, N'МИГ Недвижимость')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (510, N'МАВИС')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (511, N'КРОСТ')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (512, N'ИНТЕКО')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (513, N'Мортон')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (514, N'Гранель')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (515, N'Петрострой')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (516, N'ИПС')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (517, N'ИНГРАД')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (518, N'Импульс')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (519, N'ГлавМосСтрой')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (520, N'Баркли')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (521, N'КитежСтрой')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (522, N'Новикон')
INSERT [dbo].[companies] ([company_ID], [company_name]) VALUES (523, N'ИП Новое')
SET IDENTITY_INSERT [dbo].[companies] OFF
GO
INSERT [dbo].[completed_orders] ([completed_order_ID], [completed_order_client_ID], [completed_order_company_ID], [completed_order_job_name], [completed_order_address], [completed_order_price], [completed_order_worker_ID], [completed_order_statement], [completed_order_date]) VALUES (5001, 10000, 520, 101, N'Россия, г. Дмитров, Ново-Рогачевская ул., д. 10', 47500, 1024, N'Отменен', CAST(N'2023-06-22' AS Date))
INSERT [dbo].[completed_orders] ([completed_order_ID], [completed_order_client_ID], [completed_order_company_ID], [completed_order_job_name], [completed_order_address], [completed_order_price], [completed_order_worker_ID], [completed_order_statement], [completed_order_date]) VALUES (5004, 10020, 513, 118, N'Россия, г. Дмитров, Аверьянова ул., д. 14 кв.112', 135000, 1018, N'Выполнен', CAST(N'2023-06-22' AS Date))
GO
SET IDENTITY_INSERT [dbo].[jobs] ON 

INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (100, N'Косметический ремонт')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (101, N'Капитальный ремонт')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (102, N'Дизайнерский ремонт')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (103, N'Черновой ремонт')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (104, N'Ремонт окон')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (105, N'Ремонт в новостройке')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (106, N'Подготовка стен')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (107, N'Чистовая отделка квартир и домов')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (108, N'Поклейка обоев')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (109, N'Покраска стен')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (110, N'Шпаклевочные работы')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (111, N'Утепление кровли')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (112, N'Пристройки к дому')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (113, N'Строительство фундамента')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (114, N'Строительство террасы')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (115, N'Строительство бани')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (116, N'Строительство гаража')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (117, N'Бетонные работы')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (118, N'Отделка дома сайдингом')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (119, N'Строительство дома из бруса')
INSERT [dbo].[jobs] ([job_ID], [job_name]) VALUES (120, N'Устранение протечки кровли')
SET IDENTITY_INSERT [dbo].[jobs] OFF
GO
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([order_ID], [order_client_ID], [order_company_ID], [order_job_name], [order_address], [order_price], [order_worker_ID], [order_date]) VALUES (5000, 10004, 513, 104, N'Россия, г. Дмитров, Маркова ул., д. 27 кв.35', 13000, 1000, CAST(N'2023-06-21' AS Date))
SET IDENTITY_INSERT [dbo].[orders] OFF
GO
SET IDENTITY_INSERT [dbo].[workers] ON 

INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1000, N'Ярослав', N'79318635707')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1001, N'Кира', N'79171182079')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1002, N'Денис', N'79267527077')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1003, N'Виктория', N'79117751596')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1004, N'Полина', N'79715573653')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1005, N'Татьяна', N'79290890136')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1006, N'Алексей', N'79851449300')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1007, N'София', N'79911150782')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1008, N'Михаил', N'79220650058')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1009, N'Алина', N'79702083305')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1010, N'Иван', N'79178870716')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1011, N'Давид', N'79178870716')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1012, N'Альбина', N'79001915223')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1013, N'Максим', N'79222988573')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1014, N'Анна', N'79191519138')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1015, N'Кирилл', N'79547951327')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1016, N'Роман', N'79037468234')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1017, N'Федор', N'79361670669')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1018, N'Илья', N'79654177724')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1019, N'Олег', N'79678314947')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1020, N'Вероника', N'79812366905')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1021, N'Глеб', N'79278987872')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1022, N'Дарья', N'79536055129')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1023, N'Ульяна', N'79271036038')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1024, N'Владислав', N'79707652909')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1025, N'Степан', N'79665976991')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1026, N'Александр', N'79822524098')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1027, N'Дмитрий', N'79174723131')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1028, N'Сергей', N'79274655097')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1029, N'Матвей', N'79096537743')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1030, N'Георгий', N'79687843073')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1031, N'Евгений', N'79123095891')
INSERT [dbo].[workers] ([worker_ID], [worker_name], [worker_phone_number]) VALUES (1032, N'Рудольф', N'79929010541')
SET IDENTITY_INSERT [dbo].[workers] OFF
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD FOREIGN KEY([order_client_ID])
REFERENCES [dbo].[clients] ([client_ID])
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD FOREIGN KEY([order_company_ID])
REFERENCES [dbo].[companies] ([company_ID])
GO
USE [master]
GO
ALTER DATABASE [stroidtelstvo_i_remont] SET  READ_WRITE 
GO
