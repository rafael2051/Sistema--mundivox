using Sistema__mundivox.Data;
using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositorio
{
    public class FornecedoresRepositorio : IFornecedoresRepositorio
    {
        private readonly BancoContext _bancoContext;

        public FornecedoresRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public FornecedoresModel ListarPorId(int id)
        {
            return _bancoContext.fornecedores.FirstOrDefault(x => x.Id == id);
        }

        public List<FornecedoresModel> BuscarTodos()
        {
            return _bancoContext.fornecedores.ToList();
        }

        public FornecedoresModel Adicionar(FornecedoresModel Fornecedor)
        {
            _bancoContext.fornecedores.Add(Fornecedor);
            _bancoContext.SaveChanges();
            return Fornecedor;
        }

        public FornecedoresModel Alterar(FornecedoresModel Fornecedor)
        {
            if (Fornecedor == null) throw new Exception("Erro para atualizar");

            FornecedoresModel fornecedorDB = this.ListarPorId(Fornecedor.Id);

            if (fornecedorDB == null) throw new Exception("Erro para atualizar");

            fornecedorDB.razao_social = Fornecedor.razao_social;
            fornecedorDB.cnpj = Fornecedor.cnpj;

            _bancoContext.fornecedores.Update(fornecedorDB);
            _bancoContext.SaveChanges();

            return fornecedorDB;
        }
    }
}
