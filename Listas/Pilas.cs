using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Pilas
    {
        private List<string> lista;
        public Pilas(int elementos)
        {
            lista = new List<string>();
        }
        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        public bool EstaVacia()
        {
            return lista.Count == 0;
        }
        public void Eliminar()
        {
            if (EstaVacia())
            {
                throw new Exception("La pila esta vacia");
            }
            lista.RemoveAt(lista.Count - 1);
        }
        public string Imprimir()
        {
            string datos = string.Empty;

            for (int i = 0; i < lista.Count; i++)
            {
                string coma = (i == lista.Count - 1) ? "" : ",";
                datos += lista[i] + coma;
            }
            return datos;
        }
    }
}