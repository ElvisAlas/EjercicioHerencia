using EjercicioHerencia;

class Program
{
   public static void Main()
    {
        Vertebrado animalVertebrado1 = new Vertebrado
        {
            Nombre = "León",
            Color = "Amarillo",
            Tamano = 1.5,
            Familia = "Felidae",
            Tipo = "Mamífero",
            TienePatas = true,
            EsDomestico = false,
            EsHerbivoro = false,
            EsCarnivoro = true
        };

        Vertebrado animalVertebrado2 = new Vertebrado
        {
            Nombre = "Águila",
            Color = "Marrón",
            Tamano = 0.6,
            Familia = "Aquilidae",
            Tipo = "Ave",
            TienePatas = true,
            EsDomestico = false,
            EsHerbivoro = false,
            EsCarnivoro = true
        };

        Invertebrado animalInvertebrado1 = new Invertebrado
        {
            Nombre = "Araña",
            Color = "Negro",
            Tamano = 0.1,
            Familia = "Araneidae",
            Tipo = "Arácnido",
            TienePatas = true,
            NumeroPatas = 8,
            TieneConcha = false
        };

        Invertebrado animalInvertebrado2 = new Invertebrado
        {
            Nombre = "Caracol",
            Color = "Marrón",
            Tamano = 0.15,
            Familia = "Helicidae",
            Tipo = "Molusco",
            TienePatas = false,
            NumeroPatas = 0,
            TieneConcha = true
        };

        Console.WriteLine("Datos del primer animal vertebrado:");
        animalVertebrado1.Imprimir();

        Console.WriteLine("\nDatos del segundo animal vertebrado:");
        animalVertebrado2.Imprimir();

        Console.WriteLine("\nDatos del primer animal invertebrado:");
        animalInvertebrado1.Imprimir();

        Console.WriteLine("\nDatos del segundo animal invertebrado:");
        animalInvertebrado2.Imprimir();
    }
}

