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