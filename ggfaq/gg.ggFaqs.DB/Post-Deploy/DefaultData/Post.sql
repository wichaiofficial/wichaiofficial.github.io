BEGIN

	INSERT INTO tblPost(Id, Title, Content, Created, ThreadId, CustomerId, ImagePath)
	VALUES 
	(1, 'test post', GETDATE(), 1, 1, '')

END