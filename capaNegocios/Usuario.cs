using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace capaNegocio
{
    [Serializable]
    public class Usuario
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected string calle;
        protected int altura;
        protected string localidad;
        protected string partido;
        
        //Constructor de la clase sin parametros
        public Usuario(string nom, string apel, int undni, string cal,
            int alt, string loc, string par)
        {
            nombre = nom;
            apellido = apel;
            dni = undni;
            calle = cal;
            altura = alt;
            localidad = loc;
            partido = par;
        }

        //Propiedades de los atributos
        public string Nombre
        {
            set { nombre = value; }
            get { return this.nombre; }
        }
        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public int Dni
        {
            set { dni = value; }
            get { return dni; }
        }
        public string Calle
        {
            set { calle = value; }
            get { return calle; }
        }
        public int Altura
        {
            set { altura = value; }
            get { return altura; }
        }
        public string Localidad
        {
            set { localidad = value; }
            get { return localidad; }
        }
        public string Partido
        {
            set { partido = value; }
            get { return partido; }
        }

        public override string ToString()
        {
            return dni + " - " + nombre;
        }


    }
}
