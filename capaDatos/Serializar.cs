using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading.Tasks;

namespace capaDatos
{
    public class Serializar
    {
        

        public static bool Guardar(object o)
       {
            bool ok;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("Curso.dat", FileMode.Create);
                bf.Serialize(miArchivo, o);
                miArchivo.Close();
                ok = true;
            }
            catch (Exception ex)
            {                
                ok = false;
            }
            return ok;
       }

        public static object Recuperar()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("Curso.dat", FileMode.Open);
                object o = bf.Deserialize(miArchivo);
                miArchivo.Close();
                return o;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool GuardarCasa(object o)
        {
            bool ok;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("CursoCasa.dat", FileMode.Create);
                bf.Serialize(miArchivo, o);
                miArchivo.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
            }
            return ok;
        }

        public static object RecuperarCasa()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("CursoCasa.dat", FileMode.Open);
                object o = bf.Deserialize(miArchivo);
                miArchivo.Close();
                return o;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool GuardarDpto(object o)
        {
            bool ok;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("CursoDpto.dat", FileMode.Create);
                bf.Serialize(miArchivo, o);
                miArchivo.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
            }
            return ok;
        }

        public static object RecuperarDpto()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream miArchivo = new FileStream("CursoDpto.dat", FileMode.Open);
                object o = bf.Deserialize(miArchivo);
                miArchivo.Close();
                return o;

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}

