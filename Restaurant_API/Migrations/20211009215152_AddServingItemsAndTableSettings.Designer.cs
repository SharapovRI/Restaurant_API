﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Restaurant_API;

namespace Restaurant_API.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211009215152_AddServingItemsAndTableSettings")]
    partial class AddServingItemsAndTableSettings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Restaurant_API.Models.Dish", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("dishes");
                });

            modelBuilder.Entity("Restaurant_API.Models.Portion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("dish_id")
                        .HasColumnType("integer");

                    b.Property<int>("table_id")
                        .HasColumnType("integer");

                    b.Property<int>("weight")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("dish_id");

                    b.HasIndex("table_id");

                    b.ToTable("portions");
                });

            modelBuilder.Entity("Restaurant_API.Models.ServingItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("serving_items");
                });

            modelBuilder.Entity("Restaurant_API.Models.Table", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("table_name")
                        .HasColumnType("text");

                    b.Property<int>("user_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("tables");
                });

            modelBuilder.Entity("Restaurant_API.Models.TableSetting", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("serving_item_id")
                        .HasColumnType("integer");

                    b.Property<int>("table_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("serving_item_id");

                    b.HasIndex("table_id");

                    b.ToTable("table_settings");
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

                    b.Property<int>("table_id")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("table_id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Restaurant_API.Models.Portion", b =>
                {
                    b.HasOne("Restaurant_API.Models.Dish", "Dish")
                        .WithMany("Portions")
                        .HasForeignKey("dish_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant_API.Models.Table", "Table")
                        .WithMany("Portions")
                        .HasForeignKey("table_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Restaurant_API.Models.Table", b =>
                {
                    b.HasOne("Restaurant_API.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Restaurant_API.Models.TableSetting", b =>
                {
                    b.HasOne("Restaurant_API.Models.ServingItem", "ServingItem")
                        .WithMany("TableSettings")
                        .HasForeignKey("serving_item_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant_API.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("table_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServingItem");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Restaurant_API.Models.User", b =>
                {
                    b.HasOne("Restaurant_API.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("table_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Restaurant_API.Models.Dish", b =>
                {
                    b.Navigation("Portions");
                });

            modelBuilder.Entity("Restaurant_API.Models.ServingItem", b =>
                {
                    b.Navigation("TableSettings");
                });

            modelBuilder.Entity("Restaurant_API.Models.Table", b =>
                {
                    b.Navigation("Portions");
                });
#pragma warning restore 612, 618
        }
    }
}