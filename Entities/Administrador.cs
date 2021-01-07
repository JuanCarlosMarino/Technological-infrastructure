using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologicalInfrastructure.Entities
{
    class Administrador
    {
        public int ID { get; set; }

        public String Usuario { get; set; }

        public String Contrasenia { get; set; }

        public String Nombre { get; set; }

        public String Apellido { get; set; }

        public String Correo { get; set; }

        public String Celular { get; set; }

        public String Documento { get; set; }

        public Administrador()
        {
        }
        public static bool validarUsuario(String Usuario)
        {
            bool respuesta = true;
            if (Usuario.Length > 20 || Usuario.Length <= 1)
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool validarContrasenia (String Contrasenia)
        {
            bool respuesta = true;
            if (Contrasenia.Length > 200 || Contrasenia.Length <= 1)
            {
                respuesta = false;
            }
            return respuesta;

        }
        public static bool validarNombre (String Nombre)
        {
            bool respuesta = true;
            if (Nombre.Length > 40 || Nombre.Length <= 1 )
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool validarApellido (String Apellido)
        {
            bool respuesta = true;
            if (Apellido.Length > 40 || Apellido.Length <= 1)
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool validarCorreo (String Correo)
        {
            bool respuesta = true;
            if (Correo.Length > 30 || Correo.Length <= 1 || !Correo.Contains("@") || !Correo.Contains("."))
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool validarCelular (String Celular)
        {
            bool respuesta = true;
            if (Celular.Length > 15 || Celular.Length <= 1)
            {
                respuesta = false;
            }
            return respuesta;
        }
        public static bool validarDocumento (String Documento)
        {
            bool respuesta = true;
            if (Documento.Length > 15 || Documento.Length <= 1)
            {
                respuesta = false;
            }
            return respuesta;
        }

    }
}
