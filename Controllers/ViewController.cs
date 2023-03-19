using Microsoft.AspNetCore.Mvc;
using Sistema__mundivox.Models;
using Sistema__mundivox.Repositório;

namespace Sistema__mundivox.Controllers
{
    public class ViewController : Controller
    {
        private readonly IFornecedoresRepositorio _fornecedorRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ViewController(IFornecedoresRepositorio fornecedorRepositorio,
                              IProdutoRepositorio produtoRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _produtoRepositorio = produtoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fornecedores()
        {
            List<FornecedoresModel> fornecedores = _fornecedorRepositorio.BuscarTodos();

            return View(fornecedores);
        }

        public IActionResult Produtos()
        {
            List<ProdutoModel> produtos = _produtoRepositorio.BuscarTodos();

            return View(produtos);
        }

        public IActionResult Pedidos()
        {
            return View();
        }

        public IActionResult Pedidos_itens()
        {
            return View();
        }
    }
}
