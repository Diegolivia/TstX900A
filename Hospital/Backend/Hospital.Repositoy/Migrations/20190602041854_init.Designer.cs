﻿// <auto-generated />
using Hospital.Repositoy.dbcontext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Hospital.Repositoy.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190602041854_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Hospital.Entity.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<int>("PacienteId");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("Hospital.Entity.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos");

                    b.Property<string>("Direccion");

                    b.Property<string>("Dni");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnName("Nombres")
                        .HasMaxLength(50);

                    b.Property<string>("Telefono");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Hospital.Entity.Consulta", b =>
                {
                    b.HasOne("Hospital.Entity.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
