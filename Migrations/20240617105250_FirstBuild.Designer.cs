﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using machinist.Data;

#nullable disable

namespace machinist.Migrations
{
    [DbContext(typeof(MachineContext))]
    [Migration("20240617105250_FirstBuild")]
    partial class FirstBuild
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("machinist.Models.Commando", b =>
                {
                    b.Property<int>("CommandoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ExeTime")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MachineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CommandoId");

                    b.HasIndex("MachineId");

                    b.ToTable("Commando");
                });

            modelBuilder.Entity("machinist.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("machinist.Models.Machine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MachineId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomNr")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("StatusChanged")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("machinist.Models.Commando", b =>
                {
                    b.HasOne("machinist.Models.Machine", "Machine")
                        .WithMany("Commandos")
                        .HasForeignKey("MachineId");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("machinist.Models.Machine", b =>
                {
                    b.HasOne("machinist.Models.Company", "Company")
                        .WithMany("Machines")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("machinist.Models.Company", b =>
                {
                    b.Navigation("Machines");
                });

            modelBuilder.Entity("machinist.Models.Machine", b =>
                {
                    b.Navigation("Commandos");
                });
#pragma warning restore 612, 618
        }
    }
}
