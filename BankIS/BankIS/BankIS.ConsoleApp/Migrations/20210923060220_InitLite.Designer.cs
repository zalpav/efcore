﻿// <auto-generated />
using System;
using BankIS.ConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankIS.ConsoleApp.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20210923060220_InitLite")]
    partial class InitLite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19");

            modelBuilder.Entity("BankIS.ConsoleApp.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("ZipCode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Adressess");
                });

            modelBuilder.Entity("BankIS.ConsoleApp.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("HomeAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HomeAddressId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BankIS.ConsoleApp.Client", b =>
                {
                    b.HasOne("BankIS.ConsoleApp.Address", "HomeAddress")
                        .WithMany()
                        .HasForeignKey("HomeAddressId");
                });
#pragma warning restore 612, 618
        }
    }
}