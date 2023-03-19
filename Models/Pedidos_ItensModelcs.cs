using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema__mundivox.Models
{
    public class Pedidos_ItensModel
    {
        public int Id { get; set; }
        public int pedidos_id { get; set; }
        public int produtos_id { get; set; }
        public int quantidade { get; set; }
        public int valor { get; set; }
    }
}

