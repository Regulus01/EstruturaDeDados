using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplaNoCabeca.Entities
{
    internal class Celula
    {
        public Celula Proxima { get; set; }
        public Celula Anterior { get; set; }
        public object Elemento { get; set; }

        public Celula() { }
        public Celula(Celula anterior, Celula proxima, object elemento)
        {
            Anterior = anterior;
            Proxima = proxima;
            Elemento = elemento;
        }

        public Celula(object elemento)
        {
            Elemento = elemento;
        }
    }
}
