/* ===========================================================================
   CMPT 291 Lab 8 - SQL slice                          Team <02>
   Members: Mitchell Stolte, Sylvester Voon, Jake Hanson, John Roque

   File: CMPT291_Lab8_Team02_Slice.sql
   Goal: implement a small, connected part of YOUR E-R diagram as tables.
   Submit the SQL file with your Relational Design Package (PDF).

   Required: core customer, movie and rental/streaming-link tables and any
   tables they reference; a few valid rows; one SELECT with JOIN; one rejected
   FOREIGN KEY insert; rerunnable in SQL Server Management Studio (SSMS).

   Replace the example database number and all <placeholders>. Keep A-E.
   Section 4.1 of your template and your CREATE TABLE statements must agree.
   More complex business rules (for example the five-unexpired-link limit)
   are described in Section 5 of the PDF but need not be implemented here.
   =========================================================================== */
IF DB_ID(N'MovieRental_Team02') IS NULL -- change 00 to your team number
    CREATE DATABASE MovieRental_Team02;


GO
USE MovieRental_Team02;


GO
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

DROP TABLE IF EXISTS dbo.maintains_actor;

DROP TABLE IF EXISTS dbo.maintains_movie;


GO
/* A. DROP: list your actual tables in child-to-parent order.
   These commented placeholders are not runnable statements.             */
-- DROP TABLE IF EXISTS <rental_or_other_child_table>;
-- DROP TABLE IF EXISTS <parent_table>;
--constraint rental expiry to lways true if time is 24 hours past rental start
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
    age INT NOT NULL
);

CREATE TABLE dbo.movie (
    movie_id VARCHAR (5) NOT NULL CONSTRAINT PK_movie PRIMARY KEY,
    title VARCHAR (50) NOT NULL
);

CREATE TABLE dbo.rental (
    rental_id VARCHAR (10) NOT NULL CONSTRAINT PK_rental PRIMARY KEY,
    date_added TIME NOT NULL,
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
GO
/* B. CREATE: list parents before children.
   Name your constraints and comment the BR they support.

   Example structure (ADAPT to your own E-R diagram; don't copy literally):
   CREATE TABLE <parent_table> (
       <parent_id> INT NOT NULL,
       ...,
       CONSTRAINT PK_<parent_table> PRIMARY KEY (<parent_id>)
   );
   CREATE TABLE <child_table> (
       <child_id> INT NOT NULL,
       <parent_id> INT NOT NULL,
       ...,
       CONSTRAINT PK_<child_table> PRIMARY KEY (<child_id>),
       CONSTRAINT FK_<child_table>_<parent_table>
           FOREIGN KEY (<parent_id>) REFERENCES <parent_table>(<parent_id>)
   );
*/
-- Insert mock employees
INSERT  INTO dbo.employee (employee_id, name, email, age, salary)
VALUES                   
('E0001', 'Sharon Daniels', 'daniels@gmail.com', 24, 55000.00),
('E0002', 'Sarah Williams', 'williams@gmail.com', 32, 65000.00);

-- Insert mock customers
INSERT  INTO dbo.customer (customer_id, name, email, age)
VALUES                   
('C0001', 'Mike Brown', 'mike@email.com', 22),
('C0002', 'Emily Davis', 'emily@email.com', 25),
('C0003', 'Alex Wilson', 'alex@email.com', 30);

-- Insert mock movies
INSERT  INTO dbo.movie (movie_id, title)
VALUES                
('M0001', 'Inception'),
('M0002', 'The Matrix'),
('M0003', 'Interstellar');

-- Insert mock actors
INSERT  INTO dbo.actor (actor_id, name)
VALUES                
('A0001', 'Leonardo DiCaprio'),
('A0002', 'Keanu Reeves'),
('A0003', 'Matthew McConaughey');

-- Insert mock rentals
INSERT  INTO dbo.rental (rental_id, date_added, expired, movie_id, URL)
VALUES                 
('R0001', '10:30:00', 0, 'M0001', 'URL0001'),
('R0002', '12:45:00', 0, 'M0002', 'URL0002'),
('R0003', '14:00:00', 1, 'M0003', 'URL0003');

-- Start insering relations
-- employee / customer relationship
INSERT  INTO dbo.manage (employee_id, customer_id)
VALUES                 
('E0001', 'C0001'),
('E0001', 'C0002'),
('E0002', 'C0003');

-- actor / movie relationship
INSERT  INTO dbo.acted_in (actor_id, movie_id)
VALUES                   
('A0001', 'M0001'),
('A0002', 'M0002'),
('A0003', 'M0003');

-- actor / movie ratings
INSERT  INTO dbo.actor_movie_rating (actor_id, movie_id, rating)
VALUES                             
('A0001', 'M0001', 9),
('A0002', 'M0002', 10),
('A0003', 'M0003', 8);

-- movie generes
INSERT  INTO dbo.movie_genres (movie_id, genre)
VALUES                       
('M0001', 'Sci-Fi'),
('M0002', 'Action'),
('M0003', 'Sci-Fi');

-- customer movie ratings
INSERT  INTO dbo.movie_ratings (customer_id, movie_id, rating)
VALUES                       
('C0001', 'M0001', 9),
('C0002', 'M0002', 8),
('C0003', 'M0003', 10);

-- employee maintaining actors
INSERT  INTO dbo.maintains_actor (employee_id, actor_id)
VALUES                 
('E0001', 'A0001'),
('E0001', 'A0002'),
('E0002', 'A0003');

-- employee maintaining movies
INSERT  INTO dbo.maintains_movie (employee_id, movie_id)
VALUES                 
('E0001', 'M0001'),
('E0001', 'M0002'),
('E0002', 'M0003');
GO
/* C. VALID ROWS: a few INSERTs for your connected tables.
   Insert parent rows before child rows. Keep the FK values consistent.
   You do not need the full sample data planned in Section 8 of the PDF.  */
-- INSERT INTO <parent_table> (<columns>) VALUES (...), (...);
-- INSERT INTO <child_table>  (<columns>) VALUES (...), (...);

-- Join customer, movie rating, and movie. Resulting in a table with customer_id,
-- customer_name, movie_title, and the rating the customer gave.

SELECT c.customer_id,
       c.name AS customer_name,
       m.title AS movie_title,
       mr.rating
FROM   dbo.movie_ratings AS mr
       INNER JOIN
       dbo.customer AS c
       ON mr.customer_id = c.customer_id
       INNER JOIN
       dbo.movie AS m
       ON mr.movie_id = m.movie_id;


GO
/* D. JOIN: show how your tables use the relationships in your E-R diagram.
   Return meaningful columns from at least two related tables.
   Record what the query shows in template Section 9.2.                 */
-- SELECT ...
-- FROM <child_table> AS c
-- JOIN <parent_table> AS p ON c.<parent_id> = p.<parent_id>;
/* E. ONE FOREIGN-KEY TEST: deliberately reference a missing parent.
   Substitute a complete INSERT into a child table. Supply valid values for
   ALL OTHER columns, so only the intended FK should be violated.
   Expected SQL Server error: 547, with the intended FK constraint name.
   An expected rejection is caught; the rest of the file can still run.
   Record the message in template Section 9.2. 
    -- INSERT INTO <child_table> (<columns including FK>)
    -- VALUES (<values with nonexistent FK>);*/
BEGIN TRY
    INSERT  INTO dbo.rental (rental_id, date_added, expired, movie_id)
    VALUES                 
    ('R999', '15:30:00', 0, 'M999');
    PRINT 'FK test FAILED: no invalid insert was written or the insert was accepted';
END TRY
BEGIN CATCH
    PRINT CONCAT('FK test rejected: Msg ', ERROR_NUMBER(), ' - ', ERROR_MESSAGE());
END CATCH


/* Other rules: in Section 5 of your PDF, identify what the database
   declares now and what the final application must check later.
   A five-active-link limit cannot be implemented using a row-level CHECK. */
