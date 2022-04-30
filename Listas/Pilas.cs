using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas()
        {
            list = new List<string>();
        }

        public void Agregar(string dato)
        {
            lista.Add(dato);
        }
        private bool ValidarVacio()
        {
            return lista.Count == 0;
        }
   public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Lista Vacia");
            }
            lista.RemoveAt(lista.Count - 1);
        }

        public string Imprimir()
        {
            string datos = string.Empty;

            if (ValidaVacio())
            {
                return "Lista Vacia";
            }

            int count = lista.Count;
            for (int i = 0; i < count; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }
                datos += $"[{i}] - {lista[i]}";
            }
            return datos;
        }
    }
}