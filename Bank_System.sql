CREATE TABLE Bank (
  bank_id INT PRIMARY KEY,
  name VARCHAR(255),
  code VARCHAR(10),
  address VARCHAR(255)
);

CREATE TABLE Bank_Branch (
  branch_id INT PRIMARY KEY,
  bank_id INT,
  address VARCHAR(255),
  branch_number VARCHAR(10),
  FOREIGN KEY (bank_id) REFERENCES Bank(bank_id)
);

CREATE TABLE Customer (
  ssn INT PRIMARY KEY,
  name VARCHAR(255),
  phone VARCHAR(15),
  address VARCHAR(255)
);

CREATE TABLE Account (
  account_number INT PRIMARY KEY,
  customer_ssn INT,
  balance DECIMAL(12, 2),
  type VARCHAR(20),
  FOREIGN KEY (customer_ssn) REFERENCES Customer(ssn)
);

CREATE TABLE Loan (
  loan_number INT PRIMARY KEY,
  loan_type VARCHAR(50),
  loan_amount DECIMAL(12, 2),
  branch_id INT,
  FOREIGN KEY (branch_id) REFERENCES Bank_Branch(branch_id)
);

CREATE TABLE Employee (
  employee_id INT PRIMARY KEY,
  name VARCHAR(255),
  phone VARCHAR(15),
  address VARCHAR(255)
);

CREATE TABLE Loan_Operation (
  operation_id INT PRIMARY KEY,
  loan_number INT,
  employee_id INT,
  operation_type VARCHAR(20),
  operation_date DATE,
  FOREIGN KEY (loan_number) REFERENCES Loan(loan_number),
  FOREIGN KEY (employee_id) REFERENCES Employee(employee_id)
);
