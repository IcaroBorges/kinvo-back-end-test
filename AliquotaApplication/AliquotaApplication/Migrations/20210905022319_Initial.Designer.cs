﻿// <auto-generated />
using System;
using Aliquota.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AliquotaApplication.Migrations
{
    [DbContext(typeof(AliquotaContext))]
    [Migration("20210905022319_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aliquota.Domain.Cliente", b =>
                {
                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DataDeAplicacao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ValorAplicado")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Nome");

                    b.ToTable("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
