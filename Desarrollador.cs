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