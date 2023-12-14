﻿// <auto-generated />
using System;
using ExecPetTransportBlazorAPI517.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExecPetTransportBlazorAPI517.Migrations
{
    [DbContext(typeof(CoyoteQuoteContext))]
    [Migration("20231214202408_TravelType")]
    partial class TravelType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Cat", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("CatId");

                    b.ToTable("Cats");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Dog", b =>
                {
                    b.Property<int>("DogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("DogId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CellNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("catId")
                        .HasColumnType("int");

                    b.Property<int>("dogId")
                        .HasColumnType("int");

                    b.Property<int>("quoteId")
                        .HasColumnType("int");

                    b.HasKey("OwnerId");

                    b.HasIndex("catId")
                        .IsUnique();

                    b.HasIndex("dogId")
                        .IsUnique();

                    b.HasIndex("quoteId")
                        .IsUnique();

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Quote", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.TravelType", b =>
                {
                    b.Property<int>("TravelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TripId")
                        .HasColumnType("int");

                    b.HasKey("TravelTypeId");

                    b.HasIndex("TripId");

                    b.ToTable("TravelType");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TravelTypeId")
                        .HasColumnType("int");

                    b.Property<string>("destinationaddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationaddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationcity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationstate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationzip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("otherinfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pickupaddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pickupaddress2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pickupcity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pickupstate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pickupzip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quoteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("returndate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("traveldate")
                        .HasColumnType("datetime2");

                    b.HasKey("TripId");

                    b.HasIndex("quoteId")
                        .IsUnique();

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Owner", b =>
                {
                    b.HasOne("ExecPetTransportBlazorAPI517.Models.Cat", "cat")
                        .WithOne("Owner")
                        .HasForeignKey("ExecPetTransportBlazorAPI517.Models.Owner", "catId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExecPetTransportBlazorAPI517.Models.Dog", "dog")
                        .WithOne("Owner")
                        .HasForeignKey("ExecPetTransportBlazorAPI517.Models.Owner", "dogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExecPetTransportBlazorAPI517.Models.Quote", "quote")
                        .WithOne("petowner")
                        .HasForeignKey("ExecPetTransportBlazorAPI517.Models.Owner", "quoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cat");

                    b.Navigation("dog");

                    b.Navigation("quote");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.TravelType", b =>
                {
                    b.HasOne("ExecPetTransportBlazorAPI517.Models.Trip", null)
                        .WithMany("TravelType")
                        .HasForeignKey("TripId");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Trip", b =>
                {
                    b.HasOne("ExecPetTransportBlazorAPI517.Models.Quote", "quote")
                        .WithOne("trip")
                        .HasForeignKey("ExecPetTransportBlazorAPI517.Models.Trip", "quoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("quote");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Cat", b =>
                {
                    b.Navigation("Owner");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Dog", b =>
                {
                    b.Navigation("Owner");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Quote", b =>
                {
                    b.Navigation("petowner");

                    b.Navigation("trip");
                });

            modelBuilder.Entity("ExecPetTransportBlazorAPI517.Models.Trip", b =>
                {
                    b.Navigation("TravelType");
                });
#pragma warning restore 612, 618
        }
    }
}
