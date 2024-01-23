BEGIN
	INSERT INTO dbo.tblCustomer(Id, FirstName, LastName, UserName, Password, Address, City, State, Zip, Phone, MembershipId, DisplayName, profileImage, AboutMe, SocialSites)
	VALUES
	(1, 'Harry', 'Potter', 'PotterForever', 'test', '999 Test Ave', 'Appleton', 'WI', '54915', '999-999-9999', 1, 'Potter', 'none', 'TestBio', 'None')



END