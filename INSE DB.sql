CREATE DATABASE Dashboard;
USE Dashboard;

CREATE TABLE IF NOT EXISTS STUDENT (
stu_ID INT PRIMARY KEY AUTO_INCREMENT,
stu_username VARCHAR(30) NOT NULL UNIQUE,
stu_password VARCHAR(32) NOT NULL,
stu_upemail VARCHAR(45) NOT NULL UNIQUE
);


CREATE TABLE IF NOT EXISTS TEACHINGBLOCK (
tb_ID INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
tb_name VARCHAR(55) NOT NULL,
tb_startTime DATETIME NOT NULL, 
tb_endTime DATETIME NOT NULL,
tb_room VARCHAR(10)
);


CREATE TABLE IF NOT EXISTS REMINDER (
rem_ID INT PRIMARY KEY AUTO_INCREMENT,
rem_time DATETIME NOT NULL,
rem_description VARCHAR(200) NOT NULL
);
--Dummy record for database
INSERT INTO STUDENT (stu_username, stu_password, stu_upemail) VALUES 
('student1', MD5('secretpassword'),'up771451@myport.ac.uk');

-- Test query
--SELECT * FROM STUDENT WHERE stu_username='student1' AND stu_password=MD5('secretpassword');
