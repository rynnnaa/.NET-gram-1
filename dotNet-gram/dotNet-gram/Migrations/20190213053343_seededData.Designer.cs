﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotNet_gram.Data;

namespace dotNet_gram.Migrations
{
    [DbContext(typeof(PostDbContext))]
    [Migration("20190213053343_seededData")]
    partial class seededData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dotNet_gram.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption");

                    b.Property<int>("Rating");

                    b.Property<string>("Title");

                    b.Property<string>("URL");

                    b.HasKey("ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Caption = "This is awesome!",
                            Rating = 5,
                            Title = "awesome",
                            URL = "awesome.jpg"
                        },
                        new
                        {
                            ID = 2,
                            Caption = "This is cool!",
                            Rating = 4,
                            Title = "cool",
                            URL = "cool.jpg"
                        },
                        new
                        {
                            ID = 3,
                            Caption = "This is fun!",
                            Rating = 3,
                            Title = "fun",
                            URL = "fun.jpg"
                        },
                        new
                        {
                            ID = 4,
                            Caption = "This is amazing!",
                            Rating = 5,
                            Title = "amazing",
                            URL = "amazing.jpg"
                        },
                        new
                        {
                            ID = 5,
                            Caption = "This is beautiful!",
                            Rating = 5,
                            Title = "beautiful",
                            URL = "beautiful.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
