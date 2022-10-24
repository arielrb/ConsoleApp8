using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Electrodomestico
    {
        private int valor;
        private string nombre;

        public Electrodomestico(int valor, string nombre)
        {
            this.valor = valor;
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public int GetValor()
        {
            return valor;
        }

        public void SetValor(int valor)
        {
            this.valor = valor;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
