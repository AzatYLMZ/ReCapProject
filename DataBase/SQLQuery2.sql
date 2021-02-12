create table Users(
		Id int primary key identity(1,1),
		FirstName nvarchar(50),
		LastName nvarchar(50),
		Email nvarchar(75),
		Password nvarchar(50)
)

create table Customers(
		Id int primary key identity(1,1),
		UserId int,
		CompanyName nvarchar(50),
		foreign key (UserId) references Users(Id)
)

create table Rentals(
		Id int primary key identity (1,1),
		CarId int,
		CustomerId int,
		RentDate datetime,
		ReturnDate datetime,
		foreign key (CarId) references Cars(Id),
		foreign key (CustomerId) references Customers(Id)
)