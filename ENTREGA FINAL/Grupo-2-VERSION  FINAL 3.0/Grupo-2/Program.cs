using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Grupo_2
{
    [Serializable]
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Nombre, PP, BSP, PVT, FC, WC, mWL, mFL, WP, FP, PT  
            Juego.Lista_Semillas.Add(new Seed("Tomate", 100, 80, 15, 15, 20, 20, 30, 20, 30, 5, 0.15, 10, 0.2, 10, 0.2, 20, 100, 80, 250));
            Juego.Lista_Semillas.Add(new Seed("Manzana", 120, 90, 20, 20, 20, 10, 30, 20, 30, 4, 0.05, 10, 0.15, 12, 0.08, 15, 120, 90, 500));
            Juego.Lista_Semillas.Add(new Seed("Lechuga", 80, 60, 5, 15, 50, 30, 15, 20, 30, 7, 0.35, 15, 0.12, 16, 0.18, 10, 80, 30, 500));
            Juego.Lista_Semillas.Add(new Seed("Zanahoria", 130, 100, 10, 10, 15, 15, 30, 20, 30, 5, 0.2, 20, 0.1, 15, 0.09, 10, 130, 30, 500));

            Juego.Lista_Alimetos.Add(new Alimento(50, 10, 1, "Fertilizante"));//fertilizante
            Juego.Lista_Alimetos.Add(new Alimento(80, 15, 3, "Alimento para Animales"));//alimenrto animal
            Juego.Lista_Alimetos.Add(new Alimento(60, 20, 2, "Riego"));//riego
            Juego.Lista_Alimetos.Add(new Alimento(70, 20, 4, "Agua para Animales"));//agua animal
            Juego.Lista_Remedios.Add(new Remedio(60, 0.75, 5, "Pesticida"));//pesticida
            Juego.Lista_Remedios.Add(new Remedio(70, 0.85, 6, "Herbicida"));//herbicida
            Juego.Lista_Remedios.Add(new Remedio(50, 0.6, 7, "Fungicida"));//fungicida
            Juego.Lista_Remedios.Add(new Remedio(60, 0.7, 8, "Vacuna"));//vacuna

            //Nombre, PP, BSP, U, FC, WC, mWL, mFL, WP, FP, PT
            Juego.Animal_List.Add(new Animal("Vaca", 240, 300, 30, 22, 15, 5, 10, 10, 10, 10, 0.3, 10, 0.15, 2, 8, 0.2, 0, 8, 3));
            Juego.Animal_List.Add(new Animal("Oveja", 160, 140, 40, 12, 15, 5, 10, 10, 10, 7, 0.25, 12, 0.2, 4, 10, 0.3, 0, 12, 3));
            Juego.Animal_List.Add(new Animal("Cabra", 180, 100, 50, 12, 15, 5, 10, 10, 10, 6, 0.2, 12, 0.4, 6, 12, 0.3, 0, 14, 3));
            Juego.Animal_List.Add(new Animal("Chancho", 160, 220, 40, 24, 15, 5, 10, 10, 10, 8, 0.08, 25, 0.3, 5, 10, 0.3, 0, 10, 3));

            Juego.Lista_Almacenamiento.Add(new StorageBuilding("Bodega Grande", 100));
            Juego.Lista_Almacenamiento.Add(new StorageBuilding("Bodega Mediana", 50));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu_inicio());



        }
    }
}
