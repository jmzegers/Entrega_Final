using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo_2
{
    public partial class Menu_inicio : Form
    {
        public Menu_inicio()
        {
            InitializeComponent();
        }

        //Acá van los elementos del primer panel:

        private void Jugar_inicio_Click(object sender, EventArgs e)
        {
            StartGamePanel.Visible = true;
            StartGamePanel.Dock = DockStyle.Fill;

            int playerCash = 500000;
            List<Seed> playerSeeds = new List<Seed>();
            List<Cattle> playerCattle = new List<Cattle>();
            List<StorageBuilding> playerStorage = new List<StorageBuilding>();
            List<Alimento> playerFertilizer = new List<Alimento>();
            List<Alimento> playerPlantWater = new List<Alimento>();
            List<Alimento> playerAnimalFood = new List<Alimento>();
            List<Alimento> playerAnimalWater = new List<Alimento>();
            List<Remedio> playerVaccines = new List<Remedio>();
            List<Remedio> playerHerbicides = new List<Remedio>();
            List<Remedio> playerFungicides = new List<Remedio>();
            List<Remedio> playerPesticides = new List<Remedio>();

            List<Plantation> playerPlantation = new List<Plantation>();
            List<Animal> playerAnimals = new List<Animal>();

            Partida NewGame = new Partida("Nombre generico", 
                playerCash, playerSeeds, playerCattle, playerStorage,
                playerFertilizer, playerPlantWater, playerAnimalFood,
                playerAnimalWater, playerVaccines, playerHerbicides,
                playerFungicides, playerPesticides, playerPlantation,
                playerAnimals);
            Juego.PartidaList.Add(NewGame);
        }

        private void cargar_partida_inicio_Click(object sender, EventArgs e)
        {

        }

        private void salir_inicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Elementos del segundo panel:

        
        private void GroundOnlyButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            MainPanel.Dock = DockStyle.Right;
            /*
            MapPanel2.Dock = DockStyle.Left;
            Map.BackgroundColor = Color.Green;

            Map.Columns.Add("column1", " ");

            for (int i = 2; i < 101; i++)
            {
                string toString = Convert.ToString(i);

                string columnName = "column" + toString;
                Map.Columns.Add(columnName, toString);
                

                string rowName = "row" + toString;
                Map.Rows.Add(rowName, toString);
            }

            */
        }
        

        private void RiverOnlyButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            MainPanel.Dock = DockStyle.Fill;
            //MapPanel2.Dock = DockStyle.Left;
        }

        private void LakeOnlyButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            MainPanel.Dock = DockStyle.Fill;
            //MapPanel2.Dock = DockStyle.Left;
        }

        private void BothRiverAndLakeButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            MainPanel.Dock = DockStyle.Fill;
            //MapPanel2.Dock = DockStyle.Left;
        }

        private void ReturnButton1_Click(object sender, EventArgs e)
        {
            StartGamePanel.Dock = DockStyle.None;
        }






        //Elementos del SideBar:

        private void aMINISTRARGRANJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FarmAdminPanel.Visible = true;
            FarmAdminPanel.Dock = DockStyle.Fill;
        }

        private void pROPIEDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropertyMarketPanel.Visible = true;
            PropertyMarketPanel.Dock = DockStyle.Fill;
        }

        private void eDIFICACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdifMarketPanel.Visible = true;
            EdifMarketPanel.Dock = DockStyle.Fill;
        }

        private void cONSUMIBLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsMarketPanel.Visible = true;
            ConsMarketPanel.Dock = DockStyle.Fill;
        }

        private void mERCADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketPanel.Visible = true;
            MarketPanel.Dock = DockStyle.Fill;
        }







        //Elementos del panel principal:

        private void FarmAdminButton_Click(object sender, EventArgs e)
        {
            FarmAdminPanel.Visible = true;
            FarmAdminPanel.Dock = DockStyle.Fill;
        }

        private void MarketButton_Click(object sender, EventArgs e)
        {
            MarketPanel.Visible = true;
            MarketPanel.Dock = DockStyle.Fill;
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            YesButton.Visible = false;
            NoButton.Visible = false;
            DoYouLikeMapLabel.Visible = false;

            string moneyText = Convert.ToString(Juego.PartidaList[0].PlayerCash);
            MainPanelMoneyLabel.Text = "Dinero actual: $" + moneyText;
            MarketButton.Visible = true;
            FarmAdminButton.Visible = true;
        }

        private void NoButton_Click(object sender, EventArgs e)
        {

        }

        private void MainPanelNextTurnButton_Click(object sender, EventArgs e)
        {
            //turno += 1;
            int turn = 1;
            string turnText = Convert.ToString(turn);
            MainPanelTurnLabel.Text = "Turno" + turnText;
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveGameButton_Click(object sender, EventArgs e)
        {

        }









        //Panel de administración de la granja:

        private void ProductionAdminButton_Click(object sender, EventArgs e)
        {
            ProductionAdminPanel.Visible = true;
            ProductionAdminPanel.Dock = DockStyle.Fill;
        }

        private void StorageAdminButton_Click(object sender, EventArgs e)
        {
            /* Administrar almacenamiento: Si el jugador posee bodegas y existen productos almacenados,
             * entonces esta acción debe entregar un resumen de los productos almacenados y
             * permitir elegir cuales vender en el mercado. Al vender, debe sumarse instantáneamente
             * el monto al dinero del jugador (recordar que la ganancia final de la venta es el
             * precio de mercado x calidad del producto terminado).
             */

            List<StorageBuilding> storageList = Juego.PartidaList[0].playerBoughtStorage;

            if(storageList.Count != 0)
            {
                // Falta encontrar una manera buena de rellenar bien el DataGridView
                for(int i = 0; i < storageList.Count; i++)
                {
                    string productName = storageList[i].Name;
                    string rowNum = Convert.ToString(i + 1);
                    string rowName = "row" + rowNum;
                    StorageDataGridView.Rows.Add(rowName, productName);
                }

                List<string> nameList = new List<string>();
                List<Seed> seedList = Juego.Lista_Semillas;

                foreach(Seed s in seedList)
                {
                    string name = s.Name;
                    nameList.Add(name);
                }

                List<Cattle> animalList = Juego.Lista_Animales;

                foreach(Cattle c in animalList)
                {
                    string name = c.Name;
                    nameList.Add(name);
                }

                foreach(string s in nameList)
                {
                    List<Product> productList = new List<Product>();

                    /*var queryLondonCustomers = from cust in customers
                           where cust.City == "London"
                           select cust;
                    */

                }

                // Hay que rellenar bien el StorageContentComboBox, pero de tal manera que
                // ningún producto se repita.
                foreach (StorageBuilding sb in storageList)
                {
                    foreach(Product p in sb.Guardado)
                    {
                        
                    }
                }

                StorageContentComboBox.Visible = true;
            }
            else
            {
                NoStorageLabel.Visible = true;
                System.Threading.Thread.Sleep(2000);
                NoStorageLabel.Visible = false;
            }
        }

        private void StorageContentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProduct = StorageContentComboBox.SelectedIndex.ToString();

            StorageNumLabel.Visible = true;
            StorageNumericUpDown.Visible = true;
        }

        private void BackButton4_Click(object sender, EventArgs e)
        {
            FarmAdminPanel.Dock = DockStyle.None;
        }


        //Panel de administración de producción:

        private void AddWaterOrFoodButton_Click(object sender, EventArgs e)
        {
            AddWaterOrFoodButton.Visible = false;
            CureApplicationButton.Visible = false;
            FinishedProductButton.Visible = false;
            
            AnimalsOrPlantsLabel.Visible = true;
            AnimalsButton.Visible = true;
            PlantsButton.Visible = true;
            CureLabel.Text = "No";

            AnimalsOrPlantsLabel.Text = "¿A qué le desea alimentar?";
        }

        private void AnimalsButton_Click(object sender, EventArgs e)
        {
            string cureLabelText = CureLabel.Text;
            if (cureLabelText == "No")
            {
                AnimalsOrPlantsLabel.Visible = false;
                AnimalsButton.Visible = false;
                PlantsButton.Visible = false;

                WaterButton.Text = "Agua";
                FoodButton.Text = "Comida";
                
                AnimalFoodOrWaterLabel.Visible = true;
                WaterButton.Visible = true;
                FoodButton.Visible = true;
                AnimalFoodOrWaterOptionsLabel.Visible = true;

                PlantOrAnimalLabel.Text = "Animal";
            }
            else if (cureLabelText == "Yes")
            {
                //Se debería abrir la opción de aplicarle una vacuna a las vacas.

                List<Cattle> playerCattle = Juego.PartidaList[0].PlayerBoughtCattle;
                List<Cattle> sickCattle = new List<Cattle>();
                
                foreach(Cattle c in playerCattle)
                {
                    bool hasDisease = c.Disease;
                    if(hasDisease == true)
                    {
                        sickCattle.Add(c);
                    }
                }

                int sickNum = sickCattle.Count;
                SickLabel.Text = "Usted tiene " + sickNum + " animales enfermos";
                SickLabel.Visible = true;
                int vaccineNum = Juego.PartidaList[0].PlayerVaccines.Count;
                VaccineNumLabel.Text = "Usted tiene" + vaccineNum + " vacunas disponibles";
                VaccineNumLabel.Visible = true;
            }
        }

        private void PlantsButton_Click(object sender, EventArgs e)
        {
            string cureText = CureLabel.Text;
            AnimalsOrPlantsLabel.Visible = false;
            AnimalsButton.Visible = false;
            PlantsButton.Visible = false;
            
            if (cureText == "No")
            {
                AnimalFoodOrWaterLabel.Visible = true;
                WaterButton.Text = "Agua";
                WaterButton.Visible = true;
                FoodButton.Text = "Comida";
                FoodButton.Visible = true;
                AnimalFoodOrWaterOptionsLabel.Visible = true;

                PlantOrAnimalLabel.Text = "Plant";
            }
            else if (cureText == "Yes")
            {
                AnimalFoodOrWaterLabel.Visible = true;
                WaterButton.Text = "Fungicidas";
                WaterButton.Visible = true;
                HerbicidesButton.Visible = true;
                FoodButton.Text = "Pesticidas";
                FoodButton.Visible = true;
            }
        }

        private void WaterButton_Click(object sender, EventArgs e) //Pasa a ser Fungicidas.
        {
            string labelText = PlantOrAnimalLabel.Text;
            string cureLabel = CureLabel.Text;
            if (cureLabel == "No")
            {
                if (labelText == "Animal")
                {
                    int playerAnimalWaterAmount = Juego.PartidaList[0].PlayerAnimalWater.Count;
                    WaterNumericUpDown.Maximum = playerAnimalWaterAmount;
                    FoodNumericUpDown.Visible = true;
                }
                else if (labelText == "Plant")
                {
                    int playerPlantWaterAmount = Juego.PartidaList[0].PlayerPlantWater.Count;
                    WaterNumericUpDown.Maximum = playerPlantWaterAmount;
                    WaterNumericUpDown.Visible = true;
                }
            }
            else if (cureLabel == "Yes")
            {
                List<Plantation> plantationList = Juego.PartidaList[0].PlayerPlantation;
                List<Plantation> hasDiseaseList = new List<Plantation>();
                foreach(Plantation p in plantationList)
                {
                    bool hasDisease = p.Disease;
                    if (hasDisease == true)
                    {
                        hasDiseaseList.Add(p);
                    }
                }
                int diseaseAmount = hasDiseaseList.Count;
                SickLabel.Text = "Tiene " + diseaseAmount + " plantas enfermas";
                SickLabel.Visible = true;

                int fungicideAmount = Juego.PartidaList[0].PlayerFungicides.Count;
                VaccineNumLabel.Text = "Tiene" + fungicideAmount + " fungicidas";
                VaccineNumLabel.Visible = true;


            }
        }

        private void HerbicidesButton_Click(object sender, EventArgs e)
        {
            List<Plantation> plantationList = Juego.PartidaList[0].PlayerPlantation;
            List<Plantation> hasWeedsList = new List<Plantation>();

            foreach(Plantation p in plantationList)
            {
                bool hasWeeds = p.Weeds;
                if (hasWeeds == true)
                {
                    hasWeedsList.Add(p);
                }
            }

            int weedAmount = hasWeedsList.Count;
            SickLabel.Text = "Tiene " + weedAmount + " plantas con malezas";
            SickLabel.Visible = true;

            int herbicideAmount = Juego.PartidaList[0].PlayerHerbicides.Count;
            VaccineNumLabel.Text = "Tiene" + herbicideAmount + " fungicidas";
            VaccineNumLabel.Visible = true;
        }

        private void FoodButton_Click(object sender, EventArgs e) //Pasa a ser pesticidas.
        {
            if (CureLabel.Text == "No")
            {
                string text = PlantOrAnimalLabel.Text;
                if (text == "Animal")
                {
                    int playerAnimalFoodAmount = Juego.PartidaList[0].PlayerAnimalFood.Count;
                    FoodNumericUpDown.Maximum = playerAnimalFoodAmount;
                    FoodNumericUpDown.Visible = true;
                }
                else if (text == "Plant")
                {
                    int playerPlantFoodAmount = Juego.PartidaList[0].PlayerFertilizerList.Count;
                    FoodNumericUpDown.Maximum = playerPlantFoodAmount;
                    FoodNumericUpDown.Visible = true;
                }
            }
            else if (CureLabel.Text == "Si")
            {
                List<Plantation> plantationList = Juego.PartidaList[0].PlayerPlantation;
                List<Plantation> hasWormsList = new List<Plantation>();

                foreach(Plantation p in plantationList)
                {
                    bool hasWorms = p.Worms;
                    if (hasWorms == true)
                    {
                        hasWormsList.Add(p);
                    }
                }

                int wormsAmount = hasWormsList.Count;
                SickLabel.Text = "Tiene " + wormsAmount + " plantas con gusanos";
                SickLabel.Visible = true;

                int pesticideAmount = Juego.PartidaList[0].PlayerPesticides.Count;
                VaccineNumLabel.Text = "Tiene" + pesticideAmount + " fungicidas";
                VaccineNumLabel.Visible = true;
            }
        }

       

        private void FarmAdminDoneButton_Click(object sender, EventArgs e)
        {

        }


        private void CureApplicationButton_Click(object sender, EventArgs e)
        {
            CureLabel.Text = "Yes";
            AnimalsOrPlantsLabel.Text = "¿A qué le desea aplicar cura?";
            AnimalsOrPlantsLabel.Visible = true;

            AnimalsButton.Visible = true;
            PlantsButton.Visible = true;
        }

        private void FinishedProductButton_Click(object sender, EventArgs e)
        {
            /*Si alguna plantación o ganado ha llegado a su madurez
             * final, el jugador debe poder obtener su producto terminado. Para esto, pueden ocurrir
             * dos casos, si el jugador no tiene un bodega en su terreno o todas las bodegas están
             * a su capacidad máxima, entonces esta acción debe sacar la plantación/ganado del
             * terreno y venderla a precio mercado, sumando instantáneamente la venta al dinero del
             * jugador (recordar que la ganancia final de la venta es el precio de mercado
             * x calidad del producto terminado). Por otra parte, si el jugador posee espacio
             * en alguna bodega, entonces esta acción debe sacar la plantación/ganado del terreno
             * y guardar el producto en la bodega, de esta manera el jugador puede decidir cuándo
             * venderla. Es importante mencionar, que al momento de ejecutar esta acción se debe
             * calcular la calidad del producto terminado, la cual varía dependiendo del origen:
             * ⋄ Plantación: Salud x Calidad del terreno x Proporción de tierra del terreno
             * ⋄ Ganado: Salud x Unidades Actuales/ Unidades originales (Las unidades originales
             * del ganado dependen de la cantidad de tierra del terreno, esta se
             * calcula como: Unidades por defecto del animal x Proporción de tierra
             * del terreno.
             */

            List<Plantation> plantationList = Juego.PartidaList[0].PlayerPlantation;
            List<Plantation> maturePlantationList = new List<Plantation>();
            List<Animal> animalList = Juego.PartidaList[0].PlayerAnimals;
            List<Animal> matureAnimalList = new List<Animal>();

            //Calidad plantación: Salud x Calidad del terreno x Proporción de tierra del terreno.
            foreach (Plantation p in plantationList)
            {
                double quality = p.Health;
                int maturity = p.Maturity;
                if (maturity >= 100)
                {
                    maturePlantationList.Add(p);
                    Juego.PartidaList[0].PlayerPlantation.Remove(p);
                }
            }

            /* ⋄ Ganado: Salud x Unidades Actuales/ Unidades originales (Las unidades originales
             * del ganado dependen de la cantidad de tierra del terreno, esta se
             * calcula como: Unidades por defecto del animal x Proporción de tierra
             * del terreno.
            */
            int storageAmount = Juego.PartidaList[0].playerBoughtStorage.Count;

            foreach (Animal a in animalList)
            {
                int maturity = a.Maturity;
                if (maturity >= 100)
                {
                    matureAnimalList.Add(a);
                    Juego.PartidaList[0].PlayerAnimals.Remove(a);
                }
            }

            // Acá se encarga de agarrar las plantas y ganados maduros y dejarlos en
            // los StorageBuilding disponibles.
            for(int i = 0; i < storageAmount; i++)
            {
                if(Juego.PartidaList[0].playerBoughtStorage[i].IsFull == false)
                {
                    while(matureAnimalList.Count != 0 || 
                        Juego.PartidaList[0].playerBoughtStorage[i].Guardado.Count <= 
                        Juego.PartidaList[0].playerBoughtStorage[i].Maxcapacity)
                    {
                        Animal a = matureAnimalList[0];
                        Juego.PartidaList[0].playerBoughtStorage[i].Guardado.Add(a);
                        matureAnimalList.RemoveAt(0);
                    }

                    while(maturePlantationList.Count != 0 ||
                        Juego.PartidaList[0].playerBoughtStorage[i].Guardado.Count <=
                        Juego.PartidaList[0].playerBoughtStorage[i].Maxcapacity)
                    {
                        Plantation p = maturePlantationList[0];
                        Juego.PartidaList[0].playerBoughtStorage[i].Guardado.Add(p);
                        //Hay que encontrar una manera de poder guardar las plantas maduras en StorageBuilding.
                        maturePlantationList.RemoveAt(0);
                    }
                }
            }

            foreach(StorageBuilding sb in Juego.PartidaList[0].playerBoughtStorage)
            {
                int maxcapacity = sb.Maxcapacity;
                
                if(sb.Guardado.Count >= maxcapacity)
                {
                    sb.IsFull = true;
                }
            }

            // Falta multiplicar el precio de venta por la calidad del producto.
            int totalSellingPrice = 0;
            if(matureAnimalList.Count != 0)
            {
                foreach(Animal a in matureAnimalList)
                {
                    int sellingPrice = a.BaseSellingPrice;
                    totalSellingPrice += sellingPrice;
                }
            }
            
            if(maturePlantationList.Count != 0)
            {
                foreach(Plantation p in maturePlantationList)
                {
                    int sellingPrice = p.SalesPrice;
                    totalSellingPrice += sellingPrice;
                }
            }

            Juego.PartidaList[0].PlayerCash += totalSellingPrice;
        }

        private void StorageDoneButton_Click(object sender, EventArgs e)
        {
            int productQuantity = Convert.ToInt32(Math.Round(StorageNumericUpDown.Value));
            string selectedProduct = StorageContentComboBox.SelectedIndex.ToString();

            List<StorageBuilding> storageList = Juego.PartidaList[0].playerBoughtStorage;
            List<Product> productList = new List<Product>();
            foreach(StorageBuilding sb in storageList)
            {
                foreach(Product p in sb.Guardado)
                {
                    string name = p.Name;
                    if (name == selectedProduct)
                    {
                        productList.Add(p);
                    }
                }
            }

            // Falta ajustar el precio de venta respecto a la calidad del producto.
            int totalSellingPrice = 0;
            foreach (Product p in productList)
            {
                int sellingPrice = p.BaseSellingPrice;
                totalSellingPrice += sellingPrice;
            }

            Juego.PartidaList[0].PlayerCash += totalSellingPrice;
        }

        private void BackButton5_Click(object sender, EventArgs e)
        {
            PlantOrAnimalLabel.Text = "Hola";
            CureLabel.Text = "Hola";
            AnimalsOrPlantsLabel.Visible = false;
            AnimalsButton.Visible = false;
            PlantsButton.Visible = false;
            AnimalFoodOrWaterLabel.Visible = false;
            FoodButton.Visible = false;
            WaterButton.Visible = false;
            WaterNumericUpDown.Visible = false;
            FoodNumericUpDown.Visible = false;
            AnimalFoodOrWaterOptionsLabel.Visible = false;
            FarmAdminDoneButton.Visible = false;
            
            ProductionAdminPanel.Dock = DockStyle.None;
            ProductionAdminPanel.Visible = false;
        }






        //Mercado general:

        private void EdifMarketButton_Click(object sender, EventArgs e)
        {
            EdifMarketPanel.Visible = true;
            EdifMarketPanel.Dock = DockStyle.Fill;
        }

        private void PropMarketButton_Click(object sender, EventArgs e)
        {
            PropertyMarketPanel.Visible = true;
            PropertyMarketPanel.Dock = DockStyle.Fill;
        }

        private void ConsMarketButton_Click(object sender, EventArgs e)
        {
            ConsMarketPanel.Visible = true;
            ConsMarketPanel.Dock = DockStyle.Fill;
        }

        private void SeedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Aca calcular el precio historico de la semilla elegida
            string selectedItem = SeedComboBox.Items[EdifOptionsComboBox.SelectedIndex].ToString();

            SeedDataGrid.Rows.Add("SeedRow", selectedItem);
            SeedDataGrid.Columns.Add("PriceColumn", "Precio");

            //Hay que agregar los precios historicos de la semilla
            for (int i = 1; i < 31; i++)
            {
                string dayNumber = Convert.ToString(i);
                string columnName = "column" + dayNumber;

                SeedDataGrid.Columns.Add(columnName, "Precio dia" + dayNumber);
            }
        }

        private void BackButton6_Click(object sender, EventArgs e)
        {
            MarketPanel.Visible = false;
            MarketPanel.Dock = DockStyle.None;
        }





        //Mercado de edificaciones:

        private void BackButton_Click(object sender, EventArgs e)
        {
            EdifMarketDataGridView.Visible = false;
            EdifMarketDataGridView.DataSource = null;
            EdifMarketResultLabel.Visible = false;
            EdifMarketComboBox2.Visible = false;
            EdifMarketComboBox2.Items.Clear();

            EdifMarketPanel.Visible = false;
            EdifMarketPanel.Dock = DockStyle.None;
        }

        private void EdifOptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = EdifOptionsComboBox.Items[EdifOptionsComboBox.SelectedIndex].ToString();
            if (selectedItem == "Comprar plantación")
            {
                EdifMarketDataGridView.Columns.Add("NameColumn", "Nombre");
                EdifMarketDataGridView.Columns.Add("MaturityRateColumn", "Tiempo de madurez");
                EdifMarketDataGridView.Columns.Add("PriceColumn", "Precio");
                EdifMarketDataGridView.Visible = true;

                EdifMarketResultLabel.Text = "¿Qué semillas desea comprar?";
                EdifMarketResultLabel.Visible = true;

                List<Seed> seedList = Juego.Lista_Semillas;
                Seed semillaElegida = Juego.Lista_Semillas[0];

                int i = 1;
                string semillaElegidaNombre = EdifMarketComboBox2.Items[EdifMarketComboBox2.SelectedIndex].ToString();
                foreach (Seed s in seedList)
                {
                    string rowNumber = Convert.ToString(i);
                    string rowName = "Row" + rowNumber;
                    string name = s.Name;
                    EdifMarketDataGridView.Rows.Add(rowName, name);
                    if (name == semillaElegidaNombre)
                    {
                        semillaElegida = s;
                    }
                    i += 1;
                }

                foreach (Seed s in seedList)
                {
                    EdifMarketComboBox2.Items.Add(s.Name);
                }
                EdifMarketComboBox2.Visible = true;

                int price = semillaElegida.BaseSellingPrice;
                int currentMoney = Juego.PartidaList[0].PlayerCash;
                if (currentMoney < price)
                {
                    EdifMarketNotEnoughMoneyLabel.Visible = true;
                    System.Threading.Thread.Sleep(2000);
                    EdifMarketNotEnoughMoneyLabel.Visible = false;
                }

                else
                {
                    Juego.PartidaList[0].PlayerCash = currentMoney - price;
                    Juego.PartidaList[0].PlayerBoughtSeeds.Add(semillaElegida);

                    EdifMarketDataGridView.Visible = false;
                    EdifMarketDataGridView.DataSource = null;
                    EdifMarketResultLabel.Visible = false;
                    EdifMarketComboBox2.Visible = false;
                    EdifMarketComboBox2.Items.Clear();

                }

            }
            else if (selectedItem == "Comprar ganado")
            {
                EdifMarketDataGridView.Visible = true;
                EdifMarketResultLabel.Text = "Qué ganado desea comprar?";
                EdifMarketResultLabel.Visible = true;

                EdifMarketDataGridView.Columns.Add("NameColumn", "Nombre");
                EdifMarketDataGridView.Columns.Add("MaturityRateColumn", "Tiempo de madurez");
                EdifMarketDataGridView.Columns.Add("PriceColumn", "Precio");

                List<Cattle> cattleList = Juego.Lista_Animales;
                int i = 1;
                string chosenCattleName = EdifMarketComboBox2.Items[EdifMarketComboBox2.SelectedIndex].ToString();
                Cattle chosenCattle = Juego.Lista_Animales[0];

                foreach (Cattle c in cattleList)
                {
                    string cattleName = c.Name;
                    string rowNumber = Convert.ToString(i);
                    string rowName = "Row" + rowNumber;
                    EdifMarketDataGridView.Rows.Add(rowName, cattleName);

                    if (cattleName == chosenCattleName)
                    {
                        chosenCattle = c;
                    }
                    i += 1;
                }

                foreach (Cattle c in cattleList)
                {
                    EdifMarketComboBox2.Items.Add(c.Name);
                }
                EdifMarketComboBox2.Visible = true;
                int currentMoney = Juego.PartidaList[0].PlayerCash;
                int price = chosenCattle.PurchasePrice;

                if(currentMoney < price)
                {
                    EdifMarketNotEnoughMoneyLabel.Visible = true;
                    System.Threading.Thread.Sleep(2000);
                    EdifMarketNotEnoughMoneyLabel.Visible = false;
                }
                else
                {
                    Juego.PartidaList[0].PlayerCash = currentMoney - price;
                    Juego.PartidaList[0].PlayerBoughtCattle.Add(chosenCattle);

                    EdifMarketDataGridView.Visible = false;
                    EdifMarketDataGridView.DataSource = null;
                    EdifMarketResultLabel.Visible = false;
                    EdifMarketComboBox2.Visible = false;
                    EdifMarketComboBox2.Items.Clear();
                }
            }
            else if (selectedItem == "Comprar almacenamiento")
            {
                EdifMarketDataGridView.Visible = true;
                EdifMarketDataGridView.Columns.Add("NameColumn", "Nombre");
                EdifMarketDataGridView.Columns.Add("PriceColumn", "Precio");

                List<StorageBuilding> storageList = Juego.Lista_Almacenamiento;
                int i = 1;
                foreach(StorageBuilding sb in storageList)
                {
                    string name = sb.Name;

                    string rowNumber = Convert.ToString(i);
                    string rowName = "Row" + rowNumber;
                    EdifMarketDataGridView.Rows.Add(rowName, name);

                    EdifMarketComboBox2.Items.Add(name);
                    i += 1;
                }
                EdifMarketResultLabel.Visible = true;
                EdifMarketResultLabel.Text = "¿Que edificio de almacenamiento desea comprar?";
                EdifMarketComboBox2.Visible = true;

                string chosenStorageName = EdifMarketComboBox2.Items[EdifMarketComboBox2.SelectedIndex].ToString();
                StorageBuilding chosenStorage = Juego.Lista_Almacenamiento[0];
                foreach(StorageBuilding sb in storageList)
                {
                    string name = sb.Name;
                    if (name == chosenStorageName)
                    {
                        chosenStorage = sb;
                    }
                }

                int price = chosenStorage.PurchasePrice;
                int currentMoney = Juego.PartidaList[0].PlayerCash;
                if(currentMoney < price)
                {
                    EdifMarketNotEnoughMoneyLabel.Visible = true;
                    System.Threading.Thread.Sleep(2000);
                    EdifMarketNotEnoughMoneyLabel.Visible = false;
                }
                else
                {
                    Juego.PartidaList[0].PlayerCash = currentMoney - price;
                    Juego.PartidaList[0].playerBoughtStorage.Add(chosenStorage);

                    EdifMarketDataGridView.Visible = false;
                    EdifMarketDataGridView.DataSource = null;
                    EdifMarketResultLabel.Visible = false;
                    EdifMarketComboBox2.Visible = false;
                    EdifMarketComboBox2.Items.Clear();
                }
            }
            else if (selectedItem == "Vender/destruir edificio")
            {
                
            }
        }

        private void EdifMarketDoneButton_Click(object sender, EventArgs e)
        {
            int individualPrice = 10000;

            string selectedItem = EdifOptionsComboBox.Items[EdifOptionsComboBox.SelectedIndex].ToString();
            int currentMoney = Juego.PartidaList[0].PlayerCash;
            int price = Juego.Lista_Semillas[0].BaseSellingPrice;

            if (currentMoney < price)
            {
                NotEnoughCureMoneyLabel.Visible = true;
                System.Threading.Thread.Sleep(2000);
                NotEnoughCureMoneyLabel.Visible = false;
            }

        }






        //Mercado de propiedades:

        private void PropertyMarketDoneButton_Click(object sender, EventArgs e)
        {
            int xAxisCoordinates = Convert.ToInt32(XAxisNumericUpDown.Value);
            int yAxisCoordinates = Convert.ToInt32(YAxisnumericUpDown.Value);


        }

        private void BackButton7_Click(object sender, EventArgs e)
        {
            PropertyMarketPanel.Visible = false;
            PropertyMarketPanel.Dock = DockStyle.None;
        }




        //Mercado de consumibles:

        private void BackButton2_Click(object sender, EventArgs e)
        {
            FoodPurchaseLabel.Visible = false;
            FoodPurchaseComboBox.Visible = false;
            ConsumableDataGridView1.Visible = false;
            FoodPurchaseButton.Visible = false;

            CurePurchaseLabel.Visible = false;
            CurePurchaseComboBox.Visible = false;
            ConsumableDataGridView1.Visible = false;
            CurePurchaseButton.Visible = false;

            ConsumableDataGridView1.DataSource = null;

            ConsMarketPanel.Dock = DockStyle.None;
        }

        private void FoodPurchaseButton_Click(object sender, EventArgs e)
        {
            FoodPurchaseLabel.Visible = true;
            FoodPurchaseComboBox.Visible = true;
            ConsumableDataGridView1.DataSource = null;
            ConsumableDataGridView1.Visible = true;
            FoodPurchaseButton.Visible = true;

            List<string> foodList = new List<string>();

            foreach(string s in FoodPurchaseComboBox.Items)
            {
                foodList.Add(s);
            }

            ConsumableDataGridView1.Columns.Add("DataColumn", " ");
            ConsumableDataGridView1.Columns.Add("NameColumn", "Nombre");
            ConsumableDataGridView1.Columns.Add("PriceColumn", "Precio");

            for (int i = 1; i <= 4; i++)
            {
                string rowNumber = Convert.ToString(i);
                string rowName = "Row" + rowNumber;

                string foodName = foodList[i];

                ConsumableDataGridView1.Rows.Add(rowName, foodName);
            }
        }

        private void FoodPurchaseDoneButton_Click(object sender, EventArgs e)
        {
            string chosenFood = Convert.ToString(FoodPurchaseComboBox.SelectedItem);
            int foodQuantity = Convert.ToInt32(FoodQuantityNumericUpDown.Value);

            int price = 500 * foodQuantity;

            int type = 0;

            if (chosenFood == "Fertilizante")
            {
                type = 1;
            }
            else if(chosenFood == "Riego")
            {
                type = 2;
            }
            else if (chosenFood == "Alimento para animales")
            {
                type = 3;
            }
            else if(chosenFood == "Agua para animales")
            {
                type = 4;
            }

            int currentMoney = Juego.PartidaList[0].PlayerCash;
            
            if (currentMoney < price)
            {
                NotEnoughFoodMoneyLabel.Visible = true;
                System.Threading.Thread.Sleep(2000);
                NotEnoughFoodMoneyLabel.Visible = false;
            }
            else
            {
                Alimento a = new Alimento(500, foodQuantity, 1);

                currentMoney = currentMoney - price;
                string currentMoneyText = Convert.ToString(currentMoney);
                ConsMarketMoneyLabel.Text = "Dinero actual: $" + currentMoneyText;

                Juego.PartidaList[0].PlayerCash = currentMoney;
                if (chosenFood == "Fertilizante")
                {
                    Juego.PartidaList[0].PlayerFertilizerList.Add(a);
                }
                else if (chosenFood == "Riego")
                {
                    Juego.PartidaList[0].PlayerPlantWater.Add(a);
                }
                else if (chosenFood == "Alimento para animales")
                {
                    Juego.PartidaList[0].PlayerAnimalFood.Add(a);
                }
                else if (chosenFood == "Agua para animales")
                {
                    Juego.PartidaList[0].PlayerAnimalWater.Add(a);
                }

                FoodPurchaseLabel.Visible = false;
                FoodPurchaseComboBox.Visible = false;
                ConsumableDataGridView1.Visible = false;
                FoodPurchaseButton.Visible = false;
            }

            
        }

        private void CurePurchaseButton_Click(object sender, EventArgs e)
        {
            CurePurchaseLabel.Visible = true;
            CurePurchaseComboBox.Visible = true;
            ConsumableDataGridView1.Visible = true;
            ConsumableDataGridView1.DataSource = null;
            CurePurchaseDoneButton.Visible = true;

            List<string> cureList = new List<string>();
            foreach (string s in CurePurchaseComboBox.Items)
            {
                cureList.Add(s);
            }

            ConsumableDataGridView1.Columns.Add("DataColumn", " ");
            ConsumableDataGridView1.Columns.Add("NameColumn", "Nombre");
            ConsumableDataGridView1.Columns.Add("PriceColumn", "Precio");

            for (int i = 1; i <= 4; i++)
            {
                string rowNumber = Convert.ToString(i);
                string rowName = "Row" + rowNumber;

                string cureName = cureList[i];

                ConsumableDataGridView1.Rows.Add(rowName, cureName);
            }

        }

        private void FoodPurchaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurePurchaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurePurchaseDoneButton_Click(object sender, EventArgs e)
        {
            string chosenCure = Convert.ToString(FoodPurchaseComboBox.SelectedItem);
            int cureQuantity = Convert.ToInt32(FoodQuantityNumericUpDown.Value);

            //Hay que restarle el precio de lo gastado al total que tiene el jugador.

            
            int currentMoney = Juego.PartidaList[0].PlayerCash;
            int type = 0;

            if (chosenCure == "Vacuna")
            {
                type = 1;
            }
            else if (chosenCure == "Herbicida")
            {
                type = 2;
            }
            else if (chosenCure == "Fungicida")
            {
                type = 3;
            }
            else if (chosenCure == "Pesticida")
            {
                type = 4;
            }

            int curePrice = Juego.Lista_Remedios[type - 1].Price;
            int price = curePrice * cureQuantity;

            if (currentMoney < price)
            {
                NotEnoughCureMoneyLabel.Visible = true;
                System.Threading.Thread.Sleep(2000);
                NotEnoughCureMoneyLabel.Visible = false;
            }

            else
            {
                Remedio a = new Remedio(500, 50, type);

                if (chosenCure == "Vacuna")
                {
                    for (int i = 1; i <= cureQuantity; i++)
                    {
                        Juego.PartidaList[0].PlayerVaccines.Add(a);
                    }
                }
                else if (chosenCure == "Herbicida")
                {
                    for (int i = 1; i <= cureQuantity; i++)
                    {
                        Juego.PartidaList[0].PlayerHerbicides.Add(a);
                    }
                }
                else if (chosenCure == "Fungicida")
                {
                    for (int i = 1; i <= cureQuantity; i++)
                    {
                        Juego.PartidaList[0].PlayerFungicides.Add(a);
                    }
                }
                else if (chosenCure == "Pesticida")
                {
                    for (int i = 1; i <= cureQuantity; i++)
                    {
                        Juego.PartidaList[0].PlayerFungicides.Add(a);
                    }
                }

                currentMoney = currentMoney - price;
                string currentMoneyText = Convert.ToString(currentMoney);
                ConsMarketMoneyLabel.Text = "Dinero actual: $" + currentMoneyText;
                Juego.PartidaList[0].PlayerCash = currentMoney;

                CurePurchaseLabel.Visible = false;
                CurePurchaseComboBox.Visible = false;
                ConsumableDataGridView1.DataSource = null;
                ConsumableDataGridView1.Visible = false;
                CurePurchaseButton.Visible = false;
            }
        }













        private void Menu_inicio_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void StartGamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

























        private void BackButton3_Click(object sender, EventArgs e)
        {
            MarketPanel.Dock = DockStyle.None;
        }







        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }





        private void SeedDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsMarketPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Map_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cARGARPARTIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
