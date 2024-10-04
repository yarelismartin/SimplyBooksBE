﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SimplyBooks;

#nullable disable

namespace SimplyBooks.Migrations
{
    [DbContext(typeof(SimplyBooksDbContext))]
    [Migration("20241004142545_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SimplyBooks.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Favorite")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "george.orwell@example.com",
                            Favorite = true,
                            FirstName = "George",
                            Image = "orwell.jpg",
                            LastName = "Orwell",
                            Uid = "UID001"
                        },
                        new
                        {
                            Id = 2,
                            Email = "jk.rowling@example.com",
                            Favorite = true,
                            FirstName = "J.K.",
                            Image = "rowling.jpg",
                            LastName = "Rowling",
                            Uid = "UID002"
                        },
                        new
                        {
                            Id = 3,
                            Email = "agatha.christie@example.com",
                            Favorite = false,
                            FirstName = "Agatha",
                            Image = "christie.jpg",
                            LastName = "Christie",
                            Uid = "UID003"
                        },
                        new
                        {
                            Id = 4,
                            Email = "mark.twain@example.com",
                            Favorite = false,
                            FirstName = "Mark",
                            Image = "twain.jpg",
                            LastName = "Twain",
                            Uid = "UID004"
                        },
                        new
                        {
                            Id = 5,
                            Email = "f.scott.fitzgerald@example.com",
                            Favorite = true,
                            FirstName = "F. Scott",
                            Image = "fitzgerald.jpg",
                            LastName = "Fitzgerald",
                            Uid = "UID005"
                        });
                });

            modelBuilder.Entity("SimplyBooks.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<bool>("Sale")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uid")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "A dystopian novel set in a totalitarian society ruled by Big Brother.",
                            Image = "1984.jpg",
                            Price = 14.99m,
                            Sale = true,
                            Title = "1984",
                            Uid = "BID001"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "A political satire that allegorizes the rise of Stalinism.",
                            Image = "animal_farm.jpg",
                            Price = 9.99m,
                            Sale = false,
                            Title = "Animal Farm",
                            Uid = "BID002"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Description = "The first book in the Harry Potter series about a young wizard.",
                            Image = "hp_sorcerer_stone.jpg",
                            Price = 12.99m,
                            Sale = false,
                            Title = "Harry Potter and the Sorcerer's Stone",
                            Uid = "BID003"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 2,
                            Description = "The second book in the Harry Potter series.",
                            Image = "hp_chamber_secrets.jpg",
                            Price = 13.99m,
                            Sale = true,
                            Title = "Harry Potter and the Chamber of Secrets",
                            Uid = "BID004"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 3,
                            Description = "A famous detective novel featuring Hercule Poirot.",
                            Image = "orient_express.jpg",
                            Price = 11.99m,
                            Sale = false,
                            Title = "Murder on the Orient Express",
                            Uid = "BID005"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 3,
                            Description = "Another thrilling mystery from Agatha Christie.",
                            Image = "abc_murders.jpg",
                            Price = 10.99m,
                            Sale = true,
                            Title = "The ABC Murders",
                            Uid = "BID006"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 4,
                            Description = "A novel about the adventures of Huck Finn along the Mississippi River.",
                            Image = "huck_finn.jpg",
                            Price = 8.99m,
                            Sale = false,
                            Title = "The Adventures of Huckleberry Finn",
                            Uid = "BID007"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 4,
                            Description = "A story about the mischievous adventures of Tom Sawyer.",
                            Image = "tom_sawyer.jpg",
                            Price = 7.99m,
                            Sale = true,
                            Title = "The Adventures of Tom Sawyer",
                            Uid = "BID008"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 5,
                            Description = "A novel about the mysterious Jay Gatsby and his love for Daisy Buchanan.",
                            Image = "gatsby.jpg",
                            Price = 10.99m,
                            Sale = true,
                            Title = "The Great Gatsby",
                            Uid = "BID009"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 5,
                            Description = "A novel about the rise and fall of a glamorous American couple.",
                            Image = "tender_night.jpg",
                            Price = 12.49m,
                            Sale = false,
                            Title = "Tender Is the Night",
                            Uid = "BID010"
                        });
                });

            modelBuilder.Entity("SimplyBooks.Models.Book", b =>
                {
                    b.HasOne("SimplyBooks.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("SimplyBooks.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
