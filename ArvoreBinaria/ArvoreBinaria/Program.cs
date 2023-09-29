using ArvoreBinaria;

var arvore = Node.Initialize();
arvore = Node.Insert(arvore, 1);
arvore = Node.Insert(arvore, 5);
arvore = Node.Insert(arvore, 2);
arvore = Node.Insert(arvore, 17);
arvore = Node.Insert(arvore, 4);

Node.Print(arvore);
Console.WriteLine();

var noExistente = Node.BuscarElemento(arvore, 40);


if (noExistente == null)
    Console.WriteLine("No nao encontrado");
else
    Console.WriteLine("No encontrado!");