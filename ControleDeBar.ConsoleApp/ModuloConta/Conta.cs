using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta {
    internal class Conta:EntidadeBase {
        public Garcom garcom;
        public Mesa mesa;
        public double valorFinal=0;
        public string status = "Aberta";

        public Conta(Garcom garcom, Mesa mesa) {
            this.garcom = garcom;
            this.mesa = mesa;
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
