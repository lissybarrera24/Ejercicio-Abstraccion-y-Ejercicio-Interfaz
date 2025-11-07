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


