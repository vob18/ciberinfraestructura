using MySqlConnector;
using System;
using System.Windows.Forms;

namespace ConexionMySQL
{
    /// <summary>
    /// MONSERRAT DELGADO 20220305
    /// FORMULARIO DE CONEXION A MYSQL
    /// </summary>
    public partial class Form1 : Form
    {

        private MySqlConnection conexion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
            bool verificada = Verificar();

            if (verificada)
            {
                try
                {
                    conexion = new MySqlConnection();
                    conexion.ConnectionString = "server=" + txtHost.Text + ";" + "user id=" + txtUsuario.Text + ";" + "password=" + txtContr.Text + ";";
                    conexion.Open();
                    MessageBox.Show("LA CONEXIÓN SE REALIZÓ CORRECTAMENTE", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message, "Error");
                }
                finally
                {
                    if (conexion.State == System.Data.ConnectionState.Open)
                        conexion.Close();
                }
            }
        }

        /// <summary>
        /// Verificar que los campos no esten vacíos 
        /// </summary>
        /// <returns></returns>
        public bool Verificar()
        {
            bool verificada = true;


            if (string.IsNullOrEmpty(txtHost.Text))
            {
                MessageBox.Show("El campo Host es obliatorio","Error");
                return verificada = false;
            }
            else if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El campo Usuario es obliatorio","Error");
                return verificada = false;
            }
            else if (string.IsNullOrEmpty(txtContr.Text))
            {
                MessageBox.Show("El campo Contraseña es obliatorio", "Error");
                return verificada = false;
            }
            else
                return verificada;
        }


    }
}
