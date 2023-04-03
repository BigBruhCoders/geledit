﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using geledit_server.Models;

#nullable disable

namespace geledit_server.Migrations
{
    [DbContext(typeof(GeleditContext))]
    [Migration("20230403135816_very late initial")]
    partial class verylateinitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("NoteUser", b =>
                {
                    b.Property<string>("GuestsId")
                        .HasColumnType("TEXT");

                    b.Property<long>("IsGuestInId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GuestsId", "IsGuestInId");

                    b.HasIndex("IsGuestInId");

                    b.ToTable("NoteUser");
                });

            modelBuilder.Entity("geledit_server.Models.Note", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CurrentEditorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReservedUntil")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CurrentEditorId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("geledit_server.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NoteUser", b =>
                {
                    b.HasOne("geledit_server.Models.User", null)
                        .WithMany()
                        .HasForeignKey("GuestsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("geledit_server.Models.Note", null)
                        .WithMany()
                        .HasForeignKey("IsGuestInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("geledit_server.Models.Note", b =>
                {
                    b.HasOne("geledit_server.Models.User", "CurrentEditor")
                        .WithMany()
                        .HasForeignKey("CurrentEditorId");

                    b.HasOne("geledit_server.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("geledit_server.Models.User", null)
                        .WithMany("OwnedNotes")
                        .HasForeignKey("UserId");

                    b.Navigation("CurrentEditor");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("geledit_server.Models.User", b =>
                {
                    b.Navigation("OwnedNotes");
                });
#pragma warning restore 612, 618
        }
    }
}
