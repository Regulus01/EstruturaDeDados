using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    internal class Celula
    {
        public Celula Proxima { get; set; }
        public object Elemento { get; set; }

        public Celula(Celula proxima, object elemento)
        {
            Proxima = proxima;
            Elemento = elemento;
        }

        public Celula(object elemento)
        {
            Elemento = elemento;
        }
    }
}
