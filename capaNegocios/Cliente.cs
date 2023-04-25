using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    [Serializable]
    public class Cliente : Usuario
    {
        private string nroCli;

        //Contructor de la clase sin parametros
        public Cliente(string nom, string apel, int dni, string cal, int alt, string loc, string  par, string cli)
            : base(nom, apel, dni, cal, alt, loc, par)
        {
            nroCli = cli;
        }

        //Propiedades de los atributos
        public string NroCli
        {
            set { nroCli = value; }
            get { return nroCli; }
        }

    }
}
