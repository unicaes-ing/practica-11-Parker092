using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Guia11
{
    class Ejercicio3
    {
        public void ejer3 ()
        {
            int op;
            int anchoReg = 20 + 4 + 4 + 16;
            int numReg = 0;
            FileStream fs;
            BinaryWriter bw;
            BinaryReader br;
            try
            {
                fs = new FileStream("alumnosN.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                bw = new BinaryWriter(fs);
                br = new BinaryReader(fs);
                numReg = Convert.ToInt32(Math.Ceiling((decimal)fs.Length / anchoReg));
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menú");
                    Console.WriteLine("1. Agregar alumno");
                    Console.WriteLine("2. Mostrar alumno");
                    Console.WriteLine("3. Buscar alumno");
                    Console.WriteLine("4. Salir");
                    Console.WriteLine("--------------------");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            //Agregar
                            try
                            {
                                Console.Clear();
                                numReg = Convert.ToInt32(Math.Ceiling((decimal)fs.Length / anchoReg));
                                bw.BaseStream.Seek(numReg * anchoReg, SeekOrigin.Begin);
                                Console.WriteLine("Ingrese los datos del alumno: ");
                                Console.WriteLine();
                                Console.WriteLine("Carnet: ");
                                string carnet = Console.ReadLine();
                                Console.WriteLine("Nombre: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Edad: ");
                                int edad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("CUM: ");
                                decimal cum = Convert.ToDecimal(Console.ReadLine());
                                bw.Write(carnet);
                                bw.Write(nombre);
                                bw.Write(edad);
                                bw.Write(cum);
                                Console.WriteLine();
                                Console.WriteLine("Los datos fueron almacenados correctamente.");
                                Console.ReadKey();
                            }
                            catch
                            {
                                Console.WriteLine("Ocurrio un problema con el archivo binario...");
                            }
                            break;
                        case 2:
                            //Mostrar
                            try
                            {
                                try
                                {
                                    numReg = Convert.ToInt32(Math.Ceiling((decimal)fs.Length / anchoReg));
                                    br.BaseStream.Seek(0, SeekOrigin.Begin);
                                    Console.Clear();
                                    Console.WriteLine("Datos de los alumnos.");
                                    Console.WriteLine();
                                    Console.WriteLine("{0, 4} {1,-24} {2,-10} {3,-12} {4, 5} ", "N", "Carnet", "Nombre", "Edad", "CUM");
                                    Console.WriteLine("==========================================================");
                                    int num = 1;
                                    do
                                    {
                                        string carnet = br.ReadString();
                                        string nombre = br.ReadString();
                                        int edad = br.ReadInt32();
                                        decimal cum = br.ReadDecimal();
                                        Console.WriteLine("{0,-4} {1,-24} {2, -10} {3, -12} {4, 5}", num, carnet, nombre, edad, cum);
                                        br.BaseStream.Seek(num * anchoReg, SeekOrigin.Begin);
                                        num++;
                                    } while (true);
                                }
                                catch (Exception)
                                {

                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Ocurrio un problema con el archivo binario...");
                            }
                            Console.ReadKey();
                            break;
                        case 3:
                            //Buscar
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Numero de la persona que desea buscar: ");
                                int n = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                numReg = Convert.ToInt32(Math.Ceiling((decimal)fs.Length / anchoReg));
                                if (n <= numReg)
                                {
                                    br.BaseStream.Seek((n - 1) * anchoReg, SeekOrigin.Begin);
                                    string carnet = br.ReadString();
                                    string nombre = br.ReadString();
                                    int edad = br.ReadInt32();
                                    decimal cum = br.ReadDecimal();
                                    Console.WriteLine("{0,-21}", carnet);
                                    Console.WriteLine("{0,-11}", nombre);
                                    Console.WriteLine("{0,-11}", edad);
                                    Console.WriteLine("{0:N2}", cum);
                                }
                                else
                                {
                                    Console.WriteLine("No existe el numero de la persona solicitada...");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Ocurrio un problema con el archivo binario...");
                            }
                            break;
                        case 4:
                            //Salir
                            Console.Clear();
                            Console.WriteLine("Presione cualquier tecla para salir.");
                            Console.ReadKey();
                            break;
                    }
                } while (op != 4);
            }
            catch (Exception)
            {

            }
        }
    }
}
