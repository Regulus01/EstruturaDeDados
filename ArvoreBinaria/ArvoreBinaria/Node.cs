namespace ArvoreBinaria;

class Node
{
    public int Elemento { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public static Node? Initialize()
    {
        return null;
    }

    private Node(int elemento)
    {
        Elemento = elemento;
        Left = null;
        Right = null;
    }

    public static void Print(Node? no)
    {
        if (no != null)
        {
            Console.WriteLine(no.Elemento);
            Print(no.Right);
            Print(no.Left);
        }
    }

    public static Node? BuscarElemento(Node? no, int elemento)
    {
        if (no != null)
        {
            if(no.Elemento == elemento) 
                return no;
            if (elemento >= no.Elemento)
                return BuscarElemento(no.Right, elemento);
            
            return BuscarElemento(no.Left, elemento);
        }

        return null;
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