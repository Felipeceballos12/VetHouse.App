﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetHouse.App.Persistencia;

namespace VetHouse.App.Persistencia.Migrations
{
    [DbContext(typeof(AppVetHouseContext))]
    partial class AppVetHouseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VetHouse.App.Dominio.CareSuggestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAtCareSuggestion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoryId");

                    b.ToTable("CareSuggestions");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAtHistory")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnose")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Histories");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AuxVetId")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int?>("HistoryId")
                        .HasColumnType("int");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("VetId")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("AuxVetId");

                    b.HasIndex("HistoryId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("VetId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.VitalSign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("BreathingFreq")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreatedAtVitalSign")
                        .HasColumnType("datetime2");

                    b.Property<int>("HealthStatus")
                        .HasColumnType("int");

                    b.Property<float>("HeartRate")
                        .HasColumnType("real");

                    b.Property<int?>("HistoryId")
                        .HasColumnType("int");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("HistoryId");

                    b.ToTable("VitalSigns");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.AuxVet", b =>
                {
                    b.HasBaseType("VetHouse.App.Dominio.Person");

                    b.Property<int>("LaborHours")
                        .HasColumnType("int");

                    b.Property<string>("ProfessionalCard")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AuxVet");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.Owner", b =>
                {
                    b.HasBaseType("VetHouse.App.Dominio.Person");

                    b.HasDiscriminator().HasValue("Owner");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.Vet", b =>
                {
                    b.HasBaseType("VetHouse.App.Dominio.Person");

                    b.Property<string>("RegisterRethus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Vet");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.CareSuggestion", b =>
                {
                    b.HasOne("VetHouse.App.Dominio.History", null)
                        .WithMany("CareSuggestions")
                        .HasForeignKey("HistoryId");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.Pet", b =>
                {
                    b.HasOne("VetHouse.App.Dominio.AuxVet", "AuxVet")
                        .WithMany()
                        .HasForeignKey("AuxVetId");

                    b.HasOne("VetHouse.App.Dominio.History", "History")
                        .WithMany()
                        .HasForeignKey("HistoryId");

                    b.HasOne("VetHouse.App.Dominio.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("VetHouse.App.Dominio.Vet", null)
                        .WithMany("Pets")
                        .HasForeignKey("VetId");

                    b.Navigation("AuxVet");

                    b.Navigation("History");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.VitalSign", b =>
                {
                    b.HasOne("VetHouse.App.Dominio.History", null)
                        .WithMany("VitalSigns")
                        .HasForeignKey("HistoryId");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.History", b =>
                {
                    b.Navigation("CareSuggestions");

                    b.Navigation("VitalSigns");
                });

            modelBuilder.Entity("VetHouse.App.Dominio.Vet", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
