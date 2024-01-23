using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace gg.ggFaqs.PL;

public partial class ggEntities : DbContext
{
    public ggEntities()
    {
    }

    public ggEntities(DbContextOptions<ggEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<tblCustomer> tblCustomers { get; set; }

    public virtual DbSet<tblCustomerAddedGame> tblCustomerAddedGames { get; set; }

    public virtual DbSet<tblEventPost> tblEventPosts { get; set; }

    public virtual DbSet<tblEventThread> tblEventThreads { get; set; }

    public virtual DbSet<tblFollowingThread> tblFollowingThreads { get; set; }

    public virtual DbSet<tblGame> tblGames { get; set; }

    public virtual DbSet<tblGameDescription> tblGameDescriptions { get; set; }

    public virtual DbSet<tblGameDeveloper> tblGameDevelopers { get; set; }

    public virtual DbSet<tblGameUserRating> tblGameUserRatings { get; set; }

    public virtual DbSet<tblGenre> tblGenres { get; set; }

    public virtual DbSet<tblLibrary> tblLibraries { get; set; }

    public virtual DbSet<tblLibraryGame> tblLibraryGames { get; set; }

    public virtual DbSet<tblManufacturer> tblManufacturers { get; set; }

    public virtual DbSet<tblMembership> tblMemberships { get; set; }

    public virtual DbSet<tblPost> tblPosts { get; set; }

    public virtual DbSet<tblRating> tblRatings { get; set; }

    public virtual DbSet<tblRegistration> tblRegistrations { get; set; }

    public virtual DbSet<tblSystem> tblSystems { get; set; }

    public virtual DbSet<tblTeam> tblTeams { get; set; }

    public virtual DbSet<tblThread> tblThreads { get; set; }

    public virtual DbSet<tblTournament> tblTournaments { get; set; }

    public virtual DbSet<tblTournamentFormat> tblTournamentFormats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Local Connection
        //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GamerLocal.Db;Integrated Security=True");
        //Remote Connection
        optionsBuilder.UseSqlServer("Server=gaminggroupwizards.database.windows.net;Database=GamingGroup;User Id=CloudSA9dfb2836;Password=GGfaq123!");
        optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<tblCustomer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblCusto__3214EC074E34BBB8");

            entity.ToTable("tblCustomer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AboutMe)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MembershipId).HasDefaultValueSql("((1))");
            entity.Property(e => e.Password)
                .HasMaxLength(28)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.SocialSites)
                .HasMaxLength(2000)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.profileImage)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Membership).WithMany(p => p.tblCustomers)
                .HasForeignKey(d => d.MembershipId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblCustomer_MembershipId");
        });

        modelBuilder.Entity<tblCustomerAddedGame>(entity =>
        {
            entity.HasKey(e => e.AddGameId).HasName("PK__tblCusto__5435EC8FD4F7F560");

            entity.ToTable("tblCustomerAddedGame");

            entity.Property(e => e.AddGameId).ValueGeneratedNever();
            entity.Property(e => e.GameDeveloper)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GameTitle)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rating)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.System)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.tblCustomerAddedGames)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblCustomerAddedGame_CustomerId");
        });

        modelBuilder.Entity<tblEventPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblEvent__3214EC0781DD2ADA");

            entity.ToTable("tblEventPost");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Content)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.ImagePath)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.tblEventPosts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblEventPost_CustomerId");

            entity.HasOne(d => d.EventThread).WithMany(p => p.tblEventPosts)
                .HasForeignKey(d => d.EventThreadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblEventPost_EventThreadId");
        });

        modelBuilder.Entity<tblEventThread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblEvent__3214EC07548653DD");

            entity.ToTable("tblEventThread");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.EventName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.tblEventThreads)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblEventThread_UserId");
        });

        modelBuilder.Entity<tblFollowingThread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblFollo__3214EC073CCA7AA3");

            entity.ToTable("tblFollowingThread");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.tblFollowingThreads)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblFollowingThread_CustomerId");

            entity.HasOne(d => d.Thread).WithMany(p => p.tblFollowingThreads)
                .HasForeignKey(d => d.ThreadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblFollowingThread_ThreadId");
        });

        modelBuilder.Entity<tblGame>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGame__3214EC07BF188E63");

            entity.ToTable("tblGame");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ImagePath)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Release).HasColumnType("date");
            entity.Property(e => e.Title)
                .HasMaxLength(75)
                .IsUnicode(false);

            entity.HasOne(d => d.GameDeveloper).WithMany(p => p.tblGames)
                .HasForeignKey(d => d.GameDeveloperId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblGame_GameDeveloperId");

            entity.HasOne(d => d.Genre).WithMany(p => p.tblGames)
                .HasForeignKey(d => d.GenreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblGame_GenreId");

            entity.HasOne(d => d.Rating).WithMany(p => p.tblGames)
                .HasForeignKey(d => d.RatingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblGame_RatingId");

            entity.HasOne(d => d.System).WithMany(p => p.tblGames)
                .HasForeignKey(d => d.SystemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblGame_SystemId");
        });

        modelBuilder.Entity<tblGameDescription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGameD__3214EC07A22DF218");

            entity.ToTable("tblGameDescription");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblGameDeveloper>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGameD__3214EC07E7CEBF85");

            entity.ToTable("tblGameDeveloper");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateEstablished).HasColumnType("date");
            entity.Property(e => e.DeveloperName)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblGameUserRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGameU__3214EC07C1411A3E");

            entity.ToTable("tblGameUserRating");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.tblGameUserRatings)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblGameUserRating_CustomerId");

            entity.HasOne(d => d.Game).WithMany(p => p.tblGameUserRatings)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblGameUserRating_GameId");
        });

        modelBuilder.Entity<tblGenre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblGenre__3214EC07A8336127");

            entity.ToTable("tblGenre");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GenreDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblLibrary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblLibra__3214EC071EC2A62F");

            entity.ToTable("tblLibrary");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Customer).WithMany(p => p.tblLibraries)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblLibrary_CustomerId");
        });

        modelBuilder.Entity<tblLibraryGame>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblLibra__3214EC079CDC25A9");

            entity.ToTable("tblLibraryGame");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateAdded).HasColumnType("date");

            entity.HasOne(d => d.Game).WithMany(p => p.tblLibraryGames)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblLibraryGame_GameId");

            entity.HasOne(d => d.Library).WithMany(p => p.tblLibraryGames)
                .HasForeignKey(d => d.LibraryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblLibraryGame_LibraryId");
        });

        modelBuilder.Entity<tblManufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblManuf__3214EC073624F96C");

            entity.ToTable("tblManufacturer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsFixedLength();
        });

        modelBuilder.Entity<tblMembership>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblMembe__3214EC0756A7C4BC");

            entity.ToTable("tblMembership");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Membership)
                .HasMaxLength(45)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblPost__3214EC07638F8ED3");

            entity.ToTable("tblPost");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Content)
                .HasMaxLength(5000)
                .IsUnicode(false);
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.ImagePath)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.tblPosts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblPost_CustomerId");

            entity.HasOne(d => d.Thread).WithMany(p => p.tblPosts)
                .HasForeignKey(d => d.ThreadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblPost_ThreadId");
        });

        modelBuilder.Entity<tblRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblRatin__3214EC07C6D7AA04");

            entity.ToTable("tblRating");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Rating)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RatingDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblRegistration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblRegis__3214EC07D1F9CA55");

            entity.ToTable("tblRegistration");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AmountDue).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.TotalCost).HasColumnType("decimal(7, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.tblRegistrations)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblRegistration_CustomerId");

            entity.HasOne(d => d.Team).WithMany(p => p.tblRegistrations)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblRegistration_TeamId");

            entity.HasOne(d => d.Tournament).WithMany(p => p.tblRegistrations)
                .HasForeignKey(d => d.TournamentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblRegistration_TournamentId");
        });

        modelBuilder.Entity<tblSystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblSyste__3214EC0785A141A3");

            entity.ToTable("tblSystem");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Release).HasColumnType("date");

            entity.HasOne(d => d.Manufacturer).WithMany(p => p.tblSystems)
                .HasForeignKey(d => d.ManufacturerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblSystem_ManufacturerId");
        });

        modelBuilder.Entity<tblTeam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTeam__3214EC07E284CEC4");

            entity.ToTable("tblTeam");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AmountDue).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.AmountPaid).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Email)
                .HasMaxLength(75)
                .IsUnicode(false);
            entity.Property(e => e.PlayerFirstName)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.PlayerLastName)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.TeamName)
                .HasMaxLength(75)
                .IsUnicode(false);
        });

        modelBuilder.Entity<tblThread>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblThrea__3214EC07DFD61307");

            entity.ToTable("tblThread");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Subject)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Customer).WithMany(p => p.tblThreads)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblThread_CustomerId");

            entity.HasOne(d => d.Game).WithMany(p => p.tblThreads)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblThread_GameId");
        });

        modelBuilder.Entity<tblTournament>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTourn__3214EC07E3754F9D");

            entity.ToTable("tblTournament");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CostPerPlayer).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.Format).WithMany(p => p.tblTournaments)
                .HasForeignKey(d => d.FormatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblTournament_FormatId");

            entity.HasOne(d => d.Game).WithMany(p => p.tblTournaments)
                .HasForeignKey(d => d.GameId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_tblTournament_GameId");
        });

        modelBuilder.Entity<tblTournamentFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblTourn__3214EC073EE760DC");

            entity.ToTable("tblTournamentFormat");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FormatDescription)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FormatType)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
