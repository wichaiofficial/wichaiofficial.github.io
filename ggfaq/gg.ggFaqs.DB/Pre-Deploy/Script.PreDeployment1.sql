/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DROP TABLE IF EXISTS tblCustomer
DROP TABLE IF EXISTS tblGame
DROP TABLE IF EXISTS tblGameDeveloper
DROP TABLE IF EXISTS tblGenre
DROP TABLE IF EXISTS tblLibrary
DROP TABLE IF EXISTS tblLibraryGame
DROP TABLE IF EXISTS tblManufacturer
DROP TABLE IF EXISTS tblPost
DROP TABLE IF EXISTS tblRating
DROP TABLE IF EXISTS tblSystem
DROP TABLE IF EXISTS tblThread
DROP TABLE IF EXISTS tblUser