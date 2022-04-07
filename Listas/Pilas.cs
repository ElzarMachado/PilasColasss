using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> list;
        public Pilas()
        {
            list = new List<string>();
        }

        public void Agregar(string dato)
        {
            list.Add(dato);
        }
        private bool ValidarVacio()
        {
            return list.Count > 0;
        }
    }
}
