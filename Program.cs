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

