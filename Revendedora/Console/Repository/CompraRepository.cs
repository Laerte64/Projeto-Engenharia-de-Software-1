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
    internal class CompraRepository : IRepository<Compra>
    {
        public void Add(Compra e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Compras.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Compra e)
        {
        using (var _context = new RevendedoraContext())
        {
            _context.Compras.Remove(e);
            _context.SaveChanges();
        }
        }

        public void Update(Compra e)
        {
    using (var _context = new RevendedoraContext())
    {
        _context.Compras.Update(e);
        _context.SaveChanges();
    }
        }

        public List<Compra> GetAll()
        {
            using (var _context = new RevendedoraContext())
            {
                return _context.Compras.ToList();
               
            }
        }

        public Compra GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                var compra = _context.Compras.Find(id);

                if (compra == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return compra;
            }
        }

    }
}
