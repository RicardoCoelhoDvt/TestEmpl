﻿// <auto-generated />
using APICore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APICore.Migrations
{
    [DbContext(typeof(EmpContext))]
    partial class EmpContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APICore.Models.Empregados", b =>
                {
                    b.Property<int>("EmpregadoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Chapa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CorportionEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirsNameEmpl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastNameEmpl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LeaderEmpl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeaderID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpregadoID");

                    b.ToTable("Empregados");
                });
#pragma warning restore 612, 618
        }
    }
}