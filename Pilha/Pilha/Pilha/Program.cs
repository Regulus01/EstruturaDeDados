using Pilha;

PilhaClass<Aluno> novaPilha = new PilhaClass<Aluno>();

novaPilha.Push(new Aluno("Leleo", 13));
novaPilha.Push(new Aluno("Kaio", 12));
Console.WriteLine(novaPilha.Recupera());
novaPilha.Push(new Aluno("Ugo", 12));
Console.WriteLine(novaPilha.Recupera());

