using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositório
{
    public interface IProdutoRepositorio
    {
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel Produto);
    }
}
