using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloPedido {
    internal class RepositorioPedido:RepositorioBase<Pedido> {

        public RepositorioPedido(List<Pedido> lista) {
            listaRegistros = lista;
        }
        public override Pedido SelecionarPorId(int id) {

            return (Pedido)base.SelecionarPorId(id);
        }

        public ArrayList SelecionarPedidosDaConta(int id) {
            ArrayList pedidosDaConta = new ArrayList();
            foreach (Pedido p in listaRegistros) {
                if(p.conta.id == id) {
                pedidosDaConta.Add(p);
                }
            }
            return pedidosDaConta;
        }

        public void MostrarComanda(ArrayList registros) {
            Console.WriteLine("{0,-5} |{1,-20} |{2,-20} |{3,-20} |{4,-5} |{5,-5}|", "ID", "Produto", "Quantidade", "Valor Total", "Conta", "Mesa");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            foreach (Pedido p in registros) {
                Console.WriteLine("{0,-5} |{1,-20} |{2,-20} |{3,-20} |{4,-5} |{5,-5}|", p.id, p.produto.nome, p.quantidade, "R$ " + p.valorTotalPedido, p.conta.id, p.conta.mesa.id);
                Console.WriteLine("-------------------------------------------------------------------------------------");
            }
            Console.ReadLine();
        }
    }
}
