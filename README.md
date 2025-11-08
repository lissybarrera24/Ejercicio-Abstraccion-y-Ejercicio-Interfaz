# Ejercicio-Abstraccion-y-Ejercicio-Interfaz
Ejercicios De Abstraccion 
Empleado.cs
public class Empleados
    public abstract class Empelados
{
    public abstract class Empleados
    {

    public string Nombre { get; set; }
    public int ID { get; set; }
    public double SalarioBase { get; set; }

    //Constructor Base
    public Empleados(string nombre, int id, double salarioBase)
    {
        Nombre= nombre;
        ID= id;
        SalarioBase= salarioBase;
    }

    public abstract double CalcularSalarioAnual();
    public abstract void MostrarInformacion()
   }

}


Gerente.cs

public class Gerente
{
    public class Gerente: Empleado
    {
        public double BonoAnual { get; set; }

        public Gerente(string nombre, int id, double salarioBase, double BonoAnual)
        :base(nombre,id,salarioBase)
        {
            BonoAnual=bonoAnual;
        }

        public override double CalcularSalarioAnual()
        {
            return (SalarioBase * 12) + BonoAnual;
        }

        public override void MostrarInformacion()
        {

            Console.WriteLine("=== Gerente ===");
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"Salario Base:{SalarioBase:C}");
            Console.WriteLine($"Bono Anual:{BonoAnual:C}");
            Console.WriteLine($"Salario Anual:{SalarioAnual():C}");
            Console.WriteLine();
        }
    }
}

Desarrollador.cs
public class Desarrollador
{
    publi class Desarrollador: Empleado
    {
        public string LenguajePrincipal { get; set; }

        public Desarrollador(string nombre, int id, double salarioBase, string lenguaje)
        :base(nombre, id, salarioBase)
        {
            LenguajePrincipal=Lenguaje;
        }

        public overroide double CalcularSalarioAnual()
        {
            return SalarioBase *12;
        }

        public overroide void MostrarInformacion()
        {
            Console.WriteLine("=== Desarrollador ===");
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"ID:{ID}");
            Consoloe.WriteLine($"Salario Base:{SalarioBase:C}");
            Console.WriteLine($"Lenguaje Principal: {LenguajePrincipal}");
            Console.WriteLine($"Salario Anual: {CalcularSalarioAnual():C}");
        }
    }
}

Programa.cs
public class Programa 
{
    class Programa
    {
        static void Main(string[]args)

        //Crear los objetos de las clases concretas
        Gerente gerente = new Gerente("Laura Gomez", 101,3500,5000);
        Desarrollador dev = new Desarrollador("Carlos Perez",102,2800,"C#,);
        Contador contador =new Contador("Maria Lopez", 103,2500,20,15);

        //Mostrar informacion de cada empelado
        gerente.MostrarInformacion();
        dev.MostrarInformacion();
        contador.MostrarInformacion();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
       }

    } 
}  

Ejercicio De Interfaz
IDispositivo Electronico.cs
public class Dispositivo Electronico
{
    namespace Dispositivo

    public interface IDispositivoElectronico
    {
        void Encender();
        void Apagar();
        void MostrarEstado();
    }
}

Telefono.cs

public class Telefono
{
    namespace Dispositivos
{
    Public class Telefono : IDispositivoElectronico
    {
        public string Marca { get; set;}
        public string Modelo { get; set; }
        public bool EstaEncendido { get; set; }

        public Telefono(String marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            EstaEncendido = false;
        }

        public void Encender()
        {
            EstaEncendido = true;
            Console.WriteLine($"El telefono {Marca} {Modelo} ha sido encendido.");
        }public class Laptop
{
    namespace Dispositivos
    {
        public class Laptop : IDispositivoElectronico
        {
            public string Marca { get; set; };
            public string Modelo { get; set; };
            public bool EstaEncendido { get; set; };
            public int NivelBateria { get; set; };


            public Laptop(string marca, string modelo, int NivelBateria)
            {
                Marca = marca;
                Modelo = modelo;
                NivelBateria = NivelBateria;
                EstaEncendido = false;
            }
            public void Encender()
            {
                EstaEncendido = true;
                Console.WriteLine($"La laptop {Marca} {Modelo} ha sido encendida");
            }
            public void Apagar()
        {
            EstaEncendido = false;
            Console.WriteLine($"La laptop {Marca} {Modelo} ha sido apagada.");
        }
        public void MostrarEstado()
        {
            string estado = EstaEncendido ? "Encendida" : "Apagada";
            Console.WriteLine($"Laptop: {Marca} {Modelo} - Estado: {estado} - Bateria: {NivelBateria}%");
        }
    }
}

Programa.cs
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

        public void Apagar
        {
            EstaEncendido = false;
            Console.WriteLine($ "El telefono {Marca} {Modelo} ha sido apagado.");
        }

        public void MostrarEstado();
        {
            string estado = EstaEncendido ? "Encendido" :"Apagado";
            Console.WriteLine($ "Telefono: {Marca} {Modelo}- Estado: {estado}");
        }

    }
}

Laptop.cs
public class Laptop
{
    namespace Dispositivos
    {
        public class Laptop : IDispositivoElectronico
        {
            public string Marca { get; set; };
            public string Modelo { get; set; };
            public bool EstaEncendido { get; set; };
            public int NivelBateria { get; set; };


            public Laptop(string marca, string modelo, int NivelBateria)
            {
                Marca = marca;
                Modelo = modelo;
                NivelBateria = NivelBateria;
                EstaEncendido = false;
            }
            public void Encender()
            {
                EstaEncendido = true;
                Console.WriteLine($"La laptop {Marca} {Modelo} ha sido encendida");
            }
            public void Apagar()
        {
            EstaEncendido = false;
            Console.WriteLine($"La laptop {Marca} {Modelo} ha sido apagada.");
        }
        public void MostrarEstado()
        {
            string estado = EstaEncendido ? "Encendida" : "Apagada";
            Console.WriteLine($"Laptop: {Marca} {Modelo} - Estado: {estado} - Bateria: {NivelBateria}%");
        }
    }
}

Program.cs
public class Programa 
{
    class Programa
    {
        static void Main(string[]args)

        //Crear los objetos de las clases concretas
        Gerente gerente = new Gerente("Laura Gomez", 101,3500,5000);
        Desarrollador dev = new Desarrollador("Carlos Perez",102,2800,"C#,);
        Contador contador =new Contador("Maria Lopez", 103,2500,20,15);

        //Mostrar informacion de cada empelado
        gerente.MostrarInformacion();
        dev.MostrarInformacion();
        contador.MostrarInformacion();

        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
       }

    } 
}  




