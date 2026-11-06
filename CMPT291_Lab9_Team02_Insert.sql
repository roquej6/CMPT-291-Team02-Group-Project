/* ===========================================================================
   CMPT 291 Lab 9 - SQL Create                          Team <02>
   Members: Mitchell Stolte, Sylvester Voon, Jake Hanson, John Roque

   File: CMPT291_Lab9_Team02_Create.sql
   Goal: Drop the tables at the beggining of file so that the code can be rerun, then create
   empty tables for the database.

=============================================================================== */

IF DB_ID(N'MovieRental_Team02') IS NULL 
 THROW 51000, 'No Database Found! Run the create file first.', 1;
ELSE USE MovieRental_Team02;
GO

-- Insert mock employees
INSERT  INTO dbo.employee (employee_id, name, email, age, salary)
VALUES                   
('E0001', 'Sharon Daniels', 'daniels@gmail.com', 24, 55000.00),
('E0002', 'Sarah Williams', 'williams@gmail.com', 32, 65000.00),
('E0003', 'Jeremy Smith', 'smithj@gmail.com', 77, 12.00);

-- Insert mock customers
INSERT  INTO dbo.customer (customer_id, name, email, age, account_active)
VALUES                   
('C0001', 'Mike Brown', 'mike@email.com', 22, 1),
('C0002', 'Emily Davis', 'emily@email.com', 25, 1),
('C0003', 'Alex Wilson', 'alex@email.com', 30, 1),
('C0004', 'Delter Lindberg', 'delter@email.com', 25, 1),
('C0005', 'Ethan Orange', 'ethan@email.com', 19, 0),
('C0006', 'Cheese Ratman', 'cheese@email.com', 75, 1);

-- Insert mock movies
INSERT  INTO dbo.movie (movie_id, title, available)
VALUES                
('M0001', 'Inception', 1),
('M0002', 'The Matrix', 1),
('M0003', 'Interstellar', 0),
('M0004', 'Steel Ball Run', 1),
('M0005', 'Lone Trail', 1),
('M0006', 'John Wick', 1),
('M0007', 'The Garden of Sinners', 1),
('M0008', 'A Study in Scarlet', 1),
('M0009', 'Beginning of a New Era', 0),
('M0010', 'Army of Darkness', 0), 
('M0011', 'Home Alone', 1),
('M0012', 'Cars 2', 0);
-- Insert mock actors
INSERT  INTO dbo.actor (actor_id, name)
VALUES                
('A0001', 'Leonardo DiCaprio'),
('A0002', 'Keanu Reeves'),
('A0003', 'Matthew McConaughey'),
('A0004', 'Iris Red'),
('A0005', 'Macaulay Culkin'),
('A0006', 'Sir Actsalot'),
('A0007', 'Yuri Lowenthal'),
('A0008', 'Mystia Lorelei'),
('A0009', 'King Henry VIII'),
('A0010', 'Herlock Sholmes');
-- Insert mock rentals
INSERT  INTO dbo.rental (rental_id, date_added, expired, movie_id, URL)
VALUES                 
('R0001', '2026-08-01 10:30:00', 1, 'M0001', 'URL0001'),
('R0002', '2026-08-12 12:45:00', 1, 'M0002', 'URL0002'),
('R0003', '2026-08-25 14:00:00', 1, 'M0003', 'URL0003'),
('R0004', '2026-09-01 08:00:00', 1, 'M0004', 'URL0004'),
('R0005', '2026-09-01 09:00:00', 1, 'M0004', 'URL0005'),
('R0006', '2026-09-02 16:30:05', 1, 'M0010', 'URL0006'),
('R0007', '2026-09-02 17:00:00', 1, 'M0012', 'URL0007'),
('R0008', '2026-09-05 18:00:00', 1, 'M0010', 'URL0008'),
('R0009', '2026-09-15 00:00:00', 1, 'M0003', 'URL0009'),
('R0010', '2026-09-25 01:00:20', 1, 'M0007', 'URL0010'),
('R0011', '2026-10-01 07:20:00', 1, 'M0003', 'URL0011'),
('R0012', '2026-10-12 15:00:00', 1, 'M0008', 'URL0012'),
('R0013', '2026-10-25 14:00:00', 1, 'M0003', 'URL0013'),
('R0014', '2026-11-04 14:00:00', 1, 'M0001', 'URL0014'),
('R0015', '2026-11-06 14:00:00', 0, 'M0003', 'URL0015'),
('R0016', '2026-11-06 14:00:00', 0, 'M0004', 'URL0016'),
('R0017', '2026-11-06 14:00:00', 0, 'M0005', 'URL0017'),
('R0018', '2026-11-06 14:00:00', 0, 'M0006', 'URL0018'),
('R0019', '2026-11-06 14:00:00', 0, 'M0007', 'URL0019'),
('R0020', '2026-11-06 14:00:00', 0, 'M0008', 'URL0020');


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
('A0001', 'M0002'),
('A0002', 'M0001'),
('A0002', 'M0006'),
('A0002', 'M0002'),--5
('A0005', 'M0003'),
('A0010', 'M0008'),
('A0010', 'M0010'),
('A0005', 'M0006'),
('A0008', 'M0002'),--10
('A0004', 'M0010'),
('A0010', 'M0006'),
('A0002', 'M0008'),
('A0001', 'M0006'),
('A0003', 'M0002'),--15
('A0003', 'M0003'),
('A0009', 'M0008'),
('A0009', 'M0001'),
('A0004', 'M0005'),
('A0005', 'M0005');--20

