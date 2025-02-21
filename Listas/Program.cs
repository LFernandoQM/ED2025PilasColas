namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilas");

            Pilas pila = new Pilas(10);
            pila.Agregar("a");
            pila.Agregar("b");
            pila.Agregar("c");
            pila.Agregar("d");
            pila.Agregar("e");
            pila.Agregar("f");
            pila.Agregar("g");
            pila.Agregar("h");
            pila.Agregar("i");
            pila.Agregar("j");
            pila.Agregar("k");
            pila.Agregar("l");

            string datos = pila.Imprimir();
            Console.WriteLine(datos);

            pila.Eliminar();
            Console.WriteLine(pila.Imprimir());

            pila.Agregar("e");
            Console.WriteLine(pila.Imprimir());

            /*------------------------------------------------------------*/
            Console.WriteLine("\nColas");

            Colas cola = new Colas(10);
            cola.Agregar("a");
            cola.Agregar("b");
            cola.Agregar("c");
            cola.Agregar("d");
            cola.Agregar("e");
            cola.Agregar("f");
            cola.Agregar("g");
            cola.Agregar("h");
            cola.Agregar("i");
            cola.Agregar("j");
            cola.Agregar("k");
            cola.Agregar("l");

            string datos2 = cola.Imprimir();
            Console.WriteLine(datos2);

            cola.Eliminar();
            Console.WriteLine(cola.Imprimir());

            cola.Agregar("z");
            Console.WriteLine(cola.Imprimir());
        }
    }
}
