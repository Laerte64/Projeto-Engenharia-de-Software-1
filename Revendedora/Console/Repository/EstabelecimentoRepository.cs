using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    internal class EstabelecimentoRepository : IRepository<Estabelecimento>
    {
        public void Add(Estabelecimento estabelecimento)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Estabelecimentos.Add(estabelecimento);
                _context.SaveChanges();
            }
        }

        public void Remove(Estabelecimento estabelecimento)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Estabelecimentos.Remove(estabelecimento);
                _context.SaveChanges();
            }

        }

        public void Update(Estabelecimento estabelecimento)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Estabelecimentos.Update(estabelecimento);
                _context.SaveChanges();
            }
        }

        public List<Estabelecimento> GetAll()
        {
            using (var _context = new RevendedoraContext())
            {
               return  _context.Estabelecimentos.ToList();
                _context.SaveChanges();
            }
        }

        public Estabelecimento GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                return _context.Estabelecimentos.Find(id);
            }
        }
    }
}
