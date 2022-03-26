using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Pilas
    {
        private string[] array;
        private int max;
        private int tope;

        public Pilas(int tamano)
        {
            array = new string[tamano];
            max = array.Length - 1;
            tope = 0;

        }
        private bool ValidaVacio()
        {
            //    if (tope < 1)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            return (tope < 1);
        }

        private bool ValidaLleno()
        {
            return (tope > max);
        }
        public void Agregar(string dato)
        {
            if (ValidaLleno())
            {
                throw new Exception("Arreglo Lleno");
            }

            array[tope] = dato;
            tope++;
        }
        public void Eliminar()
        {
            if (ValidaVacio()) {
                throw new Exception("Arreglo Vacio");
            }
            tope--;
            array[tope] = null;

        }
     
    }
    public string Imprimir()
    {
        string datos = string.Empty;
        if (ValidaLleno())
        {
            return "Arreglo Vacio";
        }
        for (int i = 0; i < tope; i++)
        {
            {
                if (i>0)
            }
            datos += $"[{i}] - {array[i]}";
        }
        return datos;
    }
        
    }
   


