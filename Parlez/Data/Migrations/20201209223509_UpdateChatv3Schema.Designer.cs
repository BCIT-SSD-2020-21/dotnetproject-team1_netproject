﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parlez.Data;

namespace Parlez.Data.Migrations
{
    [DbContext(typeof(ChatDbContext))]
    [Migration("20201209223509_UpdateChatv3Schema")]
    partial class UpdateChatv3Schema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parlez.Models.MessageRating", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MessageId");

                    b.HasIndex("MessageId");

                    b.ToTable("MessageRating");
                });

            modelBuilder.Entity("Parlez.Models.Messages", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MessageText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            UserId = 2,
                            CreatedOn = new DateTime(2020, 12, 9, 14, 35, 8, 846, DateTimeKind.Local).AddTicks(8219),
                            MessageId = 1,
                            MessageText = "How are you?"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedOn = new DateTime(2020, 12, 9, 14, 35, 8, 850, DateTimeKind.Local).AddTicks(3487),
                            MessageId = 2,
                            MessageText = "WasUp?"
                        });
                });

            modelBuilder.Entity("Parlez.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "test1@test.com",
                            FirstName = "TestFirst1",
                            ImageUri = "img/pic1",
                            IsAdmin = true,
                            LastName = "TestLast1",
                            Username = "TestUser1"
                        },
                        new
                        {
                            UserId = 2,
                            Email = "test2@test.com",
                            FirstName = "TestFirst2",
                            ImageUri = "img/pic2",
                            IsAdmin = true,
                            LastName = "TestLast2",
                            Username = "TestUser2"
                        },
                        new
                        {
                            UserId = 3,
                            Email = "test3@test.com",
                            FirstName = "TestFirst3",
                            ImageUri = "img/pic3",
                            IsAdmin = false,
                            LastName = "TestLast3",
                            Username = "TestUser3"
                        });
                });

            modelBuilder.Entity("Parlez.Models.MessageRating", b =>
                {
                    b.HasOne("Parlez.Models.Messages", "Messages")
                        .WithMany("MessageRatings")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Parlez.Models.Users", "Users")
                        .WithMany("MessageRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parlez.Models.Messages", b =>
                {
                    b.HasOne("Parlez.Models.Users", "Users")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}