using System.Collections;

namespace IteratorVETOR
{
    class Iterator<T> : IEnumerator
    {
        private T[] values;
        private int top = 0;

        public Iterator(T[] vetor)
        {
            values = vetor;

        }

        object IEnumerator.Current => Current();

        public object Current()
        {
            object item = values[top];
            return item;
        }
 
        public bool MoveNext()
        {
            top++;
            return (top < values.Length);
        }

        public void Reset()
        {
            top = -1;
        }
    }
}

