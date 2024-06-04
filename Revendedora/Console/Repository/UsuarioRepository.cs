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
    internal class UsuarioRepository : IRepository<Usuario>
    {
        public void Add(Usuario e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Usuarios.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Usuario e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Usuarios.Remove(e);
                _context.SaveChanges();
            }
        }

        public void Update(Usuario e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Usuarios.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Usuario> GetAll()
        {       
            using (var _context = new RevendedoraContext())
            {
                return _context.Usuarios.ToList();
            }
        }

        public Usuario GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                var usuario = _context.Usuarios.Find(id);

                if (usuario == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return usuario;
            }
        }
    }
}
