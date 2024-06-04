using Data;
using Microsoft.EntityFrameworkCore;
using Model;
using Repository;
using System;

class Program
{
    static void Main(string[] args)
    {
        
            // Supondo que estabelecimento e modelo já existam no banco de dados
            // Recupere-os do banco de dados em vez de criar novos
            var estabelecimentoRepository = new EstabelecimentoRepository();

            var estabelecimento = new Estabelecimento("Medianeira", "São Paulo", "Rua da Consolação, 123");
            estabelecimentoRepository.Add(estabelecimento);


            
               var modelo = new Modelo
                {
                    Nome = "Civic",
                    Marca = "Honda",
                    Ano = 2022,
                    Motor = "1.5 Turbo",
                    NumeroPortas = 4,
                    Transmissao = "Automática",
                    Combustivel = "Gasolina"
                };

        var modeloRepository = new ModeloRepository();

        modeloRepository.Add(modelo);
            

        

            // Criar e adicionar veículo referenciando o modelo e estabelecimento
            var veiculo = new Veiculo
            {
                ModeloID = modelo.ID, // Referência direta ao objeto modelo
                _Condicao = Veiculo.Condicao.Novo,
                EstabelecimentoID = estabelecimento.ID, // Referência direta ao objeto estabelecimento
                Valor = 50000
            };

            var veiculosRepository = new VeiculoRepository();
            veiculosRepository.Add(veiculo);
       
            System.Console.WriteLine("Veículo adicionado com sucesso com ID: " + veiculo.ID);
        

    }
}
