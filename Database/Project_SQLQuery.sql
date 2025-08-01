
use ScholarsNest;


CREATE TABLE Student(
    name VARCHAR(100),
    fatherName VARCHAR(100),
    email VARCHAR(100) Primary key,
    phone VARCHAR(20),
    institution VARCHAR(100),
    DOB VARCHAR(20),
    gender VARCHAR(10),
    address VARCHAR(255),
    password VARCHAR(100)
);


CREATE TABLE Admin (
    adminId VARCHAR(10) PRIMARY KEY,
    name VARCHAR(100),
    salary DECIMAL(10, 2),
    password VARCHAR(100),
);
-- FOREIGN KEY (adminId) REFERENCES Admin(adminId)
        --ON DELETE CASCADE
       -- ON UPDATE CASCADE
       -- adminId VARCHAR(10),

CREATE TABLE Employee (
    employeeId VARCHAR(10) PRIMARY KEY,
   
    name VARCHAR(100),
    salary VARCHAR(10),
    password VARCHAR(100),
    role VARCHAR(50),   
);

CREATE TABLE Meal (
    mealId VARCHAR(10) PRIMARY KEY,
    day VARCHAR(20),  
    breakfast VARCHAR(100),
    breakfast_price VARCHAR(10),
    lunch VARCHAR(100),
    lunch_price VARCHAR(10),
    dinner VARCHAR(100),
    dinner_price VARCHAR(10)
);



CREATE TABLE Complaint (
    complainId INT IDENTITY(200,1) PRIMARY KEY,
    studentemail VARCHAR(100),
    subject VARCHAR(255),
    description VARCHAR(500),
    FOREIGN KEY (studentemail) REFERENCES Student(email)
);

CREATE TABLE AcceptedStudent (
    serial INT IDENTITY(1,1) PRIMARY KEY,
    id AS ('23-' + RIGHT('0000' + CAST(serial AS VARCHAR(4)), 4)) PERSISTED,
    name VARCHAR(100),
    fatherName VARCHAR(100),
    email VARCHAR(100),
    phone VARCHAR(20),
    institution VARCHAR(100),
    DOB VARCHAR(20),
    gender VARCHAR(10),
    address VARCHAR(255),
    password VARCHAR(100)
);


CREATE TABLE RequestedStudent (
    -- id INT IDENTITY(3413,1) PRIMARY KEY,
    name VARCHAR(100),
    fatherName VARCHAR(100),
    email VARCHAR(100) UNIQUE,
    phone VARCHAR(20),
    institution VARCHAR(100),
    DOB VARCHAR(20),
    gender VARCHAR(10),
    address VARCHAR(255),
    password VARCHAR(100)
);



CREATE TABLE StudentMeal (
    studentEmail VARCHAR(100),
    mealDate VARCHAR(50),
    bprice VARCHAR(10),
    lprice VARCHAR(10),
    nprice VARCHAR(10),
    total VARCHAR(10),
    CONSTRAINT FK_StudentEmail FOREIGN KEY (studentEmail)
        REFERENCES Student(email)
);


CREATE TABLE Payment (
    serial INT IDENTITY(1,1) PRIMARY KEY,
    paymentId AS ('AX-' + RIGHT('00' + CAST(serial AS VARCHAR(2)), 2)) PERSISTED,
    studentEmail VARCHAR(100),
    paymentDate VARCHAR(30),
    amount VARCHAR(30),
    phone VARCHAR(30),
    paymentMethod VARCHAR(50),
    CONSTRAINT FK_Payment_StudentEmail FOREIGN KEY (studentEmail)
        REFERENCES Student(email)
);


INSERT INTO Meal (mealId, day, breakfast, breakfast_price, lunch, lunch_price, dinner, dinner_price)
VALUES
('M-1', 'Monday', 'Paratha & Egg', '25.00', 'Rice & Chicken Curry', '60.00', 'Roti & Daal', '30.00'),
('M-2', 'Tuesday', 'Bread & Jam', '20.00', 'Rice & Fish Curry', '55.00', 'Khichuri & Egg', '35.00'),
('M-3', 'Wednesday', 'Suji & Banana', '18.00', 'Polao & Chicken Roast', '70.00', 'Roti & Mixed Veg', '28.00'),
('M-4', 'Thursday', 'Chotpoti', '22.00', 'Plain Rice & Egg Curry', '50.00', 'Noodles & Sausage', '40.00'),
('M-5', 'Friday', 'Halwa & Puri', '30.00', 'Beef Tehari', '80.00', 'Roti & Lentils', '25.00'),
('M-6', 'Saturday', 'Panta & Fried Hilsha', '35.00', 'Vegetable Biryani', '65.00', 'Roti & Egg Curry', '30.00'),
('M-7', 'Sunday', 'Milk Bread & Banana', '20.00', 'Chicken Biryani', '75.00', 'Khichuri & Chicken', '40.00');



-- ===============All_Table====================
select * from Student;
select * from Admin;
select * from Employee;
select * from Meal;
select * from Complaint;
select * from AcceptedStudent;
select * from RequestedStudent;
select * from StudentMeal;
select * from Payment;



--drop table Employee;
--drop table Admin;
--drop table Student;
--drop table Meal;
--drop table complaints;
--drop table AcceptedStudent; 
--drop table StudentMeal;
--drop table Payment;


SELECT name, email,password FROM Student WHERE institution = 'aiub';
SELECT * FROM Student WHERE institution = 'aiub';

-- DELETE FROM Student
WHERE email = 'clara.lee@example.com';

SELECT breakfast,breakfast_price FROM Meal WHERE day = 'Monday';

SELECT id,password FROM AcceptedStudent where 'taimoor.aslam@example.com'=email;

delete from AcceptedStudent where name='test';

SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'StudentMeal' AND COLUMN_NAME = 'mealDate';