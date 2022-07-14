using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Asus : IMarca
    {
        public String Nombre { get; set; }
        public String Marca { get; set; }
        public int Año { get; set; }

        public Asus(String Marca, int Año)
        {
            this.Marca = Marca;
            this.Año = Año;
        }

        public void reparar()
        {
            Console.WriteLine(" - Estoy en Asus / reparar()");
            Console.WriteLine(" - - - Nombre Producto: " + this.Nombre);
            Console.WriteLine(" - - - Año: " + this.Año);
            Console.WriteLine(" - - - Marca: " + this.Marca);
        }
    }
}
