using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class RegistrarAsus : Registrar
    {
        public RegistrarAsus(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IMarca CrearReparacion(String Nombre)
        {
            Console.WriteLine(" - Registrar Asus / CrearReparacion()");
            Asus marca = new Asus("Asus", 2022);
            marca.Nombre = Nombre;
            return marca;
        }
    }
}

