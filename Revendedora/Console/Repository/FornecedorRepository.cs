using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class FornecedorRepository : IRepository<Fornecedor>  
    {
        public void Add(Fornecedor e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Fornecedores.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Fornecedor e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Fornecedores.Remove(e);
                _context.SaveChanges();
            }
        }

        public void Update(Fornecedor e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Fornecedores.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Fornecedor> GetAll()
        {
            using (var _context = new RevendedoraContext())
            {
                return _context.Fornecedores.ToList();
            }
        }

        public Fornecedor GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                var fornecedor = _context.Fornecedores.Find(id);

                if (fornecedor == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return fornecedor;
            }
        }
    }
}
