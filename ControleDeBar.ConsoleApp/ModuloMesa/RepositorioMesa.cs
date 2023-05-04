using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa {
    internal class RepositorioMesa:RepositorioBase<Mesa> {

        public RepositorioMesa(List<Mesa> lista) {
            listaRegistros = lista;
        }
        public override Mesa SelecionarPorId(int id) {

            return base.SelecionarPorId(id);
        }
    }
}
