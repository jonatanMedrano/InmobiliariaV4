using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    [Serializable]
    public class Vendedor : Usuario
    {
        private int legajo;

        //Contructor de la clase sin parametros
        public Vendedor(string nom, string apel, int dni, string cal, int alt, string loc, string par, int leg)
                        : base(nom, apel, dni, cal, alt, loc, par)            
        {
            this.legajo = leg;
        }

        //Propiedades de los atributos
        public int Legajo
        {
            set { this.legajo = value; }
            get { return this.legajo; }
        }
    }
}

