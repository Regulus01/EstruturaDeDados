using System;

namespace ListaEncadeada.Entities
{
    class ListaLigada<T>
    {
        private Celula Primeira { get; set; }
        public Celula Ultima { get; set; }
        public int TotalDeElementos { get; set; }

        public ListaLigada()
        {
            Primeira = null;
            Ultima = null;
            TotalDeElementos = 0;
        }

        public ListaLigada(T elemento)
        {
            Primeira = null;
            Ultima = null;
            TotalDeElementos = 0;
            AdicionaNoComeco(elemento);
        }



        //adiciona no começo
        public void AdicionaNoComeco(object elemento)
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

        //adiciona na posicao
        public void Adiciona(T elemento, int posicao)
        {
            Celula nova = new Celula(elemento);

            if (TotalDeElementos == 0 || posicao == 0)
            {
                AdicionaNoComeco(elemento);
            }
            else
            {
                
                Celula atual = Primeira;

                Iterator<T> it = new Iterator<T>(Primeira);

                int k = 0;
                while (it.MoveNext())
                {
                    if(k < posicao - 1)
                    {
                        atual = atual.Proxima;                      
                        k++;
                    }
                    else
                    { 
                        
                        break;
                    }
                }
                
                Celula proxima = atual.Proxima;

                atual.Proxima = nova;
               
                nova.Proxima = proxima;
                Ultima = nova;
                TotalDeElementos++;
            }
        }

        //recupera a posicão
        public T Recupera(int posicao)
        {
            if (TotalDeElementos == 0)
            {
                throw new ArgumentException("A lista está vazia!!");
                
            }

            else if (posicao < 0 || posicao >= TotalDeElementos)
            {
                throw new ArgumentException("A posição " + posicao + 
                    " é invalida!");
                
            }

            else
            {
                Iterator<T> it = new Iterator<T>(Primeira);
                int i = 0;
                while (it.MoveNext())
                {
                    if (i != posicao)
                    {
                        it.Current();
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                return (T)it.Current();
            }

        }

        public void RemoveInicio()
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

        public void Limpa()
        {
            Primeira = Ultima = null;
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
        public void RemoveFim()
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
                if (k < Tamanho() -1)
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

        public void Remove(int posicao)
        {
            if (TotalDeElementos == 0)
            {
                throw new ArgumentException("A lista está vazia!");
            }
            else if(posicao == Tamanho() - 1)
            {
                RemoveFim();
            }
            else if(posicao == 0)
            {
                RemoveInicio();
            }
            else
            {
                Celula atual = Primeira;

                Iterator<T> it = new Iterator<T>(Primeira);

                int k = 0;
                while (it.MoveNext())
                {
                    if (k < Tamanho() - 1)
                    {
                        if (k == posicao - 1)
                        {
                            
                            atual.Proxima = atual.Proxima.Proxima;
                            TotalDeElementos--;
                            break;
                        }

                        atual = atual.Proxima;
                        it.Current();
                        k++;
                    
                    }
                    else
                    {

                        break;
                    }

                    
                }
            }
        }
    }
}
