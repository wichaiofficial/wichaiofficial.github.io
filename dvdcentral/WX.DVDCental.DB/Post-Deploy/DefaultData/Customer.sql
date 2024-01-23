BEGIN
	INSERT INTO tblCustomer (Id, FirstName, LastName, Address, City, State, ZIP, Phone, UserId)
	VALUES
	(1,'Josh', 'McDaniels', '321 North St', 'Appleton', 'WI', '54915', '19202814459', 1),
	(2,'Nate', 'Allen', '224 Highview Ave', 'Oshkosh', 'WI', '54901', '19207815549', 2),
	(3,'Aaron', 'Rodgers', '504 Packer St', 'Greenbay', 'WI', '54229', '19206671387', 3)
END