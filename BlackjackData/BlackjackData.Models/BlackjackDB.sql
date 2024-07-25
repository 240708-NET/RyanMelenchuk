/*
-- Connect to the 'master' database to run this snippet
USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'Blackjack'
)
CREATE DATABASE Blackjack
GO
*/
-- Use the Blackjack DB
USE Blackjack;
GO

-- Create the Player table
/*
CREATE TABLE Players
(
    ID INT NOT NULL PRIMARY KEY,
    Wins INT,
    Losses INT,
    Blackjacks INT,
    Chips INT,
    ChipsWon INT,
    ChipsLost INT
)
*/

-- Query Players table
SELECT *
FROM [Blackjack].[dbo].[Players];

-- Delete all rows from the Players table
DELETE FROM [Blackjack].[dbo].[Players];