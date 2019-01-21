﻿// <auto-generated />
using Furzify.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Furzify.API.Migrations
{
    [DbContext(typeof(FurzeContext))]
    partial class FurzeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Furzify.API.Entities.Band", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AppleMusic");

                    b.Property<string>("Bandcamp");

                    b.Property<string>("Facebook");

                    b.Property<string>("Instagram");

                    b.Property<string>("Name");

                    b.Property<string>("ReverbNation");

                    b.Property<string>("SoundCloud");

                    b.Property<string>("Spotify");

                    b.Property<string>("Twitter");

                    b.Property<string>("Website");

                    b.Property<string>("YouTube");

                    b.HasKey("Id");

                    b.ToTable("Bands");
                });
#pragma warning restore 612, 618
        }
    }
}
