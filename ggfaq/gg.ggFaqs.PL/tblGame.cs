using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblGame
{
    public int Id { get; set; }

    public int SystemId { get; set; }

    public string Title { get; set; } = null!;

    public DateTime Release { get; set; }

    public int RatingId { get; set; }

    public int GenreId { get; set; }

    public int GameDeveloperId { get; set; }

    public int GameDescriptionId { get; set; }

    public string ImagePath { get; set; } = null!;

    public virtual tblGameDeveloper GameDeveloper { get; set; } = null!;

    public virtual tblGenre Genre { get; set; } = null!;

    public virtual tblRating Rating { get; set; } = null!;

    public virtual tblSystem System { get; set; } = null!;

    public virtual ICollection<tblGameUserRating> tblGameUserRatings { get; } = new List<tblGameUserRating>();

    public virtual ICollection<tblLibraryGame> tblLibraryGames { get; } = new List<tblLibraryGame>();

    public virtual ICollection<tblThread> tblThreads { get; } = new List<tblThread>();

    public virtual ICollection<tblTournament> tblTournaments { get; } = new List<tblTournament>();
}
