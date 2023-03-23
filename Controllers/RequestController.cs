using Microsoft.AspNetCore.Mvc;
using Sistema__mundivox.Models;
using Sistema__mundivox.Repositorio;

namespace Sistema__mundivox.Controllers
{
    public class RequestController : Controller
    {
        private readonly IPedidosRepositorio _pedidosRepositorio;
        private readonly IPedidosItensRepositorio _pedidosItensRepositorio;

        public RequestController(IPedidosRepositorio pedidosRepositorio, IPedidosItensRepositorio pedidosItensRepositorio)
        {
            _pedidosRepositorio = pedidosRepositorio;
            _pedidosItensRepositorio = pedidosItensRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Pedido(PedidosModel Pedido)
        {
            _pedidosRepositorio.Adicionar(Pedido);
            return View(Pedido);
        }

        [HttpPost]
        public IActionResult PedidoItens(Pedidos_ItensModel Pedido_Itens)
        {
            _pedidosItensRepositorio.Adicionar(Pedido_Itens);
            return View(Pedido_Itens);
        }
    }
}
