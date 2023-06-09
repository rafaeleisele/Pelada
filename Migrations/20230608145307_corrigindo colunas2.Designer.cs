﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pelada.Data;

#nullable disable

namespace Pelada.Migrations
{
    [DbContext(typeof(PeladaContext))]
    [Migration("20230608145307_corrigindo colunas2")]
    partial class corrigindocolunas2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pelada.Data.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdTime")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.Property<int?>("TimeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TimeId");

                    b.ToTable("jogadores");
                });

            modelBuilder.Entity("Pelada.Data.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("times");
                });

            modelBuilder.Entity("Pelada.Data.Jogador", b =>
                {
                    b.HasOne("Pelada.Data.Time", "Time")
                        .WithMany("Jogadores")
                        .HasForeignKey("TimeId");

                    b.Navigation("Time");
                });

            modelBuilder.Entity("Pelada.Data.Time", b =>
                {
                    b.Navigation("Jogadores");
                });
#pragma warning restore 612, 618
        }
    }
}
