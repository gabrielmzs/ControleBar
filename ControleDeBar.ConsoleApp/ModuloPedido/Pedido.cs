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
    internal class Pedido : EntidadeBase {

        public Conta conta;
        
        public Produto produto;
        public int quantidade;
        public double valorTotalPedido;

        public Pedido(Conta conta, Produto produto, int quantidade, double valorTotalPedido) {
            this.conta = conta;
            this.produto = produto;
            this.quantidade = quantidade;
            this.valorTotalPedido = valorTotalPedido;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado) {
            throw new NotImplementedException();
        }

        public override ArrayList Validar() {
            ArrayList erros = new ArrayList();

            return erros;
        }
    }
}
