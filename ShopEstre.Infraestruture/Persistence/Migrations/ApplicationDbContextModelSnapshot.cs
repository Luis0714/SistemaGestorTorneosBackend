﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopEstre.Infraestruture.Persistence.Contexts;

#nullable disable

namespace ShopEstre.Infraestruture.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopEstre.Domain.Entities.Game", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LocalTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("VisitingTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GameId");

                    b.HasIndex("LocalTeamId");

                    b.HasIndex("VisitingTeamId");

                    b.ToTable("Games", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Player", b =>
                {
                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayerId");

                    b.ToTable("Players", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.PlayerGame", b =>
                {
                    b.Property<Guid>("PlayerGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsStarter")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlayerTeamTournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayerGameId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerTeamTournamentId");

                    b.ToTable("PlayerGames", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.PlayerGameStatistics", b =>
                {
                    b.Property<Guid>("PlayerGameStatisticsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayerGameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RedCards")
                        .HasColumnType("int");

                    b.Property<int>("Scores")
                        .HasColumnType("int");

                    b.Property<int>("YellowCards")
                        .HasColumnType("int");

                    b.HasKey("PlayerGameStatisticsId");

                    b.HasIndex("PlayerGameId");

                    b.ToTable("PlayerGameStatistics", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.PlayerTeamTournaments", b =>
                {
                    b.Property<Guid>("PlayerTeamTournamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TournamentTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayerTeamTournamentId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TournamentTeamId");

                    b.ToTable("PlayerTeamTournaments", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("RolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RolId");

                    b.ToTable("Rols", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Team", b =>
                {
                    b.Property<Guid>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Tournament", b =>
                {
                    b.Property<Guid>("TournamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TournamentStateId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("TournamentId");

                    b.HasIndex("TournamentStateId")
                        .IsUnique();

                    b.ToTable("Tournaments", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.TournamentGameStatistics", b =>
                {
                    b.Property<Guid>("TournamentGameStatisticsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LocalTeamScores")
                        .HasColumnType("int");

                    b.Property<int>("VisitingScores")
                        .HasColumnType("int");

                    b.HasKey("TournamentGameStatisticsId");

                    b.HasIndex("GameId")
                        .IsUnique();

                    b.ToTable("TournamentGameStatistics", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.TournamentState", b =>
                {
                    b.Property<Guid>("TournamentStateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TournamentStateId");

                    b.ToTable("TournamentStates", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.TournamentStatistics", b =>
                {
                    b.Property<Guid>("TournametStatisticsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DifferenceGoals")
                        .HasColumnType("int");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("GoalsReceived")
                        .HasColumnType("int");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("MatchesLost")
                        .HasColumnType("int");

                    b.Property<int>("MatchesTied")
                        .HasColumnType("int");

                    b.Property<int>("MatchesWon")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<Guid>("TounamentTeamsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TournametStatisticsId");

                    b.HasIndex("TounamentTeamsId");

                    b.ToTable("TournamentStatistics", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.TournamentTeams", b =>
                {
                    b.Property<Guid>("TourmentTeamsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TournamentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TourmentTeamsId");

                    b.HasIndex("TeamId");

                    b.HasIndex("TournamentId");

                    b.ToTable("TournamentTeams", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Game", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.Team", "LocalTeam")
                        .WithMany()
                        .HasForeignKey("LocalTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ShopEstre.Domain.Entities.Team", "VisitingTeam")
                        .WithMany()
                        .HasForeignKey("VisitingTeamId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("LocalTeam");

                    b.Navigation("VisitingTeam");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Player", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.User", "User")
                        .WithOne("Player")
                        .HasForeignKey("ShopEstre.Domain.Entities.Player", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.PlayerGame", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEstre.Domain.Entities.PlayerTeamTournaments", "PlayerTeamTournament")
                        .WithMany()
                        .HasForeignKey("PlayerTeamTournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("PlayerTeamTournament");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.PlayerGameStatistics", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.PlayerGame", "PlayerGame")
                        .WithMany("PlayerGameStatistics")
                        .HasForeignKey("PlayerGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlayerGame");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.PlayerTeamTournaments", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.Player", "Player")
                        .WithMany("TeamsByTournament")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEstre.Domain.Entities.TournamentTeams", "TournamentTeam")
                        .WithMany()
                        .HasForeignKey("TournamentTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("TournamentTeam");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Tournament", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.TournamentState", "TournamentState")
                        .WithOne()
                        .HasForeignKey("ShopEstre.Domain.Entities.Tournament", "TournamentStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TournamentState");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.TournamentGameStatistics", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.Game", "Game")
                        .WithOne()
                        .HasForeignKey("ShopEstre.Domain.Entities.TournamentGameStatistics", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.TournamentStatistics", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.TournamentTeams", "TounamentTeam")
                        .WithMany()
                        .HasForeignKey("TounamentTeamsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TounamentTeam");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.TournamentTeams", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.Team", "Team")
                        .WithMany("TournamentTeams")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEstre.Domain.Entities.Tournament", "Tournament")
                        .WithMany("TournamentTeams")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.User", b =>
                {
                    b.HasOne("ShopEstre.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Player", b =>
                {
                    b.Navigation("TeamsByTournament");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.PlayerGame", b =>
                {
                    b.Navigation("PlayerGameStatistics");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Team", b =>
                {
                    b.Navigation("TournamentTeams");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.Tournament", b =>
                {
                    b.Navigation("TournamentTeams");
                });

            modelBuilder.Entity("ShopEstre.Domain.Entities.User", b =>
                {
                    b.Navigation("Player")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
