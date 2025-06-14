﻿// <auto-generated />
using System;
using CarStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250519232058_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.35");

            modelBuilder.Entity("CarStore.Models.Carro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Chassi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Preco")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Carros");
                });

            modelBuilder.Entity("CarStore.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("CarStore.Models.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarroId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompradorId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Garantia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("TEXT");

                    b.Property<int>("VendedorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CarroId");

                    b.HasIndex("CompradorId");

                    b.HasIndex("VendedorId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("CarStore.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Salario")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("CarStore.Models.Nota", b =>
                {
                    b.HasOne("CarStore.Models.Carro", "Carro")
                        .WithMany("Notas")
                        .HasForeignKey("CarroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarStore.Models.Cliente", "Comprador")
                        .WithMany("Notas")
                        .HasForeignKey("CompradorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarStore.Models.Vendedor", "Vendedor")
                        .WithMany("Notas")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");

                    b.Navigation("Comprador");

                    b.Navigation("Vendedor");
                });

            modelBuilder.Entity("CarStore.Models.Carro", b =>
                {
                    b.Navigation("Notas");
                });

            modelBuilder.Entity("CarStore.Models.Cliente", b =>
                {
                    b.Navigation("Notas");
                });

            modelBuilder.Entity("CarStore.Models.Vendedor", b =>
                {
                    b.Navigation("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
