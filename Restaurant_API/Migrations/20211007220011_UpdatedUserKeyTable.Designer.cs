﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Restaurant_API;

namespace Restaurant_API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211007220011_UpdatedUserKeyTable")]
    partial class UpdatedUserKeyTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Restaurant_API.Models.Table", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("userID")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("userID");

                    b.ToTable("tables");
                });

            modelBuilder.Entity("Restaurant_API.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("login")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<int>("tableID")
                        .HasColumnType("integer");

                    b.Property<int?>("userID")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("userID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Restaurant_API.Models.Table", b =>
                {
                    b.HasOne("Restaurant_API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Restaurant_API.Models.User", b =>
                {
                    b.HasOne("Restaurant_API.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("userID");

                    b.Navigation("Table");
                });
#pragma warning restore 612, 618
        }
    }
}
