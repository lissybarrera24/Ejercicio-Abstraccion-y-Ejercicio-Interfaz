public class Programa
{
    namespace MiProyectoConsola
    {
            static void Main(string[]args)
            {
                //Crear datos con objetos pre-cargados
                Telefono miTelefono = new Telefono("Samsung", "Galaxy S23");
                Laptop miLaptop = new Laptop("Dell", "XPS 15", 85);


                //Estado inicial
                Console.WriteLine("=== Estado Inicial ===");
                miTelefono.MostrarEstado();
                miLaptop.MostrarEstado();
                Console.WriteLine();

                //Encender dispositivos
                Console.WriteLine("Encendiendo Dispositivos");
                miTelefono.Encender();
                miLaptop.Encender();
                miTelefono.MostrarEstado();
                miLaptop.MostrarEstado();
                Console.WriteLine();

                //Apagar dispositivos
                Console.WriteLine("==== Apagando Dispositivos ===");
                miTelefono.Apagar();
                milaptop.Apagar();
                miTelefono.MostrarEstado();
                miLaptop.MostrarEstado();

            Console.WriteLine("\nPresiona cualqueir tecla para salir...");
            Console.ReadKey();
            }
        }
    }