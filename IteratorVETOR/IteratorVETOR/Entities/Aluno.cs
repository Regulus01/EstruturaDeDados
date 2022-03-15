using System;
using System.Collections.Generic;

namespace IteratorVETOR.Entities
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno()
        {
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
    }
}
