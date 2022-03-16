﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dacon_exam.Models;

namespace dacon_exam.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dacon_exam.Models.Cml", b =>
                {
                    b.Property<int>("cml_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("actual_outside_diameter")
                        .HasColumnType("float");

                    b.Property<string>("cml_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cml_number")
                        .HasColumnType("int");

                    b.Property<double>("design_thickness")
                        .HasColumnType("float");

                    b.Property<int>("info_id")
                        .HasColumnType("int");

                    b.Property<double>("required_thickness")
                        .HasColumnType("float");

                    b.Property<double>("structural_thickness")
                        .HasColumnType("float");

                    b.HasKey("cml_id");

                    b.HasIndex("info_id");

                    b.ToTable("CML", "dbo");
                });

            modelBuilder.Entity("dacon_exam.Models.Info", b =>
                {
                    b.Property<int>("Info_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ca")
                        .HasColumnType("int");

                    b.Property<int>("design_life")
                        .HasColumnType("int");

                    b.Property<int>("design_pressure")
                        .HasColumnType("int");

                    b.Property<int>("design_temperature")
                        .HasColumnType("int");

                    b.Property<string>("drawing_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("from")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("inservice_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("joint_efficiency")
                        .HasColumnType("int");

                    b.Property<string>("line_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("operating_pressure")
                        .HasColumnType("int");

                    b.Property<double>("operating_temperature")
                        .HasColumnType("float");

                    b.Property<double>("original_thickness")
                        .HasColumnType("float");

                    b.Property<double>("pipe_size")
                        .HasColumnType("float");

                    b.Property<string>("service")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stress")
                        .HasColumnType("int");

                    b.Property<string>("to")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Info_id");

                    b.ToTable("INFO", "dbo");
                });

            modelBuilder.Entity("dacon_exam.Models.TestPoint", b =>
                {
                    b.Property<int>("tp_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cml_id")
                        .HasColumnType("int");

                    b.Property<string>("line_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tp_description")
                        .HasColumnType("int");

                    b.Property<int>("tp_number")
                        .HasColumnType("int");

                    b.HasKey("tp_id");

                    b.HasIndex("cml_id");

                    b.ToTable("TEST_POINT", "dbo");
                });

            modelBuilder.Entity("dacon_exam.Models.Thickness", b =>
                {
                    b.Property<int>("thickness_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("actual_thickness")
                        .HasColumnType("float");

                    b.Property<int>("cml_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("inspection_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("line_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tp_number")
                        .HasColumnType("int");

                    b.HasKey("thickness_id");

                    b.HasIndex("tp_number");

                    b.ToTable("THICKNESS", "dbo");
                });

            modelBuilder.Entity("dacon_exam.Models.Cml", b =>
                {
                    b.HasOne("dacon_exam.Models.Info", "info_fk")
                        .WithMany()
                        .HasForeignKey("info_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("info_fk");
                });

            modelBuilder.Entity("dacon_exam.Models.TestPoint", b =>
                {
                    b.HasOne("dacon_exam.Models.Cml", "cml_fk")
                        .WithMany()
                        .HasForeignKey("cml_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cml_fk");
                });

            modelBuilder.Entity("dacon_exam.Models.Thickness", b =>
                {
                    b.HasOne("dacon_exam.Models.TestPoint", "tp_number_fk")
                        .WithMany()
                        .HasForeignKey("tp_number")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tp_number_fk");
                });
#pragma warning restore 612, 618
        }
    }
}
