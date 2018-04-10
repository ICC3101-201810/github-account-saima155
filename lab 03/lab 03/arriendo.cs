using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace lab_03
{
    public class arriendo
    {
        DateTime fechaInicial;
        DateTime fechaFinal;
        int montototal;
        public arriendo(cliente c, Veiculos v, Sucursal s,Accesorio a, DateTime mifechaInicial, DateTime mifechaFinal)
        {
            fechaFinal = mifechaFinal;
            fechaInicial = mifechaInicial;
        }
    }

}
