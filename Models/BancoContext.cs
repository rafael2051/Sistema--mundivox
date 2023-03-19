using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Sistema__mundivox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema__mundivox.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<FornecedoresModel> fornecedores { get; set; }
        public DbSet<ProdutoModel> produtos { get; set; }
        public DbSet<PedidosModel> pedidos { get; set; }
        public DbSet<Pedidos_ItensModel> pedidos_itens { get; set; }

    }
}
