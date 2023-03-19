using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositório
{
    public interface IFornecedoresRepositorio
    {
        FornecedoresModel ListarPorId(int id);
        List<FornecedoresModel> BuscarTodos();
        FornecedoresModel Adicionar(FornecedoresModel Fornecedor);
        FornecedoresModel Alterar(FornecedoresModel Fornecedor);
    }
}
