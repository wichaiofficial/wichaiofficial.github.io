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


DROP TABLE IF EXISTS dbo.tblGameUserRating
DROP TABLE IF EXISTS dbo.tblEventPost
DROP TABLE IF EXISTS dbo.tblEventThread
DROP TABLE IF EXISTS dbo.tblPost
DROP TABLE IF EXISTS dbo.tblFollowingThread
DROP TABLE IF EXISTS dbo.tblThread
DROP TABLE IF EXISTS dbo.tblRegistration
DROP TABLE IF EXISTS dbo.tblTournament
DROP TABLE IF EXISTS dbo.tblLibraryGame
DROP TABLE IF EXISTS dbo.tblLibrary
DROP TABLE IF EXISTS dbo.tblGame
DROP TABLE IF EXISTS dbo.tblSystem
DROP TABLE IF EXISTS dbo.tblCustomerAddedGame
DROP TABLE IF EXISTS dbo.tblCustomer
DROP TABLE IF EXISTS dbo.tblMembership
DROP TABLE IF EXISTS dbo.tblGameDescription
DROP TABLE IF EXISTS dbo.tblUser
DROP TABLE IF EXISTS dbo.tblTournamentFormat
DROP TABLE IF EXISTS dbo.tblTeam
DROP TABLE IF EXISTS dbo.tblRating
DROP TABLE IF EXISTS dbo.tblManufacturer
DROP TABLE IF EXISTS dbo.tblGenre
DROP TABLE IF EXISTS dbo.tblGameDeveloper













