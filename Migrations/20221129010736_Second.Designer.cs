﻿// <auto-generated />
using GradesBooks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GradesBooks.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20221129010736_Second")]
    partial class Second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GradesBooks.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<decimal>("GradePercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 15783,
                            GradePercent = 88m,
                            Name = "Rodrigo Nogueira"
                        },
                        new
                        {
                            StudentId = 27689,
                            GradePercent = 90m,
                            Name = "John Walker"
                        },
                        new
                        {
                            StudentId = 31659,
                            GradePercent = 72m,
                            Name = "Mel Gibson"
                        },
                        new
                        {
                            StudentId = 42578,
                            GradePercent = 56m,
                            Name = "Mary Johnson"
                        },
                        new
                        {
                            StudentId = 50116,
                            GradePercent = 90m,
                            Name = "Kylie Jenner"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
