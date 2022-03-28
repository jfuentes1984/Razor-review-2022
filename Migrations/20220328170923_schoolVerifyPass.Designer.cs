﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Razor_review_2022.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220328170923_schoolVerifyPass")]
    partial class schoolVerifyPass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Razor_review_2022.Model.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Razor_review_2022.Model.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("Province")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .HasColumnType("longtext");

                    b.Property<int?>("StreetNumber")
                        .HasColumnType("int");

                    b.HasKey("SchoolId");

                    b.ToTable("School");
                });

            modelBuilder.Entity("Razor_review_2022.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("First")
                        .HasColumnType("longtext");

                    b.Property<string>("Last")
                        .HasColumnType("longtext");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Razor_review_2022.Model.Class", b =>
                {
                    b.HasOne("Razor_review_2022.Model.School", "School")
                        .WithMany("AvailableClasses")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("Razor_review_2022.Model.School", b =>
                {
                    b.Navigation("AvailableClasses");
                });
#pragma warning restore 612, 618
        }
    }
}