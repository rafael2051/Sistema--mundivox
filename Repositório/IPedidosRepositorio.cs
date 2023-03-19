﻿using Sistema__mundivox.Models;

namespace Sistema__mundivox.Repositório
{
    public interface IPedidosRepositorio
    {
        List<PedidosModel> BuscarTodos();
        PedidosModel Adicionar(PedidosModel Produto);
    }
}
