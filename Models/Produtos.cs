using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models;
[Table("produtos")]
public class Produtos
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public decimal? Preco_Custo { get; set; }

    public decimal? Preco_Venda { get; set; }

    public double? Estoque_Minimo { get; set; }

    public double? Estoque_Maximo { get; set; }

    public double? Estoque_Saldo_Inicial { get; set; }

    public DateOnly? Estoque_Saldo_Inicial_Data { get; set; }

    public string? Ativo { get; set; }

    public int? Cadastrado_Usuario { get; set; }

    public DateTime? Cadastrado_Data { get; set; }

    public int? Alterado_Usuario { get; set; }

    public DateTime? Alterado_Data { get; set; }

    public virtual ProdutosCategoria? Id_Categoria { get; set; }

    public virtual UnidadesMedida? Un { get; set; }

   
}
