select * from Customer
select * from Orders
select * from Products
select * from Orderitem
select * from Employee

 

Create table Customer (
Id int Primary Key,
FirstName nvarchar(40) Not Null,
LastName nvarchar(40),
City nvarchar(40),
Country nvarchar(40),
Phone nvarchar(20)
);

 

create table Orders(
Id int Primary Key,
OrderDate datetime ,
OrderNumber nvarchar(10),
CustomerId int Foreign key references Customer(Id),
TotalAmount decimal(12,2)
);
create table Products (
Id int Primary Key ,
ProductName nvarchar(50),
UnitPrice decimal(12,2),
Pakage nvarchar(30),
IsDiscomtinued bit,
Category nvarchar(40)
);

 

create table Orderitem (
Id int Primary Key,
OrderId int Foreign Key references Orders(Id),
ProductId int Foreign Key references Products(Id),
UnitPrice decimal(12,2),
Quntity int 
);

 

create table Employee(
FirstName nvarchar(40),
LastName  nvarchar(40),
Department nvarchar(40),
Rating int ,
Salary int 
);

 

insert into Customer values (1,'Apurva', 'Gondkar', 'shirdi','India','5432175889');
insert into Customer values (2,'Gauri', 'Devhadrao', 'Rahata','India','5872175655');
insert into Customer values (3,'Amruta', 'Kulkarni', 'NewYork','America','5743268655');
insert into Customer values (4,'Rutuja', 'Thombre', 'Paris','France','7754775655');
insert into Customer values (5,'Nikita', 'Punde', 'Peru','Japan','9436175655');
insert into Customer values (6,'Devashree', 'More', 'Pune','India','0300074321');
insert into Customer values (7,'Shweta', 'Hase', 'London','UK','9328874321');


 

insert into Orders values (11,'12/3/2022' ,'543',1,764653);
insert into Orders values (2,'2020/10/05 12:32:59:20' ,'973',2,654653);
insert into Orders values (3,'2021/10/05 11:22:59:20' ,'943',3,987653);
insert into Orders values (4,'2021/11/06 02:52:42:40' ,'945',4,632453);
insert into Orders values (5,'2022/03/04 11:22:59:20' ,'983',5,943653);
insert into Orders values (6,'6/2/2921','124',6,127355);

 

delete from Orders where Id = 11;

 

insert into Products values ( 1,'Chai',654,'RedLabel',1,NULL);
insert into Products values ( 2,'Coffe',350,'Davidoff',15,NULL);
insert into Products values ( 3,'soda',500,'Pitcher',1,NULL);
insert into Products values (4,'Chai',764,'taj',0,'Breakfast');
insert into Products values (5,'Fish',782,'Shark',0,'Seafood');

 

update Products set IsDiscomtinued = 0 where Id = 2;


 

insert into Orderitem values (234,3,1,534,54 );
insert into Orderitem values (764,5,2,874,59 );
insert into Orderitem values (836,4,3,498,87 );
insert into Orderitem values (902,6,4,321,90 );

 

insert into Employee values ('Apurva','Gondkar','Civil',5,30000);
insert into Employee values ('Gauri','Devhadrao','Civil',4,20000);
insert into Employee values ('Rutuja','Thombre','Electrical',3,30000);
insert into Employee values ('Nikita','Punde','ENTC',4,40000);
insert into Employee values ('Amruta','Kulkarni','Computer',2,10000);

 

Alter table Products add Category nvarchar(40);

 

select * from Orders where CustomerId = (select Id from Customer where Phone ='0300074321');

 

select *from  Products where Category = 'Seafood'

 

select * from Orders inner join Customer on Orders.CustomerId=Customer.Id where City != 'London';

 

select * from Orderitem where ProductId like (select Id from Products where ProductName = 'Chai');

 

select FirstName,LastName,Department,Rating from Employee  