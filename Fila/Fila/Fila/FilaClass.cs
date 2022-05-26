using System;

namespace Fila
{
    class FilaClass<T>
    {
        private Celula Primeira { get; set; }
        public Celula Ultima { get; set; }
        private int TotalDeElementos { get; set; }

        public FilaClass()
        {
            Primeira = null;
            Ultima = null;
            TotalDeElementos = 0;
        }

        public void AdicionaFim(T elemento)
        {

            if (TotalDeElementos == 0)
            {
                throw new ArgumentException("A lista está vazia!");
            }

            Celula nova = new Celula(elemento);

            if (TotalDeElementos == 0)
            {
                Primeira = Ultima = nova;
                TotalDeElementos++;
            }
            else
            {
                Ultima.Proxima = nova;
                Ultima = nova;
                TotalDeElementos++;
            }

        }

        public bool ExisteDado(T elemento)
        {
            Celula atual = Primeira;

            Iterator<T> it = new Iterator<T>(Primeira);

            int k = 0;
            while (it.MoveNext())
            {
                if (k < Tamanho())
                {
                    if (atual.Elemento.Equals(elemento))
                    {
                        return true;
                    }
                    atual = atual.Proxima;
                    k++;

                }
                else
                {

                    break;
                }
            }

            return false;
        }

        public bool IsEmpty()
        {
            if(Primeira == null)
            {
                return true;
            }

            return false;
        }

        public T Recupera()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("A lista está vazia!!");

            }

            else
            {
                return (T) Primeira.Elemento;
            }

        }

        public void Alterar(T elemento)
        {
            Celula novaCelula = new Celula(elemento);
            novaCelula.Proxima = Primeira.Proxima;
            Primeira = novaCelula;
        }

        public void Remover()
        {
            if (TotalDeElementos == 0)
            {
                throw new ArgumentException("A lista está vazia!");
            }

            else if (Primeira == Ultima)
            {

                Primeira = Ultima = null;
                TotalDeElementos--;
            }
            else
            {
                Primeira = Primeira.Proxima;
                TotalDeElementos--;
            }
        }

        public int Tamanho()
        {
            return TotalDeElementos;
        }

        public void Limpa()
        {
            Primeira = Ultima = null;
            TotalDeElementos = 0;
        }

    }
}
