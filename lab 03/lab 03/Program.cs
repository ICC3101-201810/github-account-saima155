using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) crear o administrar sucursal " + Environment.NewLine + "2) arriendo ");
            string opcion1;
            opcion1 = Convert.ToString(Console.ReadLine());
            if (opcion1 == "1")
            {
                Console.WriteLine("1) crear sucursal nueva " + Environment.NewLine + "2) administrar sucursal ");
                string opcion2;
                opcion2 = Convert.ToString(Console.ReadLine());
                if (opcion2 == "1")
                {
                    Console.WriteLine("ingrese el nombre de la sucursal nueva :");
                    string nombreSucursal;
                    nombreSucursal = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("ingrese la direccion de la sucursal nueva :");
                    string direccionSucursal;
                    direccionSucursal = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("1) desea ingresar veiculo" + Environment.NewLine + "2) si no quiere ingresar veiculo");
                    string opcion21;
                    opcion21 = Convert.ToString(Console.ReadLine());
                    if (opcion21 == "1")
                    {
                        Console.WriteLine("1) desea crear auto" + Environment.NewLine + "2) desea crear acuatico" + Environment.NewLine + "3) desea crear moto" + Environment.NewLine + "4) desea crear camion" + Environment.NewLine + "5) desea crear camion" + Environment.NewLine + "6) desea crear bus" + Environment.NewLine + "7) desea crear maquinaria");
                        string opcion22;
                        opcion22 = Convert.ToString(Console.ReadLine());
                    }
                    if (opcion21 == "2")
                    {

                    }


                }
                if (opcion2 == "2")
                {

                }

            }
        }
    }
    
    
}
