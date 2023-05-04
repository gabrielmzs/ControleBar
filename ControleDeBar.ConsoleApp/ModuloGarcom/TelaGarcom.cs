using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarcom {
    internal class TelaGarcom : TelaBase<Garcom> {

        RepositorioGarcom repositorioGarcom;

        public TelaGarcom(RepositorioGarcom repositorioGarcom) {
            
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioBase = repositorioGarcom;
        }

        protected override void MostrarTabela(List<Garcom> registros) {
            Console.WriteLine("{0,-5} |{1,-20} |{2,-20}|", "ID", "Nome", "Telefone");
            Console.WriteLine("--------------------------------------------------");
            foreach (Garcom c in registros) {
                Console.WriteLine("{0,-5} |{1,-20} |{2,-20}|", c.id, c.nome, c.telefone);
                Console.WriteLine("--------------------------------------------------");
            }
            Console.ReadLine();
        }

        protected override Garcom ObterRegistro() {
            Console.Write("Digite o nome do Garçom: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o telefone do Garçom: ");
            string telefone = Console.ReadLine();

            Garcom garcom = new Garcom(nome, telefone);

            return garcom;
        }
    }
}
