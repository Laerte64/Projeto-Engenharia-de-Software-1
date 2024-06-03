using Microsoft.EntityFrameworkCore;
using Model;
using Repository;
using System;

class Program
{
    static void Main(string[] args)
    {
        var estabelecimentoRepo = new EstabelecimentoRepository();

        // Adicionar estabelecimentos
        estabelecimentoRepo.Add(new Estabelecimento("São Paulo", "São Paulo", "Rua da Consolação, 123"));
        estabelecimentoRepo.Add(new Estabelecimento("Rio de Janeiro", "Rio de Janeiro", "Avenida Atlântica, 1000"));
        System.Console.WriteLine("Estabelecimentos adicionados.");

        // Listar todos os estabelecimentos
        var estabelecimentos = estabelecimentoRepo.GetAll();
        System.Console.WriteLine("Listando todos os estabelecimentos:");
        foreach (var estab in estabelecimentos)
        {
            System.Console.WriteLine($"Estado: {estab.Estado}, Cidade: {estab.Cidade}, Endereço: {estab.Endereco}");
        }

        // Atualizar estabelecimento
        var estabToUpdate = estabelecimentoRepo.GetById(estabelecimentos.First().ID);
        estabToUpdate.Endereco = "Rua da Consolação, 500";
        estabelecimentoRepo.Update(estabToUpdate);
        System.Console.WriteLine("Estabelecimento atualizado.");

        // Remover um estabelecimento
        estabelecimentoRepo.Remove(estabToUpdate);
        System.Console.WriteLine("Estabelecimento removido.");
    }
}
