var arvore = Node.Initialize();
arvore = Node.Insert(arvore, 1);
arvore = Node.Insert(arvore, 5);
arvore = Node.Insert(arvore, 2);
arvore = Node.Insert(arvore, 17);
arvore = Node.Insert(arvore, 4);

Node.TreePrint(arvore);
Console.WriteLine();

class Node
{
    public int Elemento { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public static Node? Initialize()
    {
        return null;
    }

    public Node(int elemento)
    {
        Elemento = elemento;
        Left = null;
        Right = null;
    }

    public static void TreePrint(Node? no)
    {
        if (no != null)
        {
            Console.WriteLine(no.Elemento);
            TreePrint(no.Right);
            TreePrint(no.Left);
        }
    }
    
    public static void TreeFree(Node? no)
    {
        if (no != null)
        {
            TreePrint(no.Right);
            TreePrint(no.Left);
            TreeFree(no);
        }
    }
    
    public static Node Insert(Node? no, int elemento)
    {
        if (no == null) // Se for nulo é a raiz
        {
            var node =  new Node(elemento);
            return node;
        }

        if (elemento >= no.Elemento)
            no.Right = Insert(no.Right, elemento);

        else if (elemento < no.Elemento)
            no.Left = Insert(no.Left, elemento);

        return no;
    }
}