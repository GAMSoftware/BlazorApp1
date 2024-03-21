using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class BlazorApp1Context : DbContext
    {
        public BlazorApp1Context (DbContextOptions<BlazorApp1Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp1.Models.Produtos> Produtos { get; set; } = default!;
        public DbSet<BlazorApp1.Models.ProdutosCategoria> ProdutosCategoria { get; set; } = default!;
        public DbSet<BlazorApp1.Models.UnidadesMedida> UnidadesMedida { get; set; } = default!;
    }
}
