using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto {
    internal class TelaProduto : TelaBase<Produto> {

        RepositorioProduto repositorioProduto;

        public TelaProduto(RepositorioProduto repositorioProduto) {

            this.repositorioProduto = repositorioProduto;
            this.repositorioBase = repositorioProduto;
        }
        protected override void MostrarTabela(List<Produto> registros) {
            Console.WriteLine("{0,-5} |{1,-20} |{2,-20}|", "ID", "Nome", "Valor");
            Console.WriteLine("--------------------------------------------------");
            foreach (Produto p in registros) {
                Console.WriteLine("{0,-5} |{1,-20} |{2,-20}|", p.id, p.nome, $"R$ {p.valor}");
                Console.WriteLine("--------------------------------------------------");
            }
            Console.ReadLine();
        }

        protected override Produto ObterRegistro() {
            Console.Write("Digite o nome do Produto: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o valor do Produto: ");
            double valor = double.Parse(Console.ReadLine());

            Produto produto = new Produto(nome,valor);

            return produto;
        }
    }
}
