using Sistema__mundivox.Data;
using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositório
{
    public class PedidosItensRepositorio : IPedidosItensRepositorio
    {
        private readonly BancoContext _bancoContext;

        public PedidosItensRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Pedidos_ItensModel Adicionar(Pedidos_ItensModel PedidoItens)
        {
            _bancoContext.pedidos_itens.Add(PedidoItens);
            _bancoContext.SaveChanges();
            return PedidoItens;
        }

        public List<Pedidos_ItensModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

