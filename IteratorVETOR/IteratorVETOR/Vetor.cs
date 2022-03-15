using System;

namespace IteratorVETOR
{
    class Vetor<T>
    {
        private T[] vetor;
        private int tamanhoVetor;
        private int tamanho = 0; // qtd de itens no vetor

        public Vetor()
        {

        }
        public Vetor(int tam)
        {
            //cria um vetor de tamanho "tam"
            vetor = new T[tam];
            tamanhoVetor = tam;

        }

        //adicionar no vetorInicio
        public void AdicionaInicio(T elemento)
        {
            if (Tamanho() == TamanhoVetor())
            {
                Redimensionar();
            }
            // adiciona um item no vetor
            if (vetor[0] == null)
            {
                vetor[0] = elemento;
                tamanho++;
            }

        }

        //adicionar no vetorFim
        public void AdicionaFim(T elemento)
        {
            if (Tamanho() == TamanhoVetor())
            {
                Redimensionar();
            }
            // adiciona um item no vetor
            if (vetor[TamanhoVetor() - 1] == null)
            {

                vetor[TamanhoVetor() - 1] = elemento;

                tamanho++;
            }


        }

        //adiciona usando iterator
        public void AdicionarIt(T elemento, int posicao)
        {
       

            if (tamanhoVetor == TamanhoVetor())
            {
                Redimensionar();
            }

            if (posicao > TamanhoVetor())
            {
                throw new ArgumentException("Posição invalida");
            }
            // usando iterator
            Iterator<T> it = new Iterator<T>(vetor);
            while (it.MoveNext())
            {
                if (it.Current() == null)
                {
                    vetor[posicao] = elemento;
                    tamanho++;
                    break;
                }

            }


        }

        // remove item de uma posicão especifica
        public void Remove(int posicao)
        {
            if (PosicaoInvalida(posicao))
            {
                throw new ArgumentException("Posição invalida");
            }

            vetor[posicao] = default;
            tamanho--;
            

        }
        //remove da primeira posicão do vetor(vetor[0])
        public void RemoveInicio()
        {
            if (!(vetor[0] == null))
            {
                vetor[0] = default;
                tamanho--;
            
            }
        }
        //remove da ultima posicão do vetor
        public void RemoveFim()
        {

            if (!(vetor[TamanhoVetor() - 1] == null))
            {

                vetor[TamanhoVetor() - 1] = default;
                tamanho--;
          
            }
        }
        // limpa todo vetor
        public void Limpa()
        {
            for (int i = 0; i < TamanhoVetor(); i++)
            {
                vetor[i] = default;
                tamanho = 0;

            }
        }
        //imprime a posicão passada como argumento

        public T Recupera(int pos)
        {
            if (PosicaoInvalida(pos))
            {
                throw new ArgumentException("Posicao invalida!");
            }
            return vetor[pos];
        }

        private bool PosicaoInvalida(int pos)
        {
            if (vetor[pos] == null || pos > vetor.Length)
            {
             
                return true;
            }

            return false;
        }
        //verifica se o vetor está vazio
        public Boolean Vazio()
        {

            Iterator<T> it = new Iterator<T>(vetor);

            while (it.MoveNext())
            {
                if (!(it.Current() == null))
                {

                    return false;
                }

            }

            return true;
        }
        //Quantidade de elementos do vetor
        public int Tamanho()
        {

            return tamanho;
        }
        public int TamanhoVetor()
        {

            return tamanhoVetor;
        }

        //Redimenciona o vetor se estiver cheio
        public void Redimensionar()
        {
            
            T[] novoVetor = new T[TamanhoVetor() * 2];

            if (TamanhoVetor() == Tamanho())
            {
                for (int i = 0; i < TamanhoVetor(); i++)
                {
                    novoVetor[i] = vetor[i];
                }

                tamanhoVetor *= 2;
                vetor = novoVetor;
            }
      
        }

    }
}
