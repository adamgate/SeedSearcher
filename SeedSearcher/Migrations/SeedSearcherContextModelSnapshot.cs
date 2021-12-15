﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeedSearcher.Data;

namespace SeedSearcher.Migrations
{
    [DbContext(typeof(SeedSearcherContext))]
    partial class SeedSearcherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeedSearcher.Models.Bird", b =>
                {
                    b.Property<int>("BirdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommonName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Habitat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScientificName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blurb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("BirdId");

                    b.ToTable("Bird");
                });
#pragma warning restore 612, 618
        }
    }
}