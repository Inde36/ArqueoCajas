using System.Security.Cryptography.X509Certificates;

namespace Arqueo_de_cajas
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {

            InitializeComponent();
            set_params();
            form1 = this;

        }

        private void btncargar_Click(object sender, EventArgs e)
        {

            //var ruta = "\\\\desktop-jeeti3t\\Users\\usuario\\Desktop\\Libro1.xlsx";
            var ruta = "\\\\192.168.5.50\\estaciones\\10.01 Gwin_TEXTIL\\0_Ventas diarias\\CAJA TEST.xlsx";
            var excel = new Funciones.Excel();
            excel.get_table(ruta, form1);

        }
        public void set_params()
        {
            var estaciones = new Funciones.Estaciones();
            string[] est = estaciones.get_estaciones();

            for (int i = 0; i < est.Length; i++)
            {
                cboxestacion.Items.Add(est[i]);

            };
            cboxestacion.SelectedIndex = 0;


        }







    }
}