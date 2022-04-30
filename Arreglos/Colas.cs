using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Colas
    {
        private string[] array;
        private int max;
        private int principio;
        private int final;

        public Colas(int tamano)
        {
            array = new string[tamano];
            max = array.Length - 1;
            principio = 0;  
            final = 0;
        }
        private bool ValidadaVacio();
   {
            return ((principio < 1 && final < 1) 
                || principio == final); 
        }

        private bool ValidaLleno()
        {
            return (final > max);
        }

        public void Agregar(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }
            array[final] = dato;
            final++;
        }

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Arreglo Vacio");
            }
            array[principio] = null;
            principio++;
        }

        public String Imprimir()
        {
            string datos = string.Empty;
            if (ValidaVacio())
            {
                return ("Arreglo vacio");
            }
            for(int i = principio; i < final; i++)
            {
                if (i > principio)
                {
                    datos += "\n";
                }
                datos += $"[{i}] - {array[i]}";
            }
            return datos;
        }
        
        
    }
}