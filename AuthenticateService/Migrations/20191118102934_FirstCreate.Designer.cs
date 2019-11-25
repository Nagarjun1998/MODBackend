﻿// <auto-generated />
using System;
using AuthenticateService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthenticateService.Migrations
{
    [DbContext(typeof(LoginContext))]
    [Migration("20191118102934_FirstCreate")]
    partial class FirstCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthenticateService.Models.MentorDtl", b =>
                {
                    b.Property<string>("MentorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MentorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technologies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeSlot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("YearsOfExperience")
                        .HasColumnType("int");

                    b.Property<string>("linkedInUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MentorId");

                    b.ToTable("Mentordtl");
                });

            modelBuilder.Entity("AuthenticateService.Models.Userdtl", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Userdtl");
                });
#pragma warning restore 612, 618
        }
    }
}