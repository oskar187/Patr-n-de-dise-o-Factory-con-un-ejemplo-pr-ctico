using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class RegistrarDell : Registrar
    {
        public RegistrarDell(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IMarca CrearReparacion(String Nombre)
        {
            Console.WriteLine(" - Registrar Dell / CrearReparacion");

            Dell marca = new Dell("Dell");
            marca.Nombre = Nombre;

            return marca;
        }
    }
}
