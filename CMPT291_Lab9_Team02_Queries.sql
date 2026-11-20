/* ===========================================================================
   CMPT 291 Lab 9 - SQL Queries                          Team <02>
   Members: Mitchell Stolte, Sylvester Voon, Jake Hanson, John Roque

   File: CMPT291_Lab9_Team02_Create.sql
   Goal: Drop the tables at the beggining of file so that the code can be rerun, then create
   empty tables for the database.

=============================================================================== */

-- USE specified database
USE MovieRental_Team02
Go

-- BR-10 five-unexpired-link-limit
select c.customer_id, c.name AS customerName, count(*) AS total_rentals
From customer AS c 
    join renting as r ON c.customer_id = r.customer_id 
    join rental As rt on r.rental_id = rt.rental_id
where rt.expired = 0
Group by c.customer_id, c.name
having count(*) > 5
Order by total_rentals DESC

-- BR-10 customers at the link limit
select c.customer_id, c.name AS customerName, count(*) AS total_rentals
From customer AS c 
    join renting as r ON c.customer_id = r.customer_id 
    join rental As rt on r.rental_id = rt.rental_id
where rt.expired = 0
Group by c.customer_id, c.name
having count(*) = 5
Order by total_rentals DESC

-- BR-15 ratings by customers who never rented that movie
select mr.rating, c.customer_id
from movie_ratings as mr
   full outer join customer as c on mr.customer_id = c.customer_id
   full outer join renting as rg on c.customer_id = rg.customer_id
where mr.rental_id is null and rg.rental_id is not null

-- BR-12 balance owed (by every customer)
select c.customer_id, c.name AS customerName, count(*) * 5 AS total_charges
From customer AS c 
    join renting as r ON c.customer_id = r.customer_id 
    join rental As rt on r.rental_id = rt.rental_id
Group by c.customer_id, c.name

-----------------------------------------------Report-------------------------------------------------------------------------

-- Report #1 -> Monthly Rental Income
-- Output: Year, Month, number of rentals, total rental charges for each month
-- Table: rental(rental_datetime, charge_amount)
-- Requirements Met: Group by and aggregate function & uses date

select Year(date_added) AS year, Month(date_added) AS month, count(rental_id) AS num_of_rentals, count(rental_id) * 5 AS total_charges
From rental
Group By Year(date_added), Month(date_added)
Order By year, month



-- Report #2 -> Most Active Customers
-- Output: customer_id, customer_name, number of rentals, total charges
-- Table: customer, rental
-- Requirements Met: Group By and aggregate function & joins three or more tables

select c.customer_id, c.name AS customerName, count(*) AS total_rentals, count(*) * 5 AS total_charges
From customer AS c 
    join renting as r ON c.customer_id = r.customer_id 
    join rental As rt on r.rental_id = rt.rental_id
Group by c.customer_id, c.name
Order by total_rentals DESC



-- Report #3 -> Most Frequesntly Rented Movies
-- Output: Movie Title, Genre, Amount Rented, Customer rating -> top 5
-- Table: movie, rental, movie rating
-- Requirements Met: Group by and aggrgate function & joins three or more tables

Select TOP 5 WITH TIES m.title, g.genre, count(distinct r.rental_id) AS num_of_rentals, AVG(mr.rating) AS avg_rating
From movie AS m 
    join rental AS R ON m.movie_id = r.movie_id
	join movie_genres AS g ON m.movie_id = g.movie_id
	left join movie_ratings AS mr ON m.movie_id = mr.movie_id
Group By m.movie_id, m.title, g.genre
Order by num_of_rentals DESC
-- How ranking handles ties: 
--      The ranking is handle by the number of rentals, any ties with the 5th rank will also be added to the table


-- Report #4 -> Movie rentals filtered or grouped by movie name, type or customer
-- Output: One line per rental: rental date/time, customer name, movie title, 
--			movie type (genre), processing employee, and link status (active/expired).
-- Table: rental, customer, movie, employee
-- Requirements Met: uses status and filters & use three or more tables


DECLARE @FilterType VARCHAR(20) = 'Genre'; --filter by movie name "Title", genre "Genre", or customer name "Customer"
-- *we could add more types*

DECLARE @FilterValue VARCHAR(50) = 'Action'; -- search based on filter type 
-- *for customer search, must write full name, partial name wont be able to search*

Select r.date_added AS rental_date,
        c.name AS customer_name,
        m.title AS title,
        g.genre AS genre,
        e.name As processing_employee,
        r.expired as status
From rental AS r
join renting As rt on r.rental_id = rt.rental_id
join customer AS c ON rt.customer_id = c.customer_id
join movie as m ON r.movie_id = m.movie_id
join movie_genres AS g ON m.movie_id = g.movie_id
join manage as mg on c.customer_id = mg.customer_id
join employee as e on mg.employee_id = e.employee_id
Where ((@FilterType = 'Title' AND m.title = @FilterValue) OR
       (@FilterType = 'Genre' AND g.genre = @FilterValue)OR
       (@FilterType = 'Customer' AND c.name = @FilterValue))
ORDER BY r.date_added DESC;



-- Report #5 -> Movies with a certain minimum rating
-- Output: title, number of ratings, avg rating
-- Table: movie, movie_ratings
-- Requirements Met: Group by and aggragate function & uses a subquery & uses filter

DECLARE @RatingValue INT = 5;

Select m.title, count(mr.rating) AS num_of_ratings, AVG(cast(mr.rating AS float)) AS avg_rating
From movie AS m
join movie_ratings AS mr oN m.movie_id = mr.movie_id
Where m.movie_id IN (
    Select movie_id
    From movie_ratings
    Where rating >= @RatingValue )
Group By m.movie_id, m.title
Order BY avg_rating DESC;

