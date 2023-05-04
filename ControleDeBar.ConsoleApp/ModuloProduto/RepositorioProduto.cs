using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto {
    internal class RepositorioProduto:RepositorioBase<Produto> {
        public RepositorioProduto(List<Produto> lista) {
            listaRegistros = lista;
        }
        public override Produto SelecionarPorId(int id) {

            return base.SelecionarPorId(id);
        }
    }
}
