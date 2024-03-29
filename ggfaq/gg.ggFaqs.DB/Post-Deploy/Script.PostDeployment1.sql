﻿/*
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

:r .\DefaultData\System.sql
:r .\DefaultData\User.sql
:r .\DefaultData\Manufacturer.sql
:r .\DefaultData\Rating.sql
:r .\DefaultData\Genre.sql
:r .\DefaultData\Customer.sql
:r .\DefaultData\GameDeveloper.sql
:r .\DefaultData\Game.sql
:r .\DefaultData\Library.sql
:r .\DefaultData\LibraryGame.sql
:r .\DefaultData\Thread.sql
:r .\DefaultData\Post.sql

