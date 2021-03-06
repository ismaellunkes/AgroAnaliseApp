﻿// <auto-generated />
using System;
using AgroAnaliseApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgroAnaliseApp.Migrations
{
    [DbContext(typeof(AgroAnaliseAppContext))]
    [Migration("20200111183538_sqlserver002")]
    partial class sqlserver002
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgroAnaliseApp.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("Coordinates")
                        .IsRequired();

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2")
                        .IsRequired();

                    b.Property<string>("ZipCode")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("State");

                    b.HasKey("Id");

                    b.ToTable("Citys");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("DocumentLocale");

                    b.Property<int>("DocumentType");

                    b.Property<int?>("FarmId2");

                    b.Property<int?>("FarmerId");

                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.Property<DateTime>("Validity");

                    b.HasKey("Id");

                    b.HasIndex("FarmId2");

                    b.HasIndex("FarmerId");

                    b.ToTable("Documents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Document");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<int>("FarmerId");

                    b.Property<DateTime>("RegistryDate");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("FarmerId");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BornDate");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name");

                    b.Property<DateTime>("RegistryDate");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Analysis", b =>
                {
                    b.HasBaseType("AgroAnaliseApp.Models.Document");

                    b.Property<int>("FarmId");

                    b.HasIndex("FarmId");

                    b.ToTable("Analysis");

                    b.HasDiscriminator().HasValue("Analysis");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Farmer", b =>
                {
                    b.HasBaseType("AgroAnaliseApp.Models.Person");


                    b.ToTable("Farmer");

                    b.HasDiscriminator().HasValue("Farmer");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Address", b =>
                {
                    b.HasOne("AgroAnaliseApp.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Document", b =>
                {
                    b.HasOne("AgroAnaliseApp.Models.Farm")
                        .WithMany("Documents")
                        .HasForeignKey("FarmId2");

                    b.HasOne("AgroAnaliseApp.Models.Farmer")
                        .WithMany("Documents")
                        .HasForeignKey("FarmerId");
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Farm", b =>
                {
                    b.HasOne("AgroAnaliseApp.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AgroAnaliseApp.Models.Farmer", "Farmer")
                        .WithMany()
                        .HasForeignKey("FarmerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgroAnaliseApp.Models.Analysis", b =>
                {
                    b.HasOne("AgroAnaliseApp.Models.Farm", "Farm")
                        .WithMany()
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
