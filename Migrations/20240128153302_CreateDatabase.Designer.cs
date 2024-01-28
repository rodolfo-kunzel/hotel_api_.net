﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hotel_api;

#nullable disable

namespace hotel_api.Migrations
{
    [DbContext(typeof(HotelApiContext))]
    [Migration("20240128153302_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("hotel_api.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCliente"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("hotel_api.ConsumoRestauranteFrigobar", b =>
                {
                    b.Property<int>("IdConsumo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConsumo"));

                    b.Property<bool>("EntregueNoQuarto")
                        .HasColumnType("bit");

                    b.Property<int>("IdFilial")
                        .HasColumnType("int");

                    b.Property<int>("IdQuarto")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoUnitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<string>("TipoConsumo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdConsumo");

                    b.ToTable("Consumos");
                });

            modelBuilder.Entity("hotel_api.Filial", b =>
                {
                    b.Property<int>("IdFilial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFilial"));

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estrelas")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroQuartosTipoA")
                        .HasColumnType("int");

                    b.Property<int>("NumeroQuartosTipoB")
                        .HasColumnType("int");

                    b.Property<int>("NumeroQuartosTipoC")
                        .HasColumnType("int");

                    b.HasKey("IdFilial");

                    b.ToTable("Filiais");
                });

            modelBuilder.Entity("hotel_api.Funcionario", b =>
                {
                    b.Property<int>("IdFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFuncionario"));

                    b.Property<int>("IdCargo")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoFuncionario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdFuncionario");

                    b.HasIndex("IdCargo");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("hotel_api.FuncionarioCargo", b =>
                {
                    b.Property<int>("IdCargo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCargo"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCargo");

                    b.ToTable("FuncionariosCargos");
                });

            modelBuilder.Entity("hotel_api.NotaFiscal", b =>
                {
                    b.Property<int>("CodigoNota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoNota"));

                    b.Property<int>("CodigoReserva")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoPagamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoNota");

                    b.HasIndex("CodigoReserva");

                    b.ToTable("NotasFiscais");
                });

            modelBuilder.Entity("hotel_api.Quarto", b =>
                {
                    b.Property<int>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Numero"));

                    b.Property<int>("Adaptado")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeMaxima")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadeOpcional")
                        .HasColumnType("int");

                    b.Property<int>("IdFilial")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoQuarto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoQuartoOpcional")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TipoQuarto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Numero");

                    b.HasIndex("IdFilial");

                    b.ToTable("Quartos");
                });

            modelBuilder.Entity("hotel_api.Reserva", b =>
                {
                    b.Property<int>("CodigoReserva")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodigoReserva"));

                    b.Property<DateTime>("DtEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DtSaida")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdFilial")
                        .HasColumnType("int");

                    b.Property<int>("IdFuncionario")
                        .HasColumnType("int");

                    b.HasKey("CodigoReserva");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdFilial");

                    b.HasIndex("IdFuncionario");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("hotel_api.ServicoLavanderia", b =>
                {
                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServico"));

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdServico");

                    b.ToTable("ServicosLavanderia");
                });

            modelBuilder.Entity("hotel_api.Funcionario", b =>
                {
                    b.HasOne("hotel_api.FuncionarioCargo", "FuncionarioCargo")
                        .WithMany()
                        .HasForeignKey("IdCargo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FuncionarioCargo");
                });

            modelBuilder.Entity("hotel_api.NotaFiscal", b =>
                {
                    b.HasOne("hotel_api.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("CodigoReserva")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("hotel_api.Quarto", b =>
                {
                    b.HasOne("hotel_api.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filial");
                });

            modelBuilder.Entity("hotel_api.Reserva", b =>
                {
                    b.HasOne("hotel_api.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotel_api.Filial", "Filial")
                        .WithMany()
                        .HasForeignKey("IdFilial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("hotel_api.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("IdFuncionario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Filial");

                    b.Navigation("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}