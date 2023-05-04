using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using ControleDeBar.ConsoleApp.ModuloPedido;
using System.Collections;


namespace ControleDeBar.ConsoleApp.ModuloConta {
    internal class TelaConta:TelaBase<Conta> {
        RepositorioConta repositorioConta;
        RepositorioGarcom repositorioGarcom;
        RepositorioMesa repositorioMesa;
        RepositorioProduto repositorioProduto;
        RepositorioPedido repositorioPedido;


        TelaGarcom telaGarcom;
        TelaMesa telaMesa;
        TelaProduto telaProduto;
       

        public TelaConta(RepositorioConta repositorioConta, RepositorioGarcom repositorioGarcom, RepositorioMesa repositorioMesa, RepositorioProduto repositorioProduto, 
            TelaGarcom telaGarcom, TelaMesa telaMesa, TelaProduto telaProduto, RepositorioPedido repositorioPedido) 
            {
            this.repositorioConta = repositorioConta;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioMesa = repositorioMesa;
            this.repositorioProduto = repositorioProduto;
            this.telaGarcom = telaGarcom;
            this.telaMesa = telaMesa;
            this.telaProduto = telaProduto;
            this.repositorioPedido = repositorioPedido;
            this.repositorioBase = repositorioConta;
            
        }

        protected override void MostrarTabela(List<Conta> registros) {
            Console.WriteLine("{0,-5} |{1,-20} |{2,-20} |{3,-20} |{4,-10}", "ID", "Mesa","Garçom","Total","Status");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            foreach (Conta c in registros) {
                Console.WriteLine("{0,-5} |{1,-20} |{2,-20} |{3,-20} |{4,-10}", c.id, $"Mesa {c.mesa.id}", c.garcom.nome,"R$ " + c.valorFinal, c.status);
                Console.WriteLine("-----------------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }

        protected override Conta ObterRegistro() {
            telaMesa.VisualizarRegistros(false);
            Console.Write("\nDigite o ID da Mesa: ");
            int id2 = int.Parse(Console.ReadLine());
            Mesa mesa = repositorioMesa.SelecionarPorId(id2);

            telaGarcom.VisualizarRegistros(false);
            Console.Write("\nDigite o ID do Garçom: ");
            int id = int.Parse(Console.ReadLine());
            Garcom garcom = repositorioGarcom.SelecionarPorId(id);
            Console.WriteLine();

            Conta conta = new Conta(garcom, mesa);

            return conta;
        }

        public override string ApresentarMenu() {
            Console.Clear();

            Console.WriteLine($"Cadastro de Contas\n");

            Console.WriteLine($"Digite 1 para Abrir uma Conta ");
            Console.WriteLine($"Digite 2 para Registrar Pedidos ");
            Console.WriteLine($"Digite 3 para Fechar uma Conta ");
            Console.WriteLine($"Digite 4 para Visualizar Contas Abertas ");
            Console.WriteLine($"Digite 5 para Faturamento do dia");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void FecharConta() {
            Console.Clear();
            MostrarContasAbertas();
            Console.Write("\nDigite o ID da conta: ");
            int id = int.Parse(Console.ReadLine());
            Conta conta = repositorioConta.SelecionarPorId(id);
            ArrayList pedidosDaConta = repositorioPedido.SelecionarPedidosDaConta(id);
            if(pedidosDaConta.Count > 0) {
                Console.WriteLine("\nPedidos da Conta: ");
            repositorioPedido.MostrarComanda(pedidosDaConta);
            }

            Console.Write("\nDigite S para Confirmar o fechamento da conta: ");
            string ok = Console.ReadLine();
            if (ok == "S" || ok == "s") {
                conta.status = "Fechada";
                MostrarMensagem("Conta Fechada!", ConsoleColor.Green);
            } else return;
        }

        public void MostrarContasAbertas() {
            Console.Clear();
            List<Conta> listaAbertos = repositorioConta.VerificarContasAbertas();
            if(listaAbertos.Count > 0) {
                Console.WriteLine("Contas em aberto: ");
            MostrarTabela(listaAbertos);
            } 
            else 
            { 
            MostrarMensagem("\nNão há contas em aberto!",ConsoleColor.DarkYellow);
            }
        } 



        
    }
}
