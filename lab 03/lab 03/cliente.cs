using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class cliente
    {
        string nombre;
        public cliente(string minombre)
        {
            nombre = minombre;
        }
            
    }
    public class persona : cliente
    {
        string licencia;
        public persona(string minombre, string milicencia) : base(minombre)
        {
            licencia = milicencia;

        }
    }
    public class empresa : cliente
    {
        bool autorizacion;
        
        public empresa(string minombre, bool miautorizacion) : base(minombre)
        {
            autorizacion = miautorizacion;

        }
    }
    public class organizacion : cliente
    {
        bool autorizacion;

        public organizacion(string minombre, bool miautorizacion) : base(minombre)
        {
            autorizacion = miautorizacion;
        }
    }
}
