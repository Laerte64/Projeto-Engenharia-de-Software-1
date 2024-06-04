using Data;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class VendaRepository : IRepository<Venda>
    {
        public void Add(Venda e)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                _context.Vendas.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Venda e)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                _context.Vendas.Remove(e);
                _context.SaveChanges();
            }
        }

        public void Update(Venda e)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                _context.Vendas.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Venda> GetAll()
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                return _context.Vendas.ToList();
            }
        }

        public Venda GetById(int id)
        {
            using (var _context = RevendedoraContext.AdquirirContexto())
            {
                var venda = _context.Vendas.Find(id);

                if (venda == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return venda;
            }
        }
    }
}
