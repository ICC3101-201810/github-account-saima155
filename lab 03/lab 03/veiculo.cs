using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class veiculos
    {
        string patente;
        public veiculos(string numpatente)
        {
            patente = numpatente;
        }

    }
    public class auto : veiculos
    {
        public auto(string numpatente) : base(numpatente)
        {

        }
    }
    public class acuatico : veiculos
    {
        public acuatico(string numpatente) : base(numpatente)
        {

        }
        public class moto : veiculos
        {
            public moto(string numpatente) : base(numpatente)
            {

            }
        }
        public class camion : veiculos
        {
            public camion(string numpatente) : base(numpatente)
            {

            }
        }
        public class bus : veiculos
        {
            public bus(string numpatente) : base(numpatente)
            {

            }
        }
        public class maquinariap : veiculos
        {
            public maquinariap(string numpatente) : base(numpatente)
            {

            }
        }
}
