using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa {
    internal class TelaMesa:TelaBase<Mesa> {

        RepositorioMesa repositorioMesa;
        public TelaMesa(RepositorioMesa repositorioMesa) {

            this.repositorioMesa = repositorioMesa;
            this.repositorioBase = repositorioMesa;
        }

        protected override void MostrarTabela(List<Mesa> registros) {
            Console.WriteLine("{0,-5} |{1,-20} |", "ID", "Nome Mesa");
            Console.WriteLine("-----------------------------");
            foreach (Mesa c in registros) {
                Console.WriteLine("{0,-5} |{1,-20} |", c.id, c.nome);
                Console.WriteLine("-----------------------------");
            }
            Console.ReadLine();
        }

        protected override Mesa ObterRegistro() {

            Console.Write("Informe o nome da mesa:");
            string nome = Console.ReadLine();

            Mesa mesa = new Mesa(nome);

            return mesa;
        }
    }
}
