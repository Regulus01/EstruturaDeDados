using System;
using ListDuplamenteEncadeada.Entities;

namespace ListDuplamenteEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno newAluno = new Aluno();
            DoublyLinkedList<Aluno> ListaAluno = new DoublyLinkedList<Aluno>();
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

            newAluno = new Aluno("beto", 42);
            ListaAluno.AdicionaFim(newAluno);

            Console.WriteLine("Nome: " + ListaAluno.Recupera(0).Nome + " - Idade: " +
            ListaAluno.Recupera(0).Idade);


            Console.WriteLine("Nome: " + ListaAluno.Recupera(1).Nome + " - Idade: " +
            ListaAluno.Recupera(1).Idade);

            Console.WriteLine("Nome: " + ListaAluno.Recupera(2).Nome + " - Idade: " +
            ListaAluno.Recupera(2).Idade);

            Console.WriteLine("Nome: " + ListaAluno.Recupera(3).Nome + " - Idade: " +
            ListaAluno.Recupera(3).Idade);

            Console.WriteLine("Nome: " + ListaAluno.Recupera(4).Nome + " - Idade: " +
           ListaAluno.Recupera(4).Idade);
           
            Console.WriteLine("Nome: " + ListaAluno.Recupera(5).Nome + " - Idade: " +
           ListaAluno.Recupera(5).Idade);

            ListaAluno.Remove(4);
            Console.WriteLine("Total de elementos: " + ListaAluno.Tamanho());
        }
    }
}
