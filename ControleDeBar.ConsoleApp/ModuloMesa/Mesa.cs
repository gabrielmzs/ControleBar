using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa {
    internal class Mesa: EntidadeBase{

        public string nome;

        public Mesa(string nome) {
            this.nome = nome;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado) {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            nome = mesaAtualizada.nome;
            
        }

        public override ArrayList Validar() {
            ArrayList erros = new ArrayList();

            return erros;
        }

    }
}
