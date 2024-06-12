using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Inmuebles
    {
        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string nomenclatura;

        public string Nomenclatura
        {
            get { return nomenclatura; }
            set { nomenclatura = value; }
        }



    }
}
