using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;


/// <summary>
/// Monserrat Delgado
/// </summary>
namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            reinicarColor();
            string contr = txtPass.Text;
            bool elementos;

            
            if (String.IsNullOrEmpty(txtPassConfirm.Text)|| String.IsNullOrEmpty(txtPass.Text))
                MessageBox.Show("Debe llenar todos los campos", "Error");
            else
            {
                elementos = verificarElementos(contr);
                if (!elementos)
                    MessageBox.Show("Por favor ingrese una contraseña que cumpla las condiciones", "Error");
                else
                {
                    if (contr == txtPassConfirm.Text)
                        MessageBox.Show("La contraseña ha sido validada", "Éxito");
                    else
                        MessageBox.Show("Las contraseñas no coinciden", "Error");

                }
            }
            
        }

        #region Resetear Color
        /// <summary>
        /// Resetar el color de la etiquetas de requerimientos a color girs
        /// </summary>
        public void reinicarColor()
        {
            lblMayuscula.ForeColor = Color.Gray;
            lblNumero.ForeColor = Color.Gray;
            lblEspecial.ForeColor = Color.Gray;
            lblMinuscula.ForeColor = Color.Gray;
        }
        #endregion

        #region Verificar Elementos
        /// <summary>
        /// Verificar que la entrada cumple con los requisitos establecidos
        /// </summary>
        /// <param name="contr">string</param>
        /// <returns></returns>
        public bool verificarElementos(string contr)
        {
            bool verificada = true;
            if (!new Regex(@"([a-z])+").IsMatch(contr))
            {
                lblMinuscula.ForeColor = Color.Red;
                verificada = false;
            }
            else
                lblMinuscula.ForeColor = Color.Green;

            if (!new Regex(@"([A-Z])+").IsMatch(contr))
            {
                lblMayuscula.ForeColor = Color.Red;
                verificada = false;
            }
            else
                lblMayuscula.ForeColor = Color.Green;

            if (!new Regex(@"(\d)+").IsMatch(contr))
            {
                lblNumero.ForeColor = Color.Red;
                verificada = false;
            }
            else
                lblNumero.ForeColor = Color.Green;

            if (!new Regex(@"(\W)+").IsMatch(contr))
            {
                lblEspecial.ForeColor = Color.Red;
                verificada = false;
            }
            else
                lblEspecial.ForeColor = Color.Green;

           
            return verificada;
        }
        #endregion
    }
}
