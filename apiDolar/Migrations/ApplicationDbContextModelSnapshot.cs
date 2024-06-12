﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiDolar.Data;

#nullable disable

namespace apiDolar.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("apiDolar.Models.Exportacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("fechaRegistrada")
                        .HasColumnType("date");

                    b.Property<int>("kilos")
                        .HasColumnType("int");

                    b.Property<string>("nombreProducto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("precioActualDolar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("exportacion");
                });
#pragma warning restore 612, 618
        }
    }
}
