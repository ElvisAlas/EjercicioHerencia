using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
 public  class Vertebrado : Animal
    {

        public string? Tipo { get; set; }
        public bool TienePatas { get; set; }
        public bool EsDomestico { get; set; }
        public bool EsHerbivoro { get; set; }
        public bool EsCarnivoro { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Tamaño: " + Tamano);
            Console.WriteLine("Familia: " + Familia);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Tiene Patas: " + (TienePatas ? "SI" : "NO"));
            Console.WriteLine("Es Doméstico: " + (EsDomestico ? "SI" : "NO") );
            Console.WriteLine("Es Herbívoro: " + (EsHerbivoro ? "SI" : "NO") );
            Console.WriteLine("Es Carnívoro: " + (EsCarnivoro ? "SI" : "NO")  );
        }

    }
}
