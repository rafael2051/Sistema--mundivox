using Microsoft.AspNetCore.Mvc;
using Sistema__mundivox.Models;
using Sistema__mundivox.Repositorio;

namespace Sistema__mundivox.Controllers
{
    public class UpdateController : Controller
    {
        private readonly IFornecedoresRepositorio _fornecedorRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;
        public UpdateController(IFornecedoresRepositorio fornecedorRepositorio,
                                 IProdutoRepositorio produtoRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;
            _produtoRepositorio = produtoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditarFornecedor(int id)
        {
            FornecedoresModel fornecedor = _fornecedorRepositorio.ListarPorId(id);
            return View(fornecedor);
        }

        [HttpPost]
        public IActionResult AlterarFornecedor(FornecedoresModel Fornecedor)
        {
            _fornecedorRepositorio.Alterar(Fornecedor);
            return RedirectToAction("Index");
        }

        public IActionResult EditarProduto()
        {
            return View();
        }

        public IActionResult EditarPedido()
        {
            return View();
        }
    }
}
