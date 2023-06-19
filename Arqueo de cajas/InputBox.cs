using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arqueo_de_cajas
{
    public partial class InputBox : Form
    {
        private TextBox txtNumero;
        private Button btnAceptar;
      

        public InputBox()
        {
            InitializeComponent();
            InitializeForm();
        }
        public void InitializeForm()
        {
            txtNumero = new TextBox();
            btnAceptar = new Button();
            

            // Configuración del cuadro de texto
            txtNumero.Location = new System.Drawing.Point(12, 12);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new System.Drawing.Size(100, 20);
            Controls.Add(txtNumero);

            // Configuración del botón de aceptar
            btnAceptar.Location = new System.Drawing.Point(118, 12);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 23);
            btnAceptar.Text = "Aceptar";
            btnAceptar.Click += BtnAceptar_Click;
            AcceptButton = btnAceptar;
            Controls.Add(btnAceptar);

            // Configuración del formulario
            ClientSize = new System.Drawing.Size(200, 50);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kash";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public Double GetNumero()
        {
            double numero;
            if (double.TryParse(txtNumero.Text, out numero))
            {
                return numero;
            }
            return 0; // Valor por defecto en caso de que el número ingresado no sea válido
        }

    }
}
