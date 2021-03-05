CREATE DATABASE book_store;
USE book_store;

CREATE TABLE author
(
id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
firs_name VARCHAR(50),
last_name VARCHAR(50)
);

CREATE TABLE book
(
id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
title VARCHAR(80),
autor_id INT NOT NULL,
genre VARCHAR(50),
year INT,
price DECIMAL(15,2),
FOREIGN KEY (autor_id) REFERENCES author(id)
);

CREATE TABLE seller 
(
id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR (50) NOT NULL
);

CREATE TABLE customer
(
id INT PRIMARY KEY NOT NULL AUTO_INCREMENT
);

CREATE TABLE sales
(
customer_id INT NOT NULL,
book_id INT NOT NULL,
seller_id INT NOT NULL,
FOREIGN KEY (customer_id) REFERENCES customer(id),
FOREIGN KEY (book_id) REFERENCES book(id),
FOREIGN KEY (seller_id) REFERENCES seller(id),
PRIMARY KEY (customer_id, book_id, seller_id)
);

