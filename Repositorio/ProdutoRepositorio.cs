using Sistema__mundivox.Data;
using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {

        private readonly BancoContext _bancoContext;

        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ProdutoModel Adicionar(ProdutoModel Produto)
        {
            _bancoContext.produtos.Add(Produto);
            _bancoContext.SaveChanges();
            return Produto;
        }

        public List<ProdutoModel> BuscarTodos()
        {
            return _bancoContext.produtos.ToList();
        }
    }
}
