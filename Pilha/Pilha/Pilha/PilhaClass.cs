namespace Pilha
{
    internal class PilhaClass<T>
    {
        private Celula? Top { get; set; }
        private int TotalElementos { get; set; }

        public PilhaClass()
        {
            Top = null;
            TotalElementos = 0;
        }

        public PilhaClass(T elemento)
        {
            Top = null;
            TotalElementos = 1;
            Push(elemento);
        }


        public void Push(T elemento)
        {
            if (TopNull())
            {
                Celula nova = new Celula(elemento);
                Top = nova;
                TotalElementos++;               
            }
        
            Celula novaCelula = new Celula(elemento);
            novaCelula.Proxima = Top;
            Top = novaCelula;
            TotalElementos++;
        }

        public bool IsEmpty()
        {
            if(Top == null)
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
                return (T) Top.Elemento;
            }

        }

        public void Alterar (T elemento)
        {

            Celula novaCelula = new Celula(elemento);
            novaCelula.Proxima = Top.Proxima;
            Top = novaCelula;
       
        }

        public void Remover()
        {
            Top = Top.Proxima;
            TotalElementos--;
        }

        public int Tamanho()
        {
            return TotalElementos;
        }

        public void limpa()
        {
            Top = null;
        }

        private bool TopNull()
        {
            if(Top == null)
            {
                return true;
            }

            return false;
        }
    }
}
