using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia11
{
    class Ejercicio1
    {
        public void ejer1()
        {
            try
            {
                FileStream stream = new FileStream("datos.bin", FileMode.Create, FileAccess.Write);
                BinaryWriter archivo = new BinaryWriter(stream);
                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Fecha de nacimiento: ");
                string fecha = Console.ReadLine();
                Console.WriteLine("Sueldo: ");
                double sueldo = Convert.ToDouble(Console.ReadLine());
                archivo.Write(nombre);
                archivo.Write(fecha);
                archivo.Write(sueldo);
                archivo.Close();
                Console.WriteLine("Datos guardados...");
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
