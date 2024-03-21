﻿// <auto-generated />
using System;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(BlazorApp1Context))]
    partial class BlazorApp1ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp1.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Alterado_Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Alterado_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Ativo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastrado_Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Cadastrado_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Estoque_Maximo")
                        .HasColumnType("float");

                    b.Property<double?>("Estoque_Minimo")
                        .HasColumnType("float");

                    b.Property<double?>("Estoque_Saldo_Inicial")
                        .HasColumnType("float");

                    b.Property<DateOnly?>("Estoque_Saldo_Inicial_Data")
                        .HasColumnType("date");

                    b.Property<int?>("Id_CategoriaId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Preco_Custo")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Preco_Venda")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UnSigla")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Id_CategoriaId");

                    b.HasIndex("UnSigla");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("BlazorApp1.Models.ProdutosCategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Alterado_Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Alterado_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Ativa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastrado_Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Cadastrado_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("produtos_categoria");
                });

            modelBuilder.Entity("BlazorApp1.Models.UnidadesMedida", b =>
                {
                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Alterado_Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Alterado_Usuario")
                        .HasColumnType("int");

                    b.Property<string>("Ativa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Cadastrado_Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Cadastrado_Usuario")
                        .HasColumnType("int");

                    b.Property<short?>("Casas_Decimais")
                        .HasColumnType("smallint");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sigla");

                    b.ToTable("unidades_medidas");
                });

            modelBuilder.Entity("BlazorApp1.Models.Produtos", b =>
                {
                    b.HasOne("BlazorApp1.Models.ProdutosCategoria", "Id_Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("Id_CategoriaId");

                    b.HasOne("BlazorApp1.Models.UnidadesMedida", "Un")
                        .WithMany("Produtos")
                        .HasForeignKey("UnSigla");

                    b.Navigation("Id_Categoria");

                    b.Navigation("Un");
                });

            modelBuilder.Entity("BlazorApp1.Models.ProdutosCategoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("BlazorApp1.Models.UnidadesMedida", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
