using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto {
    internal class Produto : EntidadeBase {

        public string nome;
        public double valor;

        public Produto(string nome, double valor) {
            this.nome = nome;
            this.valor = valor;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado) {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            nome = produtoAtualizado.nome;
            valor = produtoAtualizado.valor;
        }

        public override ArrayList Validar() {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            

            return erros;
        }
    }
}
