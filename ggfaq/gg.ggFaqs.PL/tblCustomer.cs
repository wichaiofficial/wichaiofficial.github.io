using System;
using System.Collections.Generic;

namespace gg.ggFaqs.PL;

public partial class tblCustomer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string? Phone { get; set; }

    public int MembershipId { get; set; }

    public string DisplayName { get; set; } = null!;

    public string profileImage { get; set; } = null!;

    public string? AboutMe { get; set; }

    public string? SocialSites { get; set; }

    public virtual tblMembership Membership { get; set; } = null!;

    public virtual ICollection<tblCustomerAddedGame> tblCustomerAddedGames { get; } = new List<tblCustomerAddedGame>();

    public virtual ICollection<tblEventPost> tblEventPosts { get; } = new List<tblEventPost>();

    public virtual ICollection<tblEventThread> tblEventThreads { get; } = new List<tblEventThread>();

    public virtual ICollection<tblFollowingThread> tblFollowingThreads { get; } = new List<tblFollowingThread>();

    public virtual ICollection<tblGameUserRating> tblGameUserRatings { get; } = new List<tblGameUserRating>();

    public virtual ICollection<tblLibrary> tblLibraries { get; } = new List<tblLibrary>();

    public virtual ICollection<tblPost> tblPosts { get; } = new List<tblPost>();

    public virtual ICollection<tblRegistration> tblRegistrations { get; } = new List<tblRegistration>();

    public virtual ICollection<tblThread> tblThreads { get; } = new List<tblThread>();
}
