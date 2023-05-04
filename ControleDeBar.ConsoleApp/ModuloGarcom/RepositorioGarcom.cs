using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarcom {
    internal class RepositorioGarcom:RepositorioBase<Garcom> {

        public RepositorioGarcom(List<Garcom> lista) {
            listaRegistros = lista;
        }
        public override Garcom SelecionarPorId(int id) {

            return base.SelecionarPorId(id);
        }
    }
}
