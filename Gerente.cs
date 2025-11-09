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