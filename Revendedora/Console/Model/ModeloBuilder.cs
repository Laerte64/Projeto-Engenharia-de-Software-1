
namespace Model
{
    internal class ModeloBuilder
    {
        private Modelo _modelo;

        public ModeloBuilder(string nome, string marca, int ano)
        {
            _modelo = new Modelo(nome, marca, ano);
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
