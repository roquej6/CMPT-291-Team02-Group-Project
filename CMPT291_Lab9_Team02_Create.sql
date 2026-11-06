/* ===========================================================================
   CMPT 291 Lab 9 - SQL Create                          Team <02>
   Members: Mitchell Stolte, Sylvester Voon, Jake Hanson, John Roque

   File: CMPT291_Lab9_Team02_Create.sql
   Goal: Drop the tables at the beggining of file so that the code can be rerun, then create
   empty tables for the database.

=============================================================================== */

IF DB_ID(N'MovieRental_Team02') IS NULL -- change 00 to your team number
    CREATE DATABASE MovieRental_Team02;

GO
USE MovieRental_Team02;

-- Drop all of the tables, children before the parents

GO
DROP TABLE IF EXISTS dbo.renting;

DROP TABLE IF EXISTS dbo.maintains_actor;

DROP TABLE IF EXISTS dbo.maintains_movie;

DROP TABLE IF EXISTS dbo.movie_ratings;

DROP TABLE IF EXISTS dbo.movie_genres;

DROP TABLE IF EXISTS dbo.actor_movie_rating;

DROP TABLE IF EXISTS dbo.acted_in;

DROP TABLE IF EXISTS dbo.manage;

DROP TABLE IF EXISTS dbo.actor;

DROP TABLE IF EXISTS dbo.rental;

DROP TABLE IF EXISTS dbo.movie;

DROP TABLE IF EXISTS dbo.customer;

DROP TABLE IF EXISTS dbo.employee;

GO


-- Start creating the tables, parents before the child
CREATE TABLE dbo.employee (
    employee_id VARCHAR (5) NOT NULL CONSTRAINT PK_employee PRIMARY KEY,
    name VARCHAR (50) NOT NULL,
    email VARCHAR (50) NOT NULL,
    age INT NOT NULL,
    salary DECIMAL (9, 2) NULL
);

CREATE TABLE dbo.customer (
    customer_id VARCHAR (5) NOT NULL CONSTRAINT PK_customer PRIMARY KEY,
    name VARCHAR (50) NOT NULL,
    email VARCHAR (50) NOT NULL,
    age INT NOT NULL,
    account_active BIT NOT NULL
);

CREATE TABLE dbo.movie (
    movie_id VARCHAR (5) NOT NULL CONSTRAINT PK_movie PRIMARY KEY,
    title VARCHAR (50) NOT NULL,
    available BIT NOT NULL
);

CREATE TABLE dbo.rental (
    rental_id VARCHAR (10) NOT NULL CONSTRAINT PK_rental PRIMARY KEY,
    date_added DATETIME NOT NULL,
    expired BIT NOT NULL,
    movie_id VARCHAR (5) NOT NULL CONSTRAINT FK_rental_movie FOREIGN KEY REFERENCES dbo.movie (movie_id),
    URL VARCHAR(50) NOT NULL CONSTRAINT UQ_URL UNIQUE
);

CREATE TABLE dbo.actor (
    actor_id VARCHAR (5) NOT NULL CONSTRAINT PK_actor PRIMARY KEY,
    name VARCHAR (30) NOT NULL
);

CREATE TABLE dbo.manage (
    employee_id VARCHAR (5) NOT NULL CONSTRAINT FK_manage_employee FOREIGN KEY REFERENCES dbo.employee (employee_id),
    customer_id VARCHAR (5) NOT NULL CONSTRAINT FK_manage_customer FOREIGN KEY REFERENCES dbo.customer (customer_id),
    CONSTRAINT PK_manage PRIMARY KEY (employee_id, customer_id)
);

CREATE TABLE dbo.acted_in (
    actor_id VARCHAR (5) NOT NULL CONSTRAINT FK_actedin_actor FOREIGN KEY REFERENCES dbo.actor (actor_id),
    movie_id VARCHAR (5) NOT NULL CONSTRAINT FK_actedin_movie FOREIGN KEY REFERENCES dbo.movie (movie_id),
    CONSTRAINT PK_actedin PRIMARY KEY (actor_id, movie_id)
);

CREATE TABLE dbo.actor_movie_rating (
    actor_id VARCHAR (5) NOT NULL CONSTRAINT FK_actormovierating_actor FOREIGN KEY REFERENCES dbo.actor (actor_id),
    movie_id VARCHAR (5) NOT NULL CONSTRAINT FK_actormovierating_movie FOREIGN KEY REFERENCES dbo.movie (movie_id),
    rating INT NOT NULL CONSTRAINT PK_actormovierating PRIMARY KEY (actor_id, movie_id)
);

CREATE TABLE dbo.movie_genres (
    movie_id VARCHAR (5) CONSTRAINT FK_moviegenres_movie FOREIGN KEY REFERENCES dbo.movie (movie_id),
    genre VARCHAR (15) CONSTRAINT PK_moviegenres PRIMARY KEY (movie_id, genre)
);

CREATE TABLE dbo.movie_ratings (
    customer_id VARCHAR (5) NOT NULL CONSTRAINT FK_movieratings_customer FOREIGN KEY REFERENCES dbo.customer (customer_id),
    movie_id VARCHAR (5) NOT NULL CONSTRAINT FK_movieratings_movie FOREIGN KEY REFERENCES dbo.movie (movie_id),
    rating INT NOT NULL CONSTRAINT PK_movieratings PRIMARY KEY (customer_id, movie_id)
);

CREATE TABLE dbo.maintains_actor (
    employee_id VARCHAR (5) NOT NULL CONSTRAINT FK_maintainsactor_employee FOREIGN KEY REFERENCES dbo.employee (employee_id),
    actor_id VARCHAR (5) NOT NULL CONSTRAINT FK_maintainsactor_actor FOREIGN KEY REFERENCES dbo.actor (actor_id),
    CONSTRAINT PK_maintainsactor PRIMARY KEY (employee_id, actor_id)
);

CREATE TABLE dbo.maintains_movie (
    employee_id VARCHAR (5) NOT NULL CONSTRAINT FK_maintainsmovie_employee FOREIGN KEY REFERENCES dbo.employee (employee_id),
    movie_id VARCHAR (5) NOT NULL CONSTRAINT FK_maintainsmovie_movie FOREIGN KEY REFERENCES dbo.movie(movie_id),
    CONSTRAINT PK_maintainsmovie PRIMARY KEY (employee_id, movie_id)
);

CREATE TABLE dbo.renting (
    customer_id VARCHAR (5) NOT NULL CONSTRAINT FK_renting_customer FOREIGN KEY REFERENCES dbo.customer (customer_id),
    rental_id VARCHAR (10) NOT NULL CONSTRAINT FK_renting_rental FOREIGN KEY REFERENCES dbo.rental (rental_id),
    CONSTRAINT PK_renting PRIMARY KEY (customer_id, rental_id)
);
GO