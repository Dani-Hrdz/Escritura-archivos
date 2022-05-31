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

            string[] lines = {
                "Esta es la nueva escritura",
                "Esta es la segunda linea",
                "Fin del texto"
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
