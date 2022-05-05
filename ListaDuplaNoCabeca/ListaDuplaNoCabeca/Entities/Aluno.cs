using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDuplaNoCabeca.Entities
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno()
        {
            Nome = " ";
            Idade = 0;
        }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return Nome;
        }
        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   Nome == aluno.Nome &&
                   Idade == aluno.Idade;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Idade);
        }
    }
}
