using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
        private List<string> lista;
        public Colas()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            lista.Add(dato);
        }
        private bool ValidarVacio()
        {
            return lista.Count > 0;
        }
        public void Eliminar()
        {
            if (ValidarVacio())
            {
                throw new Exception("Lista Vacia");
            }
            lista.RemoveAt(0);
        }
        public string Imprimir()
        {
            string datos = "";

            if (ValidarVacio())
            {
                return "Lista Vacia;";

            }
            int lstCount = lista.Count;
            for (int i = 0;i<lstCount; i++)
            {
                if (i > 0)
                {
                    datos = "/n";
                }
            }

            }

          }

        }
    

