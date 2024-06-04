using Data;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class FuncionarioRespository : IRepository<Funcionario>
    {
        public void Add(Funcionario e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Funcionarios.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Funcionario e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Funcionarios.Remove(e);
                _context.SaveChanges();
            }
        }

        public void Update(Funcionario e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Funcionarios.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Funcionario> GetAll()
        {
            using (var _context = new RevendedoraContext())
            {
                return _context.Funcionarios.ToList();
            }
        }

        public Funcionario GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                var funcionario = _context.Funcionarios.Find(id);

                if (funcionario == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return funcionario;
            }
        }
    }
}
