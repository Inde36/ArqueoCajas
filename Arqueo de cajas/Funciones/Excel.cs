using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Arqueo_de_cajas.Funciones
{
    internal class Excel
    {
        public double rellenarkash()
        {
            // Código para mostrar el cuadro de diálogo de entrada de número
            double numero;
            InputBox inputDialog = new InputBox();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
               return numero = inputDialog.GetNumero();

            }
            else {
                return numero = 0;
            }
        }
        public void get_table(string path, Form1 form1)
        {
            form1.dgdatos.Rows.Clear();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            
            var tables = result.Tables;
           
            foreach (DataTable table in tables) {
                var repetida = false;
                var contador = 0;
                var linea = 0;
                double num = 0;
                for (int i = 0; i < table.Rows.Count - 1; i++) {

                   

                        foreach (DataRow row2 in table.Rows)
                        {
                        if (contador > 2400) {

                            if (string.IsNullOrEmpty(row2[0].ToString())) {
                                break;
                            }
                            DateTime fechaexcel = DateTime.Parse(row2[0].ToString());

                            if (fechaexcel.ToShortDateString() == form1.dpfecha.Value.ToShortDateString())
                            {
                                if (repetida == false)
                                {
                                    var kash = "";
                                    form1.dgdatos.Rows.Add();
                                    DataGridViewRow row = form1.dgdatos.Rows[linea];
                                    row.Cells[0].Value = fechaexcel;
                                    var total = row2[23];
                                    total = Convert.ToDouble(total);
                                    row.Cells[1].Value = Math.Round(Convert.ToDouble(total), 3);



                                    num = rellenarkash();
                                    row.Cells[2].Value = num;
                                    num = Math.Round(num , 3);
                                    double dif = Math.Round(Convert.ToDouble(total), 3) - num;
                                    
                                    row.Cells[3].Value = Math.Round(Convert.ToDouble(dif), 3);
                                    linea++;
                                    repetida = true;
                                }
                                else {
                                    DataGridViewRow row = form1.dgdatos.Rows[linea -1 ];
                                    var total = row2[23];
                                    var valor = row.Cells[1].Value;
                                    total = Convert.ToDouble(total) + Convert.ToDouble(valor);
                                    row.Cells[1].Value = Math.Round(Convert.ToDouble (total),3);
                                   
                                    int dif = Convert.ToInt32(total) - Convert.ToInt32(num);

                                    row.Cells[3].Value = Math.Round(Convert.ToDouble(dif), 3);
                                }
                            }
                        }

                        contador++;
                        }

                    
                    
                }
               
            }

            stream.Close();
           
        }
    }
}
