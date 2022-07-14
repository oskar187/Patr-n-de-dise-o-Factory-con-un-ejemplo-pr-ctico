using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Registrar
    {
        public String Nombre { get; set; }
        public Registrar(String Nombre)
        {
            this.Nombre = Nombre;
        }

        public void MetodoReparacion()
        {
            Console.WriteLine("Se ejecuta: MetodoReparacion");
            IMarca marca = CrearReparacion(Nombre);
            marca.reparar();
        }

        public abstract IMarca CrearReparacion(String Nombre);
    }
}
