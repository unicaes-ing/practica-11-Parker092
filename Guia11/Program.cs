using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia11
{
    class Program
    {
        static void Main(string[] args)
        {
            //DIEGO PALACIOS NOVIEMBRE - 2019
            int mainOp;
            do
            {
                Console.WriteLine("===== Menu =====");
                Console.WriteLine(" 1 - Ejercicio 1.");
                Console.WriteLine(" 2 - Ejercicio 2.");
                Console.WriteLine(" 3 - Ejercicio 3.");
                Console.WriteLine(" 4 - Salir.");
                mainOp = Convert.ToInt32(Console.ReadLine());
                switch (mainOp)
                {
                    case 1:
                        //Ejercicio 1
                        Ejercicio1 A1 = new Ejercicio1();
                        A1.ejer1();
                        break;
                    case 2:
                        //Ejercicio 2
                        Ejercicio2 A2 = new Ejercicio2();
                        A2.ejer2();
                        break;
                    case 3:
                        //Ejercicio 3
                        Ejercicio3 A3 = new Ejercicio3();
                        A3.ejer3();
                        break;
                }
            } while (mainOp != 4);
            
        }
    }
}
