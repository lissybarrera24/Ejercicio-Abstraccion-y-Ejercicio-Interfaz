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
