using Deque;

DequeClass<Aluno> novoDeque = new DequeClass<Aluno>();

novoDeque.InserirInicio(new Aluno("Leleo", 13));
novoDeque.InserirInicio(new Aluno("Kaio", 12));

novoDeque.InserirInicio(new Aluno("Ugo", 12));
novoDeque.InserirFim(new Aluno("Marley", 12));
Console.WriteLine(novoDeque.RecuperaInicio() + " Primeira");
Console.WriteLine(novoDeque.RecuperaFim() + " Ultima");
