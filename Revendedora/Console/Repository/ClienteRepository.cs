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
    internal class ClienteRepository : IRepository<Cliente>
    {
        public void Add(Cliente e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Clientes.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Cliente e)
        {   
            using (var _context = new RevendedoraContext())
            {
                _context.Clientes.Remove(e);
                _context.SaveChanges();
            }
        }

        public void Update(Cliente e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Clientes.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Cliente> GetAll()
        {
            using (var _context = new RevendedoraContext())
            {
                return _context.Clientes.ToList();
                _context.SaveChanges();
            }
        }

        public Cliente GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                var cliente = _context.Clientes.Find(id);

                if (cliente == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return cliente;
            }
        }
    
    }
}
