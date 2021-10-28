using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class LeilaoDAO
    {
        private AppDbContext ctx;
        public LeilaoDAO()
        {
            ctx = new AppDbContext();
        }

        public void Incluir(Leilao leilao)
        {
            ctx.Leiloes.Add(leilao);
            ctx.SaveChanges();
        }

        public void Alterar(Leilao leilao)
        {
            ctx.Leiloes.Update(leilao);
            ctx.SaveChanges();
        }

        public void Excluir (Leilao leilao)
        {
            ctx.Leiloes.Remove(leilao);
            ctx.SaveChanges();
        }

        public IEnumerable<Categoria> ListarCategorias()
        {
            return ctx.Categorias.ToList();
        }

        public Leilao BuscarLeilaoId(int id)
        {
            return ctx.Leiloes.Find(id);
        }
    }
}
