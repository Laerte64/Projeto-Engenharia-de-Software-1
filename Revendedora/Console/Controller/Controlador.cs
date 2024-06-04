using Console.View;
using Model;
using Repository;
using View;

namespace Controller
{
    internal class Controlador
    {
        private static Controlador _controlador = new Controlador();
        public static Controlador AdquirirControlador() => _controlador;
        private Controlador() { }
        
        public void ExecutarPrograma()
        {
            List<Usuario> usuarios = (new UsuarioRepository()).GetAll();
            Usuario? usuario = null;
            (string login, string senha) = TelaLogin.ExecutarTela();
            usuario = usuarios.Find(u => u.Login == login && u.Senha == senha);
            while (usuario == null) 
            {
                (login, senha) = TelaLogin.ExecutarTela(true);
                usuario = usuarios.Find(u => u.Login == login && u.Senha == senha);
            }
            
            while (true)
            {
                int opcao = TelaPrincipal.ExecutarTela();
                switch (opcao)
                {
                    case 0:
                        return;
                    case 1:
                        TelaVerificarVeiculos.ExecutarTela((new VeiculoRepository()).GetAll());
                        break;
                    case 2:
                        TelaVerificarVendas.ExecutarTela((new VendaRepository()).GetAll());
                        break;
                    case 3:
                        TelaVerificarCompras.ExecutarTela((new CompraRepository()).GetAll());
                        break;
                    case 4:
                        TelaVerificarModelos.ExecutarTela((new ModeloRepository()).GetAll());
                        break;
                    case 5:
                        {
                            var resposta = TelaRegistrarVenda.ExecutarTela();
                            Veiculo veiculo;
                            try
                            {
                                veiculo = (new VeiculoRepository()).GetById(resposta.id);
                            }
                            catch (Exception ex)
                            {
                                TelaRegistrarVenda.Erro();
                                continue;
                            }
                            Cliente? cliente = (new ClienteRepository()).GetAll().Find(c => c.CPF == resposta.cpf);
                            if (cliente == null)
                            {
                                TelaRegistrarVenda.Erro();
                                continue;
                            }
                            Venda venda = usuario.Funcionario.RealizarVenda(veiculo, cliente, resposta.valor, System.DateTime.Now);
                            var repositorio = new VendaRepository();
                            repositorio.Add(venda);
                            TelaRegistrarVenda.Sucesso();
                            break;
                        }
                    case 6:
                        {
                            var resposta = TelaRegistrarCompra.ExecutarTela();
                            Modelo modelo;
                            try
                            {
                                modelo = (new ModeloRepository()).GetById(resposta.idModelo);
                            }
                            catch (Exception ex)
                            {
                                TelaRegistrarCompra.Erro();
                                continue;
                            }
                            Estabelecimento estabelecimento;
                            try
                            {
                                estabelecimento = (new EstabelecimentoRepository()).GetById(resposta.idEstabelecimento);
                            }
                            catch (Exception ex)
                            {
                                TelaRegistrarCompra.Erro();
                                continue;
                            }
                            Fornecedor? fornecedor;
                            fornecedor = (new FornecedorRepository()).GetAll().Find(f => f.CNPJ == resposta.cnpj);
                            if (fornecedor == null)
                            {
                                TelaRegistrarCompra.Erro();
                                continue;
                            }

                            Veiculo veiculo = new Veiculo(modelo, Veiculo.Condicao.Novo, null, estabelecimento);
                            Compra compra = usuario.Funcionario.RealizarCompra(veiculo, fornecedor, resposta.valor, System.DateTime.Now);
                            veiculo.Compra = compra;
                            veiculo.Valor = resposta.valor * 1.1m;
                            var repVeiculo = new VeiculoRepository();
                            repVeiculo.Add(veiculo);
                            var repositorio = new CompraRepository();
                            repositorio.Add(compra);
                            TelaRegistrarCompra.Sucesso();
                            break;
                        }
                    case 7:
                        {
                            var resposta = TelaRegistrarCliente.ExecutarTela();
                            var repCliente = new ClienteRepository();
                            if (repCliente.GetAll().Find(c => c.CPF == resposta.cpf) != null)
                            {
                                TelaRegistrarCliente.Erro(); 
                                continue;
                            }
                            var cliente = new Cliente(resposta.nome, resposta.cpf);
                            repCliente.Add(cliente);
                            TelaRegistrarCliente.Sucesso();
                        }
                        break;
                    case 8:
                        {
                            TelaRegistrarModelo.ExecutarTela();
                            string nome = TelaRegistrarModelo.PerguntarNome();
                            string marca = TelaRegistrarModelo.PerguntarMarca();
                            int ano = TelaRegistrarModelo.PerguntarAno();
                            ModeloBuilder builder = new ModeloBuilder(nome, marca, ano);
                            builder.AdicionarMotor(TelaRegistrarModelo.PerguntarMotor());
                            builder.AdicionarNumeroPortas(TelaRegistrarModelo.PerguntarNumPortas());
                            builder.AdicionarTransmissao(TelaRegistrarModelo.PerguntarTransmissao());
                            builder.AdicionarCombustivel(TelaRegistrarModelo.PerguntarCombustivel());
                            var repositorio = new ModeloRepository();
                            repositorio.Add(builder.Build());
                        }
                        break;
                }
            }
        }
    }
}
