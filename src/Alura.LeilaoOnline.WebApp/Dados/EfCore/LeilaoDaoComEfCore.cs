using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore : ILeilaoDao
    {
        private AppDbContext ctx;
        public LeilaoDaoComEfCore()
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

        public void Excluir(Leilao leilao)
        {
            ctx.Leiloes.Remove(leilao);
            ctx.SaveChanges();
        }

        public IEnumerable<Leilao> ListarLeiloes() => ctx.Leiloes.Include(l => l.Categoria);

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
