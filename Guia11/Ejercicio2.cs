using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia11
{
    class Ejercicio2
    {
        public void ejer2()
        {
            BinaryReader leer = null;
            try
            {
                Console.WriteLine("Datos:");
                FileStream stream = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
                leer = new BinaryReader(stream);
                do
                {
                    string nombre = leer.ReadString();
                    string fecha = leer.ReadString();
                    double sueldo = leer.ReadDouble();
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Edad: {fecha}");
                    Console.WriteLine($"Sueldo: {sueldo}");
                } while (true);
            }
            catch (Exception)
            {
                //throw;
            }
            finally
            {
                leer.Close();
                Console.ReadKey();
            }
        }
    }
}
