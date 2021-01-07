using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnologicalInfrastructure.Entities;

namespace TechnologicalInfrastructure.Controllers
{
    class BD
    {
        public static Administrador CargarUsuario(String Usuario)
        {
            Administrador administrador = new Administrador();
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "123456";
            String bd = "tecnologicalinfraestructure";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port =" + puerto +
                "; User Id =" + usuario + "; Password =" + password;

            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = null;
            try
            {
                String consulta = "SELECT * FROM administradores WHERE AD_usuario='"+Usuario+"';";
                MySqlCommand command = new MySqlCommand(consulta);
                command.Connection = conexionBD;
                conexionBD.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data += reader.GetString(0);
                    administrador.Nombre = reader.GetString(3);
                    administrador.Apellido = reader.GetString(4);
                    administrador.Documento = reader.GetString(7);
                    administrador.Celular = reader.GetString(6);
                    administrador.Correo = reader.GetString(5);
                    administrador.Usuario = reader.GetString(1);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return administrador;
        }
        public static bool validarUsuario (String Usuario)
        {
            bool estado = true;
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "123456";
            String bd = "tecnologicalinfraestructure";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port =" + puerto +
                "; User Id =" + usuario + "; Password =" + password;
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = null;
            try
            {
                String consulta = "SELECT AD_Usuario FROM Administradores WHERE AD_Usuario='"+Usuario+"';";
                MySqlCommand command = new MySqlCommand(consulta);
                command.Connection = conexionBD;
                conexionBD.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data += reader.GetString(0);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            if (data == Usuario)
            {
                estado = false;
            }
            return estado;
        }
        public static bool RegistrarUsuario (Administrador Usuario)
        {
            bool estado = false;
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "123456";
            String bd = "tecnologicalinfraestructure";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port =" + puerto +
                "; User Id =" + usuario + "; Password =" + password;
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = "Registro exitoso";            
            try
            {
                String consulta = "INSERT INTO Administradores(AD_Usuario, AD_Contrasenia, AD_Nombre, AD_Apellido, AD_Correo, AD_Celular, AD_Documento) VALUES('"+Usuario.Usuario+"','"+Usuario.Contrasenia+"','"+Usuario.Nombre+"','"+Usuario.Apellido+"','"+Usuario.Correo+"','"+Usuario.Celular+"','"+Usuario.Documento+"' );";
                MySqlCommand command = new MySqlCommand(consulta);
                command.Connection = conexionBD;
                conexionBD.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";
                }
                estado = true;        
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                estado = false;
            }
            finally
            {
                conexionBD.Close();
            }
            return estado;
        }        
        public static bool iniciarSesion (String Usuario, String Contrasenia)
        {
            bool respuesta = false;
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "123456";
            String bd = "tecnologicalinfraestructure";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port =" + puerto +
                "; User Id =" + usuario + "; Password =" + password;
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = null;
            try
            {
                String consulta = "SELECT AD_Contrasenia FROM administradores WHERE AD_Usuario='"+Usuario+"';";                
                MySqlCommand command = new MySqlCommand(consulta);
                command.Connection = conexionBD;
                conexionBD.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data += reader.GetString(0);
                    if (data == "" || data == null)
                    {
                        MessageBox.Show("The username or password is incorrect");
                    }
                }
                String cifrada = GetMD5(Contrasenia);
                if (data == cifrada)
                {
                    respuesta = true;
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect");
                }                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("The username or password is incorrect");
            }
            finally
            {
                conexionBD.Close();
            }            
            return respuesta;
        }     
        public static String GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public static String[] cargarUsuarios()
        {
            String[] usuarios;
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "123456";
            String bd = "tecnologicalinfraestructure";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port =" + puerto +
                "; User Id =" + usuario + "; Password =" + password;

            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = null;

            try
            {
                String consulta = "SELECT AD_Usuario FROM Administradores;";
                MySqlCommand command = new MySqlCommand(consulta);
                command.Connection = conexionBD;
                conexionBD.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            usuarios = data.Split('\n');
            return usuarios;
        }
        public static bool borrarUsuario(String Usuario)
        {
            bool estado = false;
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "root";
            String password = "123456";
            String bd = "tecnologicalinfraestructure";

            String cadenaConexion = "Database =" + bd + "; Data Source =" + servidor + "; Port =" + puerto +
                "; User Id =" + usuario + "; Password =" + password;

            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            MySqlDataReader reader = null;
            String data = null;

            try
            {
                String consulta = "DELETE FROM administradores WHERE AD_Usuario='"+Usuario+"';"; 
                MySqlCommand command = new MySqlCommand(consulta);
                command.Connection = conexionBD;
                conexionBD.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";
                }
                estado = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            return estado;
        }
        
    }
}
