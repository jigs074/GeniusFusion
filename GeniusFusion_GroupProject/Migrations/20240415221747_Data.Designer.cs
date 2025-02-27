﻿// <auto-generated />
using System;
using GeniusFusion_GroupProject.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeniusFusion_GroupProject.Migrations
{
    [DbContext(typeof(GeniusFusionDbContext))]
    [Migration("20240415221747_Data")]
    partial class Data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.AdminCredentials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Enterprise Application Development",
                            FacultyId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Software Quality",
                            FacultyId = 2
                        });
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Enrollment", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("EnrollmentId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            StudentId = 1,
                            EnrollmentId = 1
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 1,
                            EnrollmentId = 2
                        },
                        new
                        {
                            CourseId = 1,
                            StudentId = 2,
                            EnrollmentId = 3
                        },
                        new
                        {
                            CourseId = 2,
                            StudentId = 2,
                            EnrollmentId = 4
                        });
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Faculty", b =>
                {
                    b.Property<int>("FacultyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacultyId"));

                    b.Property<string>("FacultyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacultyEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacultyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacultyPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.HasKey("FacultyId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            FacultyId = 1,
                            FacultyAddress = "Waterloo, ON",
                            FacultyEmail = "peter@geniusFusion.edu",
                            FacultyName = "Peter Mazdiak",
                            FacultyPhone = "1234567890",
                            dateOfBirth = new DateTime(1985, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            FacultyId = 2,
                            FacultyAddress = "Kitchener, ON",
                            FacultyEmail = "Eliott@geniusFusion.edu",
                            FacultyName = "Eliott Coleshill",
                            FacultyPhone = "2223334465",
                            dateOfBirth = new DateTime(1999, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.FacultyCredentials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("facultyCredentials");
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Student", b =>
                {
                    b.Property<int?>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("StudentId"));

                    b.Property<string>("StudentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            StudentAddress = "Waterloo, ON",
                            StudentEmail = "Bob@geniusfusion.edu",
                            StudentName = "Bob Martin",
                            StudentPhone = "3336664478",
                            dateOfBirth = new DateTime(2002, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            StudentId = 2,
                            StudentAddress = "Kitchener, ON",
                            StudentEmail = "Jake@geniusfusion.edu",
                            StudentName = "Jake Alace",
                            StudentPhone = "4445557789",
                            dateOfBirth = new DateTime(2001, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.StudentCredentials", b =>
                {
                    b.Property<int>("StudentCredentialsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentCredentialsId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentCredentialsId");

                    b.ToTable("StudentCredentials");
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Course", b =>
                {
                    b.HasOne("GeniusFusion_GroupProject.Entities.Faculty", "Faculty")
                        .WithMany("CoursesTaught")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Enrollment", b =>
                {
                    b.HasOne("GeniusFusion_GroupProject.Entities.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GeniusFusion_GroupProject.Entities.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Faculty", b =>
                {
                    b.Navigation("CoursesTaught");
                });

            modelBuilder.Entity("GeniusFusion_GroupProject.Entities.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
