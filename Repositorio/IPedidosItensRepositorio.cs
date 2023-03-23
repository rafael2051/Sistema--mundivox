using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositorio
{
    public interface IPedidosItensRepositorio
    {
        List<Pedidos_ItensModel> BuscarTodos();
        Pedidos_ItensModel Adicionar(Pedidos_ItensModel Produto);
    }
}
