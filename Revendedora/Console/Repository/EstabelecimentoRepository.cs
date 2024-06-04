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
        public void Add(Estabelecimento e)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                _context.Estabelecimentos.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Estabelecimento e)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                _context.Estabelecimentos.Remove(e);
                _context.SaveChanges();
            }

        }

        public void Update(Estabelecimento e)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                _context.Estabelecimentos.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Estabelecimento> GetAll()
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
               return  _context.Estabelecimentos.ToList();
            }
        }

        public Estabelecimento GetById(int id)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                var estabelecimento = _context.Estabelecimentos.Find(id);

                if (estabelecimento == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return estabelecimento;
            }
        }
    }
}
