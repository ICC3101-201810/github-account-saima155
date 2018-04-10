using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class Veiculos
    {
        string patente;
        public Veiculos(string numpatente)
        {
            patente = numpatente;
        }

    }
    public class auto : Veiculos
    {
        public auto(string numpatente) : base(numpatente)
        {

        }
    }
    public class acuatico : Veiculos
    {
        public acuatico(string numpatente) : base(numpatente)
        {

        }
    }
    public class moto : Veiculos
    {
        public moto(string numpatente) : base(numpatente)
        {

        }
    }
    public class camion : Veiculos
    {
        public camion(string numpatente) : base(numpatente)
        {

        }
    }
    public class bus : Veiculos
    {
        public bus(string numpatente) : base(numpatente)
        {

        }
    }
    public class maquinariap : Veiculos
    {
        public maquinariap(string numpatente) : base(numpatente)
        {

        }
    }

}
