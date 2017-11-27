using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Clothing.Entities;

namespace Clothing.Migrations
{
    [DbContext(typeof(ClothContext))]
    partial class ClothContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Clothing.Models.Clothes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("category");

                    b.Property<string>("item_name");

                    b.Property<string>("manufacturer");

                    b.Property<string>("size");

                    b.Property<double>("unit_price");

                    b.HasKey("Id");

                    b.ToTable("warehouse");
                });
        }
    }
}
