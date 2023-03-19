using Sistema__mundivox.Data;
using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositório
{
    public class PedidosRepositorio : IPedidosRepositorio
    {
        private readonly BancoContext _bancoContext;

        public PedidosRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public PedidosModel Adicionar(PedidosModel Pedido)
        {
            _bancoContext.pedidos.Add(Pedido);
            _bancoContext.SaveChanges();
            return Pedido;
        }

        public List<PedidosModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
