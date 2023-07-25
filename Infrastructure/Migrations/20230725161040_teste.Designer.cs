﻿// <auto-generated />
using Infrastructure.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(UrlContext))]
    [Migration("20230725161040_teste")]
    partial class teste
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.MottuUrl", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<int>("Hits")
                        .HasColumnType("integer")
                        .HasAnnotation("Relational:JsonPropertyName", "hits");

                    b.Property<string>("ShortUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "shortUrl");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasAnnotation("Relational:JsonPropertyName", "url");

                    b.HasKey("Id");

                    b.ToTable("Url");
                });
#pragma warning restore 612, 618
        }
    }
}
