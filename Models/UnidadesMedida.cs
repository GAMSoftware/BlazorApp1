using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models;
[Table("unidades_medidas")]
public class UnidadesMedida
{
    [Key]
    public string Sigla { get; set; } = null!;

    public string? Descricao { get; set; }

    public short? Casas_Decimais { get; set; }

    public string? Ativa { get; set; }

    public int? Cadastrado_Usuario { get; set; }

    public DateTime? Cadastrado_Data { get; set; }

    public int? Alterado_Usuario { get; set; }

    public DateTime? Alterado_Data { get; set; }

    public virtual ICollection<Produtos> Produtos { get; set; } = new List<Produtos>();
}
