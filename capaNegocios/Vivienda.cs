using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    [Serializable]
    public abstract class Vivienda
    {
        protected string calle;
        protected int nro;
        protected int m2Cubiertos;
        protected string localidad;
        protected string partido;
        protected string provincia;

        //Contructor de la clase 
        public Vivienda(string c, int n, string l, string p, string pro, int m2c)
        {
            this.calle = c;
            this.nro = n;
            this.m2Cubiertos = m2c;
            this.localidad = l;
            this.partido = p;
            this.provincia = pro;
        }

        //Propiedades de los atributos
        public String Calle
        {
            set { calle = value; }
            get { return this.calle; }
        }

        public int Nro
        {
            set { nro = value; }
            get { return this.nro; }
        }

        public int M2Cubiertos
        {
            set { m2Cubiertos = value; }
            get { return this.m2Cubiertos; }
        }

        public String Localidad
        {
            set { localidad = value; }
            get { return this.localidad; }
        }

        public String Partido
        {
            set { partido = value; }
            get { return this.provincia; }
        }

        public String Provincia
        {
            set { provincia = value; }
            get { return this.provincia; }
        }

    }
}
