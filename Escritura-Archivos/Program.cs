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
            string nom;
            Console.Write("Ingresa un nombre: ");
            nom = Console.ReadLine();
            string[] lines =
            {
                nom
            };
            
            foreach(string line in lines)
            {
                sw.WriteLine(line);//escribe en el archivo
            }
            sw.Close();//se cierra el archivo
            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
