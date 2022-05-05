using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplaNoCabeca.Entities
{
    class Iterator<T> : IEnumerator
    {
        private Celula Atual;

        public Iterator(Celula atual)
        {
            Atual = atual;
        }

        object IEnumerator.Current => Current();

        public object Current()
        {
            T elemento = (T)Atual.Elemento;
            Atual = Atual.Proxima;
            return elemento;
        }

        public bool MoveNext()
        {
            if (Atual != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
