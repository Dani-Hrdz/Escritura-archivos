using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura_Archivos
{
    class Autos
    {
        public string nombre, marca, dueno;
        public int ano;
        public Autos(string nombre, string marca, int ano, string dueno)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.ano = ano;
            this.dueno = dueno;
        }
        public string desplegarDatos()
        {
            return ("Registro del auto " + "\nModelo: " + nombre + "\nMarca: " + marca + "\nAño: " + ano + "\nPropietario: " + dueno);

        }
    }
}
