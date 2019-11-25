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
    [Migration("20191123095243_authecreate")]
    partial class authecreate
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

            modelBuilder.Entity("AuthenticateService.Models.Payment", b =>
                {
                    b.Property<string>("PaymentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("AmountToMentor")
                        .HasColumnType("float");

                    b.Property<string>("MentorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrainingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.HasKey("PaymentId");

                    b.HasIndex("MentorId");

                    b.HasIndex("TrainingId");

                    b.HasIndex("UserId");

                    b.ToTable("Paymentdtl");
                });

            modelBuilder.Entity("AuthenticateService.Models.Skill", b =>
                {
                    b.Property<string>("SkillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("fees")
                        .HasColumnType("int");

                    b.Property<string>("prerequisites")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("toc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("AuthenticateService.Models.Training", b =>
                {
                    b.Property<string>("TrainingId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MentorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SkillId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TrainingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("paymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("progress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("rejectNotify")
                        .HasColumnType("bit");

                    b.Property<bool?>("requested")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingId");

                    b.HasIndex("MentorId");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("Training");
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

            modelBuilder.Entity("AuthenticateService.Models.Payment", b =>
                {
                    b.HasOne("AuthenticateService.Models.MentorDtl", "MentorDtl")
                        .WithMany("Payments")
                        .HasForeignKey("MentorId");

                    b.HasOne("AuthenticateService.Models.Training", "Training")
                        .WithMany("Payments")
                        .HasForeignKey("TrainingId");

                    b.HasOne("AuthenticateService.Models.Userdtl", "Userdtl")
                        .WithMany("Payments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AuthenticateService.Models.Training", b =>
                {
                    b.HasOne("AuthenticateService.Models.MentorDtl", "MentorDtl")
                        .WithMany("Trainings")
                        .HasForeignKey("MentorId");

                    b.HasOne("AuthenticateService.Models.Skill", "Skill")
                        .WithMany("Trainings")
                        .HasForeignKey("SkillId");

                    b.HasOne("AuthenticateService.Models.Userdtl", "Userdtl")
                        .WithMany("Trainings")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
