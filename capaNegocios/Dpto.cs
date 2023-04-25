using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    [Serializable]
    public class Dpto : Vivienda
    {
        private int nroPiso;
        private string nroDpto;

        //Constructor de la clase sin parametros
        public Dpto(string c, int n, string l, string p, string pro, int m2c, int np, string nd) : base( c, n, l, p, pro, m2c)
        {
            this.nroDpto=nd;
            this.nroPiso=np;
        }

        //Propiedades de los atributos
        public int NroPiso
        {
            set { this.nroPiso = value; }
            get { return this.nroPiso; }
        }
        
        public string NroDpto
        {
            set { this.nroDpto = value; }
            get { return this.nroDpto; }
        }

        public override string ToString()
        {
            return calle + " " + nro + " PISO: " + nroPiso + "DPTO: " + nroDpto + ", " + localidad + ", " + partido + ", " + provincia;
        }
    }
}
