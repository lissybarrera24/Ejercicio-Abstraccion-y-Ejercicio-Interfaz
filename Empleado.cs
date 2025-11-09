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
