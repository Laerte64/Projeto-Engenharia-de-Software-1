using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Model
{
    class ModeloBuilder
    {
        private Modelo _modelo;

        public ModeloBuilder()
        {
            _modelo = new Modelo();
        }

        public ModeloBuilder AdicionarNome(string nome)
        {
            _modelo.Nome = nome;
            return this;
        }

        public ModeloBuilder AdicionarMarca(string marca)
        {
            _modelo.Marca = marca;
            return this;
        }

        public ModeloBuilder AdicionarAno(int ano)
        {
            _modelo.Ano = ano;
            return this;
        }

        public ModeloBuilder AdicionarMotor(string motor)
        {
            _modelo.Motor = motor;
            return this;
        }

        public ModeloBuilder AdicionarNumeroPortas(int num)
        {
            _modelo.NumeroPortas = num;
            return this;
        }

        public ModeloBuilder AdicionarTransmissao(string transmissao)
        {
            _modelo.Transmissao = transmissao;
            return this;
        }

        public ModeloBuilder AdicionarCombustivel(string combustivel)
        {
            _modelo.Combustivel = combustivel;
            return this;
        }

        public Modelo Build()
        {
            return _modelo;
        }
    }
}
