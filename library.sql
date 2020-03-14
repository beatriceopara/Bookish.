CREATE database library;

USE library;

CREATE TABLE books (
bookID int auto_increment NOT NULL,
title varchar(255) NOT NULL,
authorFirstName varchar(255) NOT NULL,
authorLastName varchar(255) NOT NULL,
publishedYear int,
PRIMARY KEY(bookID)
);

SELECT * FROM books;