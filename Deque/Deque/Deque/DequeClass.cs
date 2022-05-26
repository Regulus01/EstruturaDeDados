namespace Deque
{
    internal class DequeClass<T>
    {
        private Celula? Primeira { get; set; }
        public Celula? Ultima { get; set; }
        public int TotalDeElementos { get; set; }

        public DequeClass()
        {
            TotalDeElementos = 0;
        }

        public void InserirInicio(T elemento)
        {
            Celula nova = new Celula(elemento);

            if (TotalDeElementos == 0)
            {
                Primeira = Ultima = nova;
                TotalDeElementos++;
            }
            else
            {
                nova.Proxima = Primeira;
                Primeira = nova;
                TotalDeElementos++;
            }
        }

        public void InserirFim(T elemento)
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

        public int Tamanho()
        {
            return TotalDeElementos;
        }

        public T RecuperaInicio()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("A lista está vazia!!");

            }

            else
            {
                return (T)Primeira.Elemento;
            }

        }

        public T RecuperaFim()
        {
            if (IsEmpty())
            {
                throw new ArgumentException("A lista está vazia!!");

            }

            else
            {
                return (T)Ultima.Elemento;
            }

        }

        public void AlterarInicio(T elemento)
        {

            Celula novaCelula = new Celula(elemento);
            novaCelula.Proxima = Primeira.Proxima;
            Primeira = novaCelula;

        }


        public void AlterarFim(T elemento)
        {

            if (TotalDeElementos == 0)
            {
                throw new ArgumentException("A lista está vazia!");
            }
            Celula novaCelula = new Celula(elemento);
            Celula atual = Primeira;

            Iterator<T> it = new Iterator<T>(Primeira);

            int k = 0;
            while (it.MoveNext())
            {
                if (k < Tamanho() - 1)
                {
                    atual = atual.Proxima;
                    it.Current();
                    k++;
                }
                else
                {

                    break;
                }

                atual.Proxima = novaCelula;
                Ultima = novaCelula;
                
            }

        }

        public void RemoverInicio()
        {
            Primeira = Primeira.Proxima;
            TotalDeElementos--;
        }


        public void RemoverFim()
        {
            if (TotalDeElementos == 0)
            {
                throw new ArgumentException("A lista está vazia!");
            }

            Celula atual = Primeira;

            Iterator<T> it = new Iterator<T>(Primeira);

            int k = 0;
            while (it.MoveNext())
            {
                if (k < Tamanho() - 1)
                {
                    atual = atual.Proxima;
                    it.Current();
                    k++;
                }
                else
                {

                    break;
                }

                Ultima = atual;
                TotalDeElementos--;
            }
        }

        private bool IsEmpty()
        {
            if (Primeira == null)
            {
                return true;
            }

            return false;
        }

        public void Limpa()
        {
            Primeira = null;
            Ultima = null;
            TotalDeElementos = 0;
        }
    }
}
