-- Разработать систему автоматизации процесса учета товаров и поставщиков магазина одежды
-- содание базы данных, для нашего проекта 
create database dbShop
use dbShop
go

-- определение сущностей 
-- код, размер, состав, стиль (Зима, Осень, Лето, Весна, Димми), страна производитель, бренд, цена, фото
-- таблица "Одежда" 🐣
create table ClothesData (
	
	ID int identity primary key,
	[Title]			nvarchar(max)	not null,
	[Size]			int				not null,
	[Structure]		nvarchar(max)	not null,
	[Style]			nvarchar(max)	not null,
	[Country]		nvarchar(max)	not null,
	[Brend]			nvarchar(max)	not null,
	[Price]			float			not null,
	[Date]			date default getdate(),
	[Category]		nvarchar(100)	not null, -- связь с таблицей Category 😋
	[Gender]		nvarchar(25)	not null, -- связь с таблицей Gender 👩🏼‍💼🤵🏼
	[ProviderTitle]	nvarchar(100)	not null, -- связь с таблицей Provider 🔐🖇
	[Photo]			varbinary(max)	not null
)
go

-- таблица "Поставщики" 🚗
create table [Provider] (
	
	ID int identity ,
	[Title]		nvarchar(100)	not null primary key,
	[Country]	nvarchar(max)	not null,
	[City]		nvarchar(max)	not null,
	-- [Brend]		nvarchar(max)	not null,😎
	[Logo]		varbinary(max)	not null,
	[Email]		varchar(max)	not null
)
go

-- таблица "Пол" 👩🏼‍💼🤵🏼

create table Gender (
	
	[Gender] nvarchar(25) not null primary key
)
go	

insert [Gender] ([Gender]) values ('Мужчина')
insert [Gender] ([Gender]) values ('Женщина')
insert [Gender] ([Gender]) values ('Изготовлено на заказ')

-- таблица "Категория" 😌
create table Category (
	
	[Category]	nvarchar(100)	not null primary key
)
go

insert [Category]([Category]) values ('Для ребёнка')
insert [Category]([Category]) values ('Для взрослого')

-- связь между таблицей Поставщик и Одежда
alter table [ClothesData] with check add foreign key ([ProviderTitle]) references [Provider](Title)
-- связь между таблицей Пол и Одежда
alter table [ClothesData] with check add foreign key (Gender) references [Gender](Gender)
-- связь между таблицей Категория и Одежда
alter table [ClothesData] with check add foreign key ([Category]) references [Category]([Category])