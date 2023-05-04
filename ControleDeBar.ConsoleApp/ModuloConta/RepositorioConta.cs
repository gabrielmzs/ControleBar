using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta {
    internal class RepositorioConta:RepositorioBase<Conta> {

        double faturamentoDiario;
        public RepositorioConta(List<Conta> lista) {
            listaRegistros = lista;
        }
        public override Conta SelecionarPorId(int id) {

            return base.SelecionarPorId(id);
        }

        public List<Conta> VerificarContasAbertas() {
            List<Conta> ContasAbertas = new List<Conta>();

            foreach (Conta c in listaRegistros) {
                if(c.status == "Aberta") {
                    ContasAbertas.Add(c);
                }
            }
            return ContasAbertas;
        }

        public void FaturamentoDoDia() {
            
            foreach (Conta c in listaRegistros) {
                faturamentoDiario += c.valorFinal;
            }

            Console.WriteLine($"O faturamento do dia: R$ {faturamentoDiario}");
            Console.ReadLine();
        }


        //Validações ainda em construção

        //public bool VerificarSeAMesaPossuiConta(int id) {
        //    return false;
        //    foreach (Conta c in listaRegistros) {
        //        if (c.mesa.id == id) {
        //            return true;
        //        }
        //    }
        //}
    }
}
