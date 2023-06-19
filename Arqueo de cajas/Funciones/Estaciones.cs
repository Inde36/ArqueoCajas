using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Arqueo_de_cajas.Funciones
{

    internal class Estaciones
    {


        public string[] get_estaciones ()
        {

            string[] estaciones = {"11. Textil",
                    "12. Balones",
                    "13. Aldaia",
                    "14. Genoves",
                    "15. Beneixama",
                    "21. Gandia",
                    "22. Naquera",
                    "23. Albal",
                    "31. La Carolina"};
            return estaciones;
        }
    }
}
