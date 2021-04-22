using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Libreria.Helpers
{
    public class Validador
    {


        public static string pedirString(string mensaje)
        {
            string resultado = "";
            do
            {
                Console.WriteLine(mensaje);
                resultado = Console.ReadLine();
                if (resultado == "") Console.WriteLine("Algo, no vacío");
            } while (resultado == "");

            return resultado;
        }

        public static int pedirInt(string mensaje)
        {
            string entrada = "";
            int resultado;
            while (entrada == "")
            {
                try
                {
                    Console.WriteLine(mensaje);
                    resultado = int.Parse(Console.ReadLine());
                    return resultado;

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Formato incorrecto");
                    entrada = "";
                }
            }
            return 0;

        }
    }
}
