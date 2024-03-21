using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Models;
[Table("usuario")]
public class Usuario
{
    public int Id { get; set; }

    public string? Nome_Login { get; set; }

    public string? Nome_Real { get; set; }

    public string? Email { get; set; }

    public string? Senha { get; set; }

    public int? Tema { get; set; }

    public DateTime? Data_Cadastro { get; set; }

    public string? Ativo { get; set; }
}
