using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    public class Sucursal
    {
        string nombre;
        string direccion;
        List<Veiculos> lista_veiculos;
        List<Accesorio> lista_accesorios;

        public Sucursal(string minombre, string midireccion, List<Veiculos> lista_veiculos, List<Accesorio> lista_accesorios)
        {
            nombre = minombre;
            direccion = midireccion;
            lista_veiculos = new List<Veiculos>();
            lista_accesorios = new List<Accesorio>();
        }
    }
}
