using Microsoft.AspNetCore.Mvc;
using Sistema__mundivox.Models;
using Sistema__mundivox.Repositório;

namespace Sistema__mundivox.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IFornecedoresRepositorio _fornecedorRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        public RegisterController(IFornecedoresRepositorio fornecedorRepositorio,
                                 IProdutoRepositorio produtoRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _produtoRepositorio = produtoRepositorio;   
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fornecedor()
        {
            return View();
        }

        public IActionResult Produto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(FornecedoresModel Fornecedor) 
        {
            _fornecedorRepositorio.Adicionar(Fornecedor);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CriarProduto(ProdutoModel Produto)
        {
            _produtoRepositorio.Adicionar(Produto);
            return RedirectToAction("Index");
        }
    }
}
