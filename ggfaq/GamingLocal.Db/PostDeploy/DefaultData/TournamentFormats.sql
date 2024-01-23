BEGIN
	INSERT INTO dbo.tblTournamentFormat(Id, FormatType, FormatDescription)
	VALUES
	(1, 'Single Elimination', 'A single elimination format is a linear bracket where the victorious team within a match will proceed to face the closest non-eliminated team to them in the bracket. The losing team of any match will be eliminated upon their first loss.'),
	(2, 'Double Elimination', 'A double elimination format consists of two linear brackets. All teams begin on the first bracket, but as a team loses they shift over to the 2nd bracket. Teams that lose in the 2nd bracket are eliminated and the final winners of both brackets compete in the grand finals.'),
	(3, 'Round Robin', 'A round-robin format instructs all competitors to face off against all other competitors, regardless of accumulated wins and losses. The victor of this format is determined by the most wins accumulated.'),
	(4, 'Swiss', 'A swiss bracket has teams face off against other teams with the same wins and losses. When a team has different wins and losses than all other teams, they are either eliminated or crowned a victor depending on if they have more wins or losses.')



END