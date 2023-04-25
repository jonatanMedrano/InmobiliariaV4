using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using capaDatos;

//Seria la clase ADMINISTRADORA

namespace capaNegocio
{
    [Serializable]
    public class Inmobiliaria
    {
        private string nom;
        private List<Usuario> listausuarios;
        private List<Dpto> listadptos;
        private List<Casa> listacasas;

        public Inmobiliaria(string n)
        {
            nom = n;
            listausuarios = new List<Usuario>();
            listadptos = new List<Dpto>();
            listacasas = new List<Casa>();
        }

        //-------USUARIOS----------------------
        public List<Usuario> ListaUsuarios
        {
            get { return listausuarios; }
        }

        public void AgregarUsuario(Usuario u)
        {
            listausuarios.Add(u);
        }

        public void EliminarUsuario(Usuario u)
        {
            listausuarios.Remove(u);            
        }

        public static Inmobiliaria Recuperar()
        {
            Inmobiliaria i = (Inmobiliaria)Serializar.Recuperar();
            if (i == null)
                i = new Inmobiliaria("AMBA Propiedades");
            return i;
        }

        public bool guardar()
        {
            return Serializar.Guardar(this);
        }


        //-------DPTOS----------------------
        public void agregarDpto(Dpto d)
        {
            listadptos.Add(d);
        }

        public void eliminarDpto(Dpto d)
        {
            listadptos.Remove(d);
        }

        public List<Dpto> Dptos
        {
            get { return listadptos; }
        }

        public static Inmobiliaria RecuperarDpto()
        {
            Inmobiliaria i = (Inmobiliaria)Serializar.RecuperarDpto();
            if (i == null)
                i = new Inmobiliaria("AMBA Dpto");
            return i;
        }

        public bool guardarDpto()
        {
            return Serializar.GuardarDpto(this);
        }

        //-------CASAS----------------------
        public void agregarCasa(Casa c)
        {
            listacasas.Add(c);
        }

        public void eliminarCasa(Casa c)
        {
            listacasas.Remove(c);
        }

        public List<Casa> Casas
        {
            get { return listacasas; }
        }

        public static Inmobiliaria RecuperarCasa()
        {
            Inmobiliaria i = (Inmobiliaria)Serializar.RecuperarCasa();
            if (i == null)
                i = new Inmobiliaria("AMBA Casa");
            return i;
        }

        public bool guardarCasa()
        {
            return Serializar.GuardarCasa(this);
        }

    }
}
