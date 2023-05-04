using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using ControleDeBar.ConsoleApp.ModuloPedido;
using System.Collections;

namespace ControleDeBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new List<Garcom>());
            RepositorioMesa repositorioMesa = new RepositorioMesa(new List<Mesa>());
            RepositorioProduto repositorioProduto = new RepositorioProduto(new List<Produto>());
            RepositorioConta repositorioConta = new RepositorioConta(new List<Conta>());
            RepositorioPedido repositorioPedido = new RepositorioPedido(new List<Pedido>());

            CadastrarAutomatico();

            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            telaGarcom.nomeEntidade = "Garçom";
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            telaMesa.nomeEntidade = "Mesa";
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);
            telaProduto.nomeEntidade = "Produto";
            TelaConta telaConta = new TelaConta(repositorioConta,repositorioGarcom, repositorioMesa, repositorioProduto, telaGarcom, telaMesa, telaProduto,repositorioPedido);
            TelaPedido telaPedido = new TelaPedido(repositorioPedido,repositorioMesa,repositorioProduto,telaMesa, telaProduto,telaConta, repositorioConta);


            while (true) {
                Console.Clear();
                Console.WriteLine("Bar da Galera 1.0");
                Console.WriteLine("1 - Cadastro Garçons");
                Console.WriteLine("2 - Cadastro Mesas");
                Console.WriteLine("3 - Cadastro Produtos");
                Console.WriteLine("4 - Cadastro Contas e Pedidos");
               
                Console.WriteLine("0 - Encerrar");

                string opcao = Console.ReadLine();

                if (opcao == "0") {
                    break;

                } else if (opcao == "1") {

                    string opcaoGarcom = telaGarcom.ApresentarMenu();

                    if (opcaoGarcom == "1") telaGarcom.InserirNovoRegistro();
                    else if (opcaoGarcom == "2") telaGarcom.VisualizarRegistros(true);
                    else if (opcaoGarcom == "3") telaGarcom.EditarRegistro();
                    else if (opcaoGarcom == "4") telaGarcom.ExcluirRegistro();
                    continue;

                } else if (opcao == "2") {

                    string opcaoMesa = telaMesa.ApresentarMenu();

                    if (opcaoMesa == "1") telaMesa.InserirNovoRegistro();
                    else if (opcaoMesa == "2") telaMesa.VisualizarRegistros(true);
                    else if (opcaoMesa == "3") telaMesa.EditarRegistro();
                    else if (opcaoMesa == "4") telaMesa.ExcluirRegistro();
                    continue;

                } else if (opcao == "3") {

                    string opcaoProduto = telaProduto.ApresentarMenu();

                    if (opcaoProduto == "1") telaProduto.InserirNovoRegistro();
                    else if (opcaoProduto == "2") telaProduto.VisualizarRegistros(true);
                    else if (opcaoProduto == "3") telaProduto.EditarRegistro();
                    else if (opcaoProduto == "4") telaProduto.ExcluirRegistro();
                    continue;
                } 
                else if (opcao == "4") {

                    string opcaoConta = telaConta.ApresentarMenu();

                    if (opcaoConta == "1") telaConta.InserirNovoRegistro();
                    else if (opcaoConta == "2") telaPedido.InserirNovoRegistro();
                    else if (opcaoConta == "3") telaConta.FecharConta();
                    else if (opcaoConta == "4") telaConta.MostrarContasAbertas();
                    else if (opcaoConta == "5") repositorioConta.FaturamentoDoDia();
                    continue;
                }  
            }

            void CadastrarAutomatico() {

                Garcom garcom = new Garcom("Ronaldo", "9922-2233");
                repositorioGarcom.Inserir(garcom);
                Garcom garcom2 = new Garcom("Clovis", "4423-2233");
                repositorioGarcom.Inserir(garcom2);

                Mesa mesa = new Mesa("Mesa da Janela");
                repositorioMesa.Inserir(mesa);
                Mesa mesa2 = new Mesa("Mesa VIP");
                repositorioMesa.Inserir(mesa2);
                Mesa mesa3 = new Mesa("Mesa Plástico");
                repositorioMesa.Inserir(mesa3);
                Mesa mesa4 = new Mesa("Mesa Skol");
                repositorioMesa.Inserir(mesa4);

                Produto produto = new Produto("Cerveja", 10);
                repositorioProduto.Inserir(produto);
                Produto produto2 = new Produto("Batata Frita", 30);
                repositorioProduto.Inserir(produto2);
                Produto produto3 = new Produto("Água", 5);
                repositorioProduto.Inserir(produto3);

                Conta conta = new Conta(garcom, mesa2);
                repositorioConta.Inserir(conta);
                Conta conta2 = new Conta(garcom2, mesa4);
                repositorioConta.Inserir(conta2);
                Conta conta3 = new Conta(garcom, mesa);
                repositorioConta.Inserir(conta3);


            }
        }
    }
}