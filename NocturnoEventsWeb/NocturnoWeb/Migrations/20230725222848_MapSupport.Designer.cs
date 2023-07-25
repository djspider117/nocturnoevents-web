﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NocturnoWeb.Data;

#nullable disable

namespace NocturnoWeb.Migrations
{
    [DbContext(typeof(NocturnoDbContext))]
    [Migration("20230725222848_MapSupport")]
    partial class MapSupport
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("NocturnoWeb.Data.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Bio")
                        .HasColumnType("TEXT");

                    b.Property<string>("CoverUri")
                        .HasColumnType("TEXT");

                    b.Property<string>("DbSocialLinks")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUri")
                        .HasColumnType("TEXT");

                    b.Property<string>("LogoUri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("StyleLine")
                        .HasColumnType("TEXT");

                    b.Property<string>("Video")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("NocturnoWeb.Data.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoverUri")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("MapEmbedding")
                        .HasColumnType("TEXT");

                    b.Property<string>("MapsUri")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterUri")
                        .HasColumnType("TEXT");

                    b.Property<string>("TicketsUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("VenueName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("NocturnoWeb.Data.EventArtistMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EventId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("EventId");

                    b.ToTable("EventArtistMapping");
                });

            modelBuilder.Entity("NocturnoWeb.Data.EventArtistMapping", b =>
                {
                    b.HasOne("NocturnoWeb.Data.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NocturnoWeb.Data.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
