using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models;

[Table("produtos_categorias")]
public class ProdutosCategoria
{
    [Key]
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public string? Ativa { get; set; }

    public int? Cadastrado_Usuario { get; set; }

    public DateTime? Cadastrado_Data { get; set; }

    public int? Alterado_Usuario { get; set; }

    public DateTime? Alterado_Data { get; set; }

    public virtual ICollection<Produtos> Produtos { get; set; } = new List<Produtos>();
}
