using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    [Serializable]
    public class Casa : Vivienda
    {
        private int m2Terreno;

        //Constructor de la clase 
        public Casa(string c, int n, string l, string p, string pro, int m2c, int m2t) : base(c, n, l, p, pro, m2c)
        {
            this.m2Terreno = m2t;
        }

        //Propiedades de los atributos
        public int M2Terreno
        {
            set { m2Terreno = value; }
            get { return this.m2Terreno; }
        }

        public override string ToString()
        {
            return calle + " " + nro + ", " +localidad + ", " + partido + ", " + provincia ;
        }
    }
}
