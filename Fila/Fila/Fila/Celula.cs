namespace Fila
{
    class Celula
    {
        public Celula Proxima { get; set; }
        public object Elemento { get; set; }

        public Celula(Celula proxima, object elemento)
        {
            Proxima = proxima;
            Elemento = elemento;
        }

        public Celula(object elemento)
        {
            Elemento = elemento;
        }
    }
}