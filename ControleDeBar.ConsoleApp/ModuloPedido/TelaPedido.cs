using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloPedido {
    internal class TelaPedido : TelaBase<Pedido> {

        RepositorioPedido repositorioPedido;
        RepositorioMesa repositorioMesa;
        RepositorioProduto repositorioProduto;
        RepositorioConta repositorioConta;
        TelaConta telaConta;
        TelaMesa telaMesa;
        TelaProduto telaProduto;

        public TelaPedido(RepositorioPedido repositorioPedido, RepositorioMesa repositorioMesa, RepositorioProduto repositorioProduto, TelaMesa telaMesa, TelaProduto telaProduto, TelaConta telaConta, RepositorioConta repositorioConta) {
            this.repositorioPedido = repositorioPedido;
            this.repositorioMesa = repositorioMesa;
            this.repositorioProduto = repositorioProduto;
            this.telaMesa = telaMesa;
            this.telaProduto = telaProduto;
            this.telaConta = telaConta;
            this.repositorioConta = repositorioConta;
            this.repositorioBase = repositorioPedido;
        }

        protected override void MostrarTabela(List<Pedido> registros) {
            Console.WriteLine("{0,-5} |{1,-20} |{2,-20} |{3,-20} |{4,-5} |{5,-5}|", "ID", "Produto", "Quantidade", "Valor Total", "Conta", "Mesa");
            Console.WriteLine("--------------------------------------------------------------------------");
            foreach (Pedido p in registros) {
                Console.WriteLine("{0,-5} |{1,-20} |{2,-20} |{3,-20} |{4,-5} |{5,-5}|", p.id, p.produto.nome, p.quantidade,p.valorTotalPedido,p.conta.id, p.conta.mesa.id );
                Console.WriteLine("--------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }

        

        protected override Pedido ObterRegistro() {

            telaConta.VisualizarRegistros(false);
            Console.Write("Digite o ID da conta: ");
            int id3 = int.Parse(Console.ReadLine());
            Conta conta = repositorioConta.SelecionarPorId(id3);
            Console.WriteLine();
        
            telaProduto.VisualizarRegistros(false);
            Console.Write("Digite o ID do Produto: ");
            int id = int.Parse(Console.ReadLine());
            Produto produto = repositorioProduto.SelecionarPorId(id);
            Console.WriteLine();

            Console.Write("Digite a quantidade pedida: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valorTotal = quantidade * produto.valor;
            conta.valorFinal += valorTotal;

            Pedido pedido = new Pedido(conta, produto, quantidade, valorTotal);

            return pedido;


        }

        
    }
}
