using System;
using IteratorVETOR.Entities;

namespace IteratorVETOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno newAluno = new Aluno();
            Vetor<Aluno> vetorAluno = new Vetor<Aluno>(3);
            newAluno = new Aluno("Jose", 44);
            vetorAluno.AdicionaInicio(newAluno);
            newAluno = new Aluno("Kaio", 44);
            vetorAluno.AdicionarIt(newAluno, 1);
            //adiciona no fim
            newAluno = new Aluno("Orochinho", 41);
            vetorAluno.AdicionaFim(newAluno);

            newAluno = new Aluno("leleo", 44);
            vetorAluno.AdicionarIt(newAluno, 3);


            Console.WriteLine("Nome: " + vetorAluno.Recupera(0).Nome + " - Idade: " +
            vetorAluno.Recupera(0).Idade);
            Console.WriteLine("Nome: " + vetorAluno.Recupera(1).Nome + " - Idade: " +
            vetorAluno.Recupera(1).Idade);
            Console.WriteLine("Nome: " + vetorAluno.Recupera(2).Nome + " - Idade: " +
             vetorAluno.Recupera(2).Idade);
            Console.WriteLine("Nome: " + vetorAluno.Recupera(3).Nome + " - Idade: " +
            vetorAluno.Recupera(3).Idade);
            vetorAluno.Remove(3);

            Console.WriteLine();

            Console.WriteLine("Elementos inseridos no vetor: " + vetorAluno.Tamanho());
            Console.WriteLine("Vetor vazio?: " + vetorAluno.Vazio());
            Console.WriteLine("Tamanho do vetor: " + vetorAluno.TamanhoVetor());


        }
    }
}
