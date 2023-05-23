create table Bank
(
code int primary key NOT NULL ,
name varchar(20) NOT NULL ,
address varchar(250) NOT NULL
);

create table Branch
(
branch_number int primary key,
code int NOT NULL ,
address varchar(250) NOT NULL ,
foreign key (code) references Bank(code)
);

create table Employee
(emp_id int primary key NOT NULL ,
branch_number int ,
employee_name varchar(20) NOT NULL ,
salary INT NOT NULL ,
foreign key (branch_number) references Branch(branch_number)
);

create table Customer
(SSN int primary key NOT NULL ,
branch_number int ,
name varchar(20) NOT NULL ,
phone int NOT NULL ,
address varchar(250) NOT NULL ,
foreign key (branch_number) references Branch(branch_number)
);

create table Account
(account_number int identity(1,1) primary key NOT NULL  ,
SSN int NOT NULL ,
balance int default '0' ,
type varchar(20) NOT NULL ,
foreign key (SSN) references Customer(SSN)
);

create table Admin
(emp_id INT NOT NULL ,
name VARCHAR(20) NOT NULL ,
foreign key (emp_id) references Employee(emp_id)
);

create table Loan
(loan_number int primary key NOT NULL ,
emp_id int NOT NULL ,
loan_type varchar(20) NOT NULL ,
loan_amount int NOT NULL ,
foreign key (emp_id) references Employee(emp_id)
);

create table offer
(
branch_number int,
loan_number int not null,
PRIMARY KEY (branch_number,loan_number),
foreign key (branch_number) references Branch(branch_number),
foreign key (loan_number) references Loan(loan_number)
);

create table take_loan
(SSN int not null,
loan_number int not null,
PRIMARY KEY (SSN,loan_number),
foreign key (SSN) references Customer(SSN),
foreign key (loan_number) references Loan(loan_number)
);

create table handle_client
(SSN int not null,
emp_id int not null,
PRIMARY KEY (SSN, emp_id),
foreign key (SSN) references Customer(SSN),
foreign key (emp_id) references Employee(emp_id)
);

INSERT INTO Bank (code, name, address) VALUES (1, 'ABC Bank', '123 Main Street');
INSERT INTO Customer (SSN, branch_number, name, phone, address) VALUES (123456789, 1, 'John Doe', 1234567890, '456 Elm Street');

DELETE FROM Loan WHERE loan_number = 1001;
DELETE FROM Admin WHERE emp_id = 100;

UPDATE Account SET balance = 5000 WHERE account_number = 10001;
UPDATE Employee SET salary = 60000 WHERE emp_id = 200;

SELECT * FROM Customer;
SELECT Bank.name, Branch.branch_number, Branch.address FROM Bank INNER JOIN Branch ON Bank.code = Branch.code;
