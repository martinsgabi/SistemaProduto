﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaProduto.Models;

#nullable disable

namespace SistemaProduto.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231205120319_CriacaoNova")]
    partial class CriacaoNova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SistemaProduto.Models.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CidadeNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CidadeNome");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("SistemaProduto.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BairroCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BairroCliente");

                    b.Property<int>("CidadeId")
                        .HasColumnType("int");

                    b.Property<string>("ClienteCpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteCpf");

                    b.Property<DateTime>("ClienteDataNascimento")
                        .HasColumnType("datetime2")
                        .HasColumnName("ClienteDataNascimento");

                    b.Property<string>("ClienteEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteEndereco");

                    b.Property<string>("ClienteNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClienteNome");

                    b.Property<string>("NumeroCasaCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NumeroCasaCliente");

                    b.Property<string>("TelefoneCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TelefoneCliente");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("SistemaProduto.Models.EntradaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataEntrada")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataEntrada");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeEntrada")
                        .HasColumnType("int")
                        .HasColumnName("QuantidadeEntrada");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("EntradaProduto");
                });

            modelBuilder.Entity("SistemaProduto.Models.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EstadoNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EstadoNome");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("SistemaProduto.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FornecedorCnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FornecedorCnpj");

                    b.Property<string>("FornecedorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FornecedorEmail");

                    b.Property<string>("FornecedorNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FornecedorNome");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("SistemaProduto.Models.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PaisNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PaisNome");

                    b.HasKey("Id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("SistemaProduto.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("ProdutoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ProdutoNome");

                    b.Property<string>("QuantidadeEstoque")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("QuantidadeEstoque");

                    b.Property<int>("TipoProdutoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("TipoProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("SistemaProduto.Models.SaidaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataSaida")
                        .HasColumnType("datetime2")
                        .HasColumnName("DataSaida");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("QuantidadeSaida")
                        .HasColumnType("int")
                        .HasColumnName("QuantidadeSaida");

                    b.Property<int>("TipoSaidaId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("TipoSaidaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("SaidaProduto");
                });

            modelBuilder.Entity("SistemaProduto.Models.TipoProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoProdutoDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoProdutoDescricao");

                    b.HasKey("Id");

                    b.ToTable("TipoProduto");
                });

            modelBuilder.Entity("SistemaProduto.Models.TipoSaida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TipoSaidaDescricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TipoSaidaDescricao");

                    b.HasKey("Id");

                    b.ToTable("TipoSaida");
                });

            modelBuilder.Entity("SistemaProduto.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UsuarioEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioEmail");

                    b.Property<string>("UsuarioName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioNome");

                    b.Property<string>("UsuarioSenha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("UsuarioSenha");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("SistemaProduto.Models.Cidade", b =>
                {
                    b.HasOne("SistemaProduto.Models.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("SistemaProduto.Models.Cliente", b =>
                {
                    b.HasOne("SistemaProduto.Models.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("SistemaProduto.Models.EntradaProduto", b =>
                {
                    b.HasOne("SistemaProduto.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("SistemaProduto.Models.Estado", b =>
                {
                    b.HasOne("SistemaProduto.Models.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("SistemaProduto.Models.Produto", b =>
                {
                    b.HasOne("SistemaProduto.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaProduto.Models.TipoProduto", "TipoProduto")
                        .WithMany()
                        .HasForeignKey("TipoProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");

                    b.Navigation("TipoProduto");
                });

            modelBuilder.Entity("SistemaProduto.Models.SaidaProduto", b =>
                {
                    b.HasOne("SistemaProduto.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaProduto.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaProduto.Models.TipoSaida", "TipoSaida")
                        .WithMany()
                        .HasForeignKey("TipoSaidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaProduto.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Produto");

                    b.Navigation("TipoSaida");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}