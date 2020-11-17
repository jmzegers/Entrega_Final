﻿using System;
using System.Collections.Generic;

namespace Lab_2_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* En su método Main, pregunte al usuario si quiere utilizar un archivo para cargar la información
             * de la empresa
             */

            Method_Storage ms = new Method_Storage();

            string message = "Desea utilizar un archivo para cargar la información de su empresa?";
            List<string> options = new List<string>() { "Y", "N" };
            string answer = Convert.ToString(Console.ReadLine());

            string right_answer = ms.OptionFilter(options, message, answer);

            /*Si el usuario indica que si, entonces utilice BinaryFormatter para leer los datos de la empresa
             * del archivo ”empresa.bin”. Si el archivo no existe, con manejo de excepciones, solicite los datos al
             * usuario y escriba el archivo como en el párrafo anterior.
             */

            if (right_answer == "Y")
            {
                List<Empresa> EmpresaList = Empresa.Cargar_Datos_Empresa();
                
                if(EmpresaList.Count == 0)
                {
                    Console.WriteLine("Este archivo no existe!");
                    Console.WriteLine(" ");
                    Console.WriteLine("Por favor, ingrese el nombre de su empresa");
                    string nombre_empresa = Convert.ToString(Console.ReadLine());

                    Console.WriteLine(" ");
                    Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                    Console.WriteLine("Sin puntos ni guión");
                    int rut_empresa = 0;
                    while (true)
                    {
                        try
                        {
                            rut_empresa = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (InvalidCastException e)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Lo que ha dado no es un RUT válido");
                            Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                        }
                    }

                    int right_RUT = ms.RUT_Check(rut_empresa);
                    Empresa nueva_empresa = new Empresa(nombre_empresa, right_RUT);
                    List<Empresa> empresaList = new List<Empresa>();
                    Empresa.Almacenar_Datos_Empresa(empresaList);
                }
            }
            

            /* Si el usuario indica que no, entonces solicite al usuario que ingrese el nombre y rut de
             * la empresa y guarde estos datos en un archivo llamado ”empresa.bin” utilizando BinaryFormatter.
            */
            else if (right_answer == "N")
            {
                Console.WriteLine(" ");
                Console.WriteLine("Por favor, ingrese el nombre de su empresa");
                string nombre_empresa = Convert.ToString(Console.ReadLine());

                Console.WriteLine(" ");
                Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                Console.WriteLine("Sin puntos ni guión");
                int rut_empresa = 0;
                while (true)
                {
                    try
                    {
                        rut_empresa = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch(InvalidCastException e)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Lo que ha dado no es un RUT válido");
                        Console.WriteLine("Por favor, ingrese el RUT de su empresa");
                    }
                }

                int right_RUT = ms.RUT_Check(rut_empresa);
                Empresa nueva_empresa = new Empresa(nombre_empresa, right_RUT);
                List<Empresa> empresaList = new List<Empresa>();
                Empresa.Almacenar_Datos_Empresa(empresaList);
            }
        }
    }
}
