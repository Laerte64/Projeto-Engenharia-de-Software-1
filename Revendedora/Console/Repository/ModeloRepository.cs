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
    internal class ModeloRepository : IRepository<Modelo>
    {
        public void Add(Modelo e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Modelos.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Modelo e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Modelos.Remove(e);
                _context.SaveChanges();
            }
        }

        public void Update(Modelo e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Modelos.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Modelo> GetAll()
        {
            using (var _context = new RevendedoraContext())
            {
                return _context.Modelos.ToList();
            }
        }

        public Modelo GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                var modelo = _context.Modelos.Find(id);

                if (modelo == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return modelo;
            }
        }
    }
}
