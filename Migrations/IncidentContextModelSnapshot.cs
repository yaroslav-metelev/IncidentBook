﻿// <auto-generated />
using System;
using IncidentBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IncidentBook.Migrations
{
    [DbContext(typeof(IncidentContext))]
    partial class IncidentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("IncidentBook.Models.ClientItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ClientItems");
                });

            modelBuilder.Entity("IncidentBook.Models.ClosedIncidentsItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Resolution")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ClosedIncidentsItems");
                });

            modelBuilder.Entity("IncidentBook.Models.IncidentClassification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClassificationName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("IncidentClassifications");
                });

            modelBuilder.Entity("IncidentBook.Models.IncidentItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Classification")
                        .HasColumnType("text");

                    b.Property<int>("Client")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("boolean");

                    b.Property<string>("Resolution")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Client");

                    b.ToTable("TodoItems");
                });

            modelBuilder.Entity("IncidentBook.Models.IncidentItem", b =>
                {
                    b.HasOne("IncidentBook.Models.ClientItem", "ClientItem")
                        .WithMany()
                        .HasForeignKey("Client")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientItem");
                });
#pragma warning restore 612, 618
        }
    }
}
