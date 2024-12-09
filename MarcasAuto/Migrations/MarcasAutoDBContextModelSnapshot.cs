﻿// <auto-generated />
using MarcasAuto.Infraestructure.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MarcasAuto.Migrations
{
    [DbContext(typeof(MarcasAutoDBContext))]
    partial class MarcasAutoDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MarcasAuto.Domain.Entities.MarcasAutoEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("MarcasAuto", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8901d8dd-24b0-4f56-a523-6d6694b9a4ac",
                            Make = "Toyota"
                        },
                        new
                        {
                            Id = "91de0725-5e4d-49af-b63d-1dfc6b7699c9",
                            Make = "Ford"
                        },
                        new
                        {
                            Id = "ff5425c0-ed1d-422d-ad1d-47a1e5f8b8f1",
                            Make = "Chevrolet"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
