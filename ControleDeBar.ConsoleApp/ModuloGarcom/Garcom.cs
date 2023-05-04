using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarcom {
    internal class Garcom : EntidadeBase {

        public string nome;
        public string telefone;


        public Garcom(string nome, string telefone) {
            this.nome = nome;
            this.telefone = telefone;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado) {

            Garcom garcomAtualizado = (Garcom)registroAtualizado;

            nome = garcomAtualizado.nome;
            telefone = garcomAtualizado.telefone;
        }

        public override ArrayList Validar() {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (string.IsNullOrEmpty(telefone.Trim()))
                erros.Add("O campo \"telefone\" é obrigatório");

            return erros;
        }
    }
}
