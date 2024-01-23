BEGIN
	INSERT INTO tblOrderItem (Id, OrderId, MovieId, Quantity, Cost)
	VALUES
	(1, 1, 2, 1, 15.99),
	(2, 1, 1, 1, 13.99),
	(3, 1, 3, 1, 10.99),
	(4, 2, 2, 1, 15.99),
	(5, 2, 1, 1, 13.99),
	(6, 3, 3, 1, 10.99)
END