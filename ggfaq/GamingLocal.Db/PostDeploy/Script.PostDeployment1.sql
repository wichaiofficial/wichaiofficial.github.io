/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
:r .\DefaultData\GameDevelopers.sql
:r .\DefaultData\Genres.sql
:r .\DefaultData\Manufacturers.sql
:r .\DefaultData\Ratings.sql
:r .\DefaultData\Teams.sql
:r .\DefaultData\TournamentFormats.sql
:r .\DefaultData\GameDescriptions.sql
:r .\DefaultData\Memberships.sql
:r .\DefaultData\Customers.sql
:r .\DefaultData\CustomerAddedGames.sql
:r .\DefaultData\Systems.sql
:r .\DefaultData\Games.sql
:r .\DefaultData\Librarys.sql
:r .\DefaultData\LibraryGames.sql
:r .\DefaultData\Tournaments.sql
:r .\DefaultData\Registrations.sql
:r .\DefaultData\Threads.sql
:r .\DefaultData\FollowingThreads.sql
:r .\DefaultData\Posts.sql
:r .\DefaultData\EventThreads.sql
:r .\DefaultData\EventPosts.sql
:r .\DefaultData\GameUserRatings.sql