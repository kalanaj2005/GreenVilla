# Green Villa Hotel Management System

 * This is a Hotel Management System Made for a fictional hotel called 'Green Villa'.
   
 * This app can be used to manage rooms, guest details and reservations.

## Screenshots
 ### Login
   ![Login Screen](Screenshots/Login.jpg)
 ### Dashboard
   ![Dashboard](Screenshots/Dashboard.jpg)
 ### Menu
   ![Menu](Screenshots/Menu.jpg)
   
## SETUP

* Open the GreenVilla.sln file from Microsoft Visual Studio and Run the program.
* You must add the correct servername, username, password, tablename in the 'Connection.cs' file.
* Also you must create the tables with necessary columns.
* The database needed for the app can be created by the following SQL commands.
  ```
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
           (002,'S.H.J.I. Silva',"9767875234V","silva","1234");
    
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
  ```


