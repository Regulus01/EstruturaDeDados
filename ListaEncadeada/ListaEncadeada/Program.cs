using System;
using ListaEncadeada.Entities;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno newAluno = new Aluno();
            ListaLigada<Aluno> ListaAluno = new ListaLigada<Aluno>();
            newAluno = new Aluno("Jose", 44);
            ListaAluno.AdicionaNoComeco(newAluno);
       
            newAluno = new Aluno("Iago", 42);
            ListaAluno.Adiciona(newAluno, 1);

            newAluno = new Aluno("Kaio", 42);
            ListaAluno.Adiciona(newAluno, 2);

            newAluno = new Aluno("Leleo", 42);
            ListaAluno.Adiciona(newAluno, 3);

            newAluno = new Aluno("lucas", 42);
            ListaAluno.Adiciona(newAluno, 4);
            
            Console.WriteLine("Nome: " + ListaAluno.Recupera(0).Nome + " - Idade: " +
            ListaAluno.Recupera(0).Idade);

            ListaAluno.Remove(1);
            

            Console.WriteLine("Nome: " + ListaAluno.Recupera(1).Nome + " - Idade: " +
            ListaAluno.Recupera(1).Idade);

            Console.WriteLine("Nome: " + ListaAluno.Recupera(2).Nome + " - Idade: " +
            ListaAluno.Recupera(2).Idade);

            //ListaAluno.RemoveFim();
            Console.WriteLine("Nome: " + ListaAluno.Recupera(3).Nome + " - Idade: " +
            ListaAluno.Recupera(3).Idade);

            Console.WriteLine("");
            bool existeDado = ListaAluno.ExisteDado(new Aluno("Kaio", 42));
            Console.WriteLine("Existe dado kaio? " + existeDado);

            Console.WriteLine("Adicionado no Fim \n");
            ListaAluno.AdicionaFim(new Aluno("Beto", 32));
            

            Console.WriteLine("Nome: " + ListaAluno.Recupera(4).Nome + " - Idade: " +
            ListaAluno.Recupera(4).Idade);

            Console.WriteLine("Total de elementos: " + ListaAluno.Tamanho());


        }
    }
}
