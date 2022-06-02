using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escritura_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt",true);
            string nom, mar, due;
            int ano;
            Console.Write("Ingresa el modelo del auto: ");
            nom = Console.ReadLine();
            Console.Write("Ingresa la marca del auto: ");
            mar = Console.ReadLine();
            Console.Write("Ingresa el año del auto: ");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el propietario del auto: ");
            due = Console.ReadLine();
            Autos a1 = new Autos(nom, mar, ano, due);
            sw.WriteLine(a1.desplegarDatos());//escribe en el archivo
            
            sw.Close();//se cierra el archivo
            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
