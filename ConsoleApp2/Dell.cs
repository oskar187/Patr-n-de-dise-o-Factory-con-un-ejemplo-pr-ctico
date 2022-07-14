using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Dell : IMarca
    {
        public String Nombre { get; set; }
        public String Empresa { get; set; }
        public Dell(String Empresa)
        {
            this.Empresa = Empresa;
        }

        public void reparar()
        {
            Console.WriteLine(" - Estoy en Dell / reparar()");
            Console.WriteLine(" - Nombre: " + this.Nombre);
            Console.WriteLine(" - - - Empresa: " + this.Empresa);
        }
    }
}