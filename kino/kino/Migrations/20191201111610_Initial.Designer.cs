﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kino.Data;

namespace kino.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20191201111610_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kino.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("desk");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("kino.Data.Models.Films", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("available");

                    b.Property<int>("categoryId");

                    b.Property<string>("img");

                    b.Property<bool>("isFavourite");

                    b.Property<string>("longDesk");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesk");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("kino.Data.Models.Films", b =>
                {
                    b.HasOne("kino.Data.Models.Category", "Category")
                        .WithMany("films")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
