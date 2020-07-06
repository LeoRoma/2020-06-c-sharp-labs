----1.1 Creting a database----

--USE leo_db;--

--SP_HELP name_table; it shows the table--

-- CREATE TABLE film_table
-- ( 
--     film_name VARCHAR(10)
--     ,film_type VARCHAR(6)
-- );

-- DROP TABLE film_table;

-- CREATE TABLE film_table
-- (
--     film_id INT IDENTITY(1,1) PRIMARY KEY NOT NULL
--     ,film_name VARCHAR(10)
--     ,film_type VARCHAR(6)
--     ,Date_of_release date
--     ,Director VARCHAR(30)
--     ,Writer VARCHAR(30)
--     ,Star VARCHAR(30)
--     ,Film_language VARCHAR(3) NOT NULL
--     ,official_website VARCHAR(30)
--     ,plot_summary VARCHAR(255)
-- );

-- SP_HELP film_table;

-- INSERT INTO film_table
-- (
--     film_name,
--     film_type,
--     Date_of_release,
--     Director,
--     Writer,
--     Star,
--     Film_language,
--     official_website,
--     plot_summary
-- )
-- VALUES
-- (
--     'Shaun',
--     'Comedy',
--     '2004-09-09',
--     'Nira Park',
--     'Edgar Wright',
--     'Simon Pegg',
--     'Eng',
--     'www.shaunofthedead.com',
--     'Shaun of the Dead is a 2004 horror comedy film directed by Edgar Wright.'
-- );
-- SELECT * FROM film_table;

-- To Change value in a column

-- UPDATE film_table 
-- SET film_name = 'Hello'
-- WHERE film_id = 2;


--Alter 
-- ALTER TABLE film_table
-- DROP COLUMN Writer;

-- Deletes all data in the table but not the columns
-- TRUNCATE TABLE film_table;

SP_HELP film_table;
