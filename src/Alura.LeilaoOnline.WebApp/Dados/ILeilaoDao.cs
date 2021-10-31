﻿using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
   public interface ILeilaoDao
    {
        void Incluir(Leilao leilao);
        void Alterar(Leilao leilao);
        void Excluir(Leilao leilao);
        IEnumerable<Categoria> ListarCategorias();
        IEnumerable<Leilao> ListarLeiloes();
        Leilao BuscarLeilaoId(int id);
    }
}
