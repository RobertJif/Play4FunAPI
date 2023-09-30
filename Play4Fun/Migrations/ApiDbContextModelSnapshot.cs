﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Play4Fun.Repository;

#nullable disable

namespace Play4Fun.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Play4Fun.Repository.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("DescriptionHTML")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description_html");

                    b.Property<string>("GameImagePath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("game_image_path");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_at");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("modified_by");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("PlayerCount")
                        .HasColumnType("integer")
                        .HasColumnName("player_count");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("pk_games");

                    b.HasIndex("Code")
                        .IsUnique()
                        .HasDatabaseName("ix_games_code");

                    b.ToTable("games", (string)null);
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.GameMatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<int>("GameId")
                        .HasColumnType("integer")
                        .HasColumnName("game_id");

                    b.Property<DateTime>("MatchEndAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("match_end_at");

                    b.Property<int>("MatchStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0)
                        .HasColumnName("match_status");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_at");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("modified_by");

                    b.Property<List<string>>("Result")
                        .IsRequired()
                        .HasColumnType("text[]")
                        .HasColumnName("result");

                    b.Property<int>("WinnerId")
                        .HasColumnType("integer")
                        .HasColumnName("winner_id");

                    b.HasKey("Id")
                        .HasName("pk_game_matches");

                    b.HasIndex("GameId")
                        .HasDatabaseName("ix_game_matches_game_id");

                    b.HasIndex("WinnerId")
                        .HasDatabaseName("ix_game_matches_winner_id");

                    b.ToTable("game_matches", (string)null);
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.GameMatchPlayer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<int>("GameMatchId")
                        .HasColumnType("integer")
                        .HasColumnName("game_match_id");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_at");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("modified_by");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer")
                        .HasColumnName("player_id");

                    b.HasKey("Id")
                        .HasName("pk_game_match_players");

                    b.HasIndex("GameMatchId")
                        .HasDatabaseName("ix_game_match_players_game_match_id");

                    b.HasIndex("PlayerId")
                        .HasDatabaseName("ix_game_match_players_player_id");

                    b.ToTable("game_match_players", (string)null);
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("display_name");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_at");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("modified_by");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("password");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("bytea")
                        .HasColumnName("salt");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_players");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("ix_players_username");

                    b.ToTable("players", (string)null);
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.PlayerToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modified_at");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("modified_by");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer")
                        .HasColumnName("player_id");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("refresh_token");

                    b.HasKey("Id")
                        .HasName("pk_player_token");

                    b.HasIndex("PlayerId")
                        .HasDatabaseName("ix_player_token_player_id");

                    b.ToTable("player_token", (string)null);
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.GameMatch", b =>
                {
                    b.HasOne("Play4Fun.Repository.Entities.Game", "Game")
                        .WithMany("GameMatches")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_game_matches_games_game_id");

                    b.HasOne("Play4Fun.Repository.Entities.Player", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_game_matches_players_winner_id");

                    b.Navigation("Game");

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.GameMatchPlayer", b =>
                {
                    b.HasOne("Play4Fun.Repository.Entities.GameMatch", "GameMatch")
                        .WithMany("Players")
                        .HasForeignKey("GameMatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_game_match_players_game_matches_game_match_id");

                    b.HasOne("Play4Fun.Repository.Entities.Player", "Player")
                        .WithMany("GameMatchPlayers")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_game_match_players_players_player_id");

                    b.Navigation("GameMatch");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.PlayerToken", b =>
                {
                    b.HasOne("Play4Fun.Repository.Entities.Player", "Player")
                        .WithMany("PlayerTokens")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_player_token_players_player_id");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.Game", b =>
                {
                    b.Navigation("GameMatches");
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.GameMatch", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("Play4Fun.Repository.Entities.Player", b =>
                {
                    b.Navigation("GameMatchPlayers");

                    b.Navigation("PlayerTokens");
                });
#pragma warning restore 612, 618
        }
    }
}
