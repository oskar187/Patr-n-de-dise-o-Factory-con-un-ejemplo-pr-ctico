namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Registrar> lista = new List<Registrar>();

            lista.Add(new RegistrarAsus("Laptop Asus 15.5"));
            lista.Add(new RegistrarAsus("CPU Asus Core i7"));
            lista.Add(new RegistrarDell("Laptop Dell 17"));
            lista.Add(new RegistrarDell("CPU Dell Core i7"));
            lista.Add(new RegistrarDell("CPU Dell Core i3"));

            foreach (Registrar registrar in lista)
            {
                registrar.MetodoReparacion();
            }
        }
    }

}