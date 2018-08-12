﻿// <auto-generated />
using CellPhones.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CellPhones.Migrations
{
    [DbContext(typeof(CellPhonesContext))]
    partial class CellPhonesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CellPhones.Models.Cellphone", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Make");

                    b.Property<string>("Memory");

                    b.Property<string>("Model");

                    b.Property<string>("OS");

                    b.Property<bool>("Prepaid");

                    b.Property<decimal>("Price");

                    b.Property<string>("ScreenSize");

                    b.HasKey("ID");

                    b.ToTable("Cellphone");
                });
#pragma warning restore 612, 618
        }
    }
}
