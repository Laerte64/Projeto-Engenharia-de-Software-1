using Data;
using Microsoft.EntityFrameworkCore;
using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal class VeiculoRepository : IRepository<Veiculo>
    {
        public void Add(Veiculo e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Veiculos.Add(e);
                _context.SaveChanges();
            }
        }

        public void Remove(Veiculo e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Veiculos.Remove(e);
                _context.SaveChanges();
            }
        }

        public void Update(Veiculo e)
        {
            using (var _context = new RevendedoraContext())
            {
                _context.Veiculos.Update(e);
                _context.SaveChanges();
            }
        }

        public List<Veiculo> GetAll()
        {
            using (var _context = new RevendedoraContext())
            {
                return _context.Veiculos
                       .Include(v => v.Modelo) // Inclui o modelo relacionado
                       .Include(v => v.Compra) // Inclui a compra relacionada (se houver)
                       .Include(v => v.Venda) // Inclui a venda relacionada (se houver)
                       .Include(v => v.Estabelecimento) // Inclui o estabelecimento relacionado
                       .ToList();
            }
        }

        public Veiculo GetById(int id)
        {
            using (var _context = new RevendedoraContext())
            {
                var veiculo = _context.Veiculos.Find(id);

                if (veiculo == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return veiculo;
            }
        }
    }
}
