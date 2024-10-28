========================================
     MySQL commands
========================================

CREATE DATABASE greenvilla;
USE greenvilla;
CREATE TABLE employee (
    E_ID         INT PRIMARY KEY,
    name       VARCHAR(20),
    NIC        VARCHAR(12),
    username   VARCHAR(20),
    passwd     VARCHAR(20)
);

INSERT INTO employee (E_ID,Name,NIC,Username,Passwd) 
VALUES (001,'S.G.T. Perera',"200403300567","perera","1234"),
       (002,'W.K.I. Jayawardena',"9767875234V","kalana","1234");

CREATE TABLE guest (
    G_ID      INT PRIMARY kEY AUTO_INCREMENT,
    name      VARCHAR(50),
    NIC       VARCHAR(12),
    email     VARCHAR(30),
    tp        VARCHAR(15)
);

CREATE TABLE room (
    roomNum   VARCHAR(5) PRIMARY kEY,
    type      VARCHAR(50),
    price     INT
);

CREATE TABLE reservation (
    reservationID INT PRIMARY KEY AUTO_INCREMENT,
    GID           INT,
    startDate     DATE,
    endDate       DATE,
    numberOfDays  INT,
    roomNum       VARCHAR(5),
    cost          INT   
);