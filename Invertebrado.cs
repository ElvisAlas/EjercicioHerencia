namespace EjercicioHerencia
{
    public class Invertebrado : Animal
    {
        public string? Tipo { get; set; }
        public bool TienePatas { get; set; }
        public int NumeroPatas { get; set; }
        public bool TieneConcha { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Tamaño: " + Tamano);
            Console.WriteLine("Familia: " + Familia);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Tiene Patas: " + (TienePatas ? "SI" : "NO") );
            Console.WriteLine("Número de Patas: " +  NumeroPatas);
            Console.WriteLine("Tiene Concha: " + (TieneConcha ? "SI" : "NO") );
        }
    }
}