-- actor / movie ratings
INSERT  INTO dbo.actor_movie_rating (actor_id, movie_id, rating)
VALUES                             
('A0001', 'M0001', 9),
('A0002', 'M0002', 10),
('A0003', 'M0003', 8);

-- movie generes
INSERT  INTO dbo.movie_genres (movie_id, genre)
VALUES                       
('M0001', 'Drama'),
('M0002', 'Action'),
('M0003', 'Drama'),
('M0004', 'Foreign'),
('M0004', 'Drama'),
('M0006', 'Action'),
('M0008', 'Drama'),
('M0005', 'Action'),
('M0005', 'Foreign'),
('M0009', 'Foreign'),
('M0007', 'Foreign'),
('M0009', 'Comedy'),
('M0010', 'Comedy'),
('M0011', 'Comedy'),
('M0012', 'Comedy');

-- customer movie ratings
INSERT  INTO dbo.movie_ratings (customer_id, movie_id, rating)
VALUES                       
('C0001', 'M0001', 9),
('C0002', 'M0002', 8),
('C0003', 'M0003', 10),
('C0005', 'M0005', 10),
('C0006', 'M0012', 5),
('C0002', 'M0001', 2);

INSERT INTO dbo.renting (customer_id, rental_id)
VALUES
('C0001', 'R0001'),
('C0002', 'R0002'),
('C0003', 'R0003'),
('C0005', 'R0005'),
('C0005', 'R0012'),
('C0002', 'R0001'),
('C0004', 'R0016'),
('C0004', 'R0017'),
('C0004', 'R0018'),
('C0004', 'R0019'),
('C0004', 'R0020');

INSERT INTO dbo.manage (employee_id, customer_id)
VALUES
('E0001', 'C0001'),
('E0002', 'C0002'),
('E0003', 'C0003'),
('E0001', 'C0004'),
('E0002', 'C0005');
-- employee maintaining actors
INSERT INTO dbo.maintains_actor (employee_id, actor_id)
VALUES                 
('E0001', 'A0001'),
('E0001', 'A0002'),
('E0002', 'A0003');

-- employee maintaining movies
INSERT INTO dbo.maintains_movie (employee_id, movie_id)
VALUES                 
('E0001', 'M0001'),
('E0001', 'M0002'),
('E0002', 'M0003');
GO