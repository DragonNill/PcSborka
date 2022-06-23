using PcSborka.Entity;
<<<<<<< HEAD
using System.Windows;
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
>>>>>>> cbbf8d9f865399896303020726371375ab28ec26

namespace PcSborka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ProductInfoWindow.xaml
    /// </summary>
    public partial class ProductInfoWindow : Window
    {
        CreatePcForThePeopl_dbEntities DbContext;
        public CPU CPUID { get; set; }
        public MotherBoard MotherBoardID { get; set; }
        public Case CaseID { get; set; }
        public GPU GPUID { get; set; }
        public Cooler CoolerID { get; set; }
        public RAM RAMID { get; set; }
        public PowerSupply PowerSupplyID { get; set; }
<<<<<<< HEAD
        public Monitor MonitorID { get; set; }
        public Entity.Mouse MouseID { get; set; }
        public Entity.Keyboard KeyboardID { get; set; }
=======
>>>>>>> cbbf8d9f865399896303020726371375ab28ec26
        public int CurrentItem;

        public static Window creatingForm { get; set; }

        #region Constructs
        public ProductInfoWindow(CPU cpu, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            CPUID = cpu;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(MotherBoard motherBoard, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            MotherBoardID = motherBoard;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(Case @case, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            CaseID = @case;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(GPU gPU, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            GPUID = gPU;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(Cooler cooler, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            CoolerID = cooler;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(RAM rAM, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            RAMID = rAM;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(PowerSupply powerSupply, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            PowerSupplyID = powerSupply;
            CurrentItem = currentItem;
        }
<<<<<<< HEAD

        public ProductInfoWindow(Monitor monitor, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            MonitorID = monitor;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(Entity.Mouse mouse, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            MouseID = mouse;
            CurrentItem = currentItem;
        }

        public ProductInfoWindow(Entity.Keyboard keyboard, int currentItem)
        {
            InitializeComponent();
            DbContext = CreatePcForThePeopl_dbEntities.DBContext;
            KeyboardID = keyboard;
            CurrentItem = currentItem;
        }
=======
>>>>>>> cbbf8d9f865399896303020726371375ab28ec26
        #endregion 

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CheckItem(CurrentItem);
        }

        private void CheckItem(int currentItem)
        {
            switch (currentItem)
            {
                case 1:
                    Title_textBox.Text = CPUID.Name;
                    Cost_textBox.Text = $"Цена: {CPUID.Cost} руб.";
                    Charastericts_textBox.Text = CPUID.Сharacteristics;
                    Socket_textBox.Text = $"Сокет: {CPUID.Socket}";
                    Socket_textBox.Visibility = Visibility.Visible;
                    break;
                case 2:
                    Title_textBox.Text = MotherBoardID.Name;
                    Cost_textBox.Text = $"Цена: {MotherBoardID.Cost} руб.";
                    Charastericts_textBox.Text = MotherBoardID.Сharacteristics;
                    Socket_textBox.Text = $"Сокет: {MotherBoardID.Socket}";
                    Socket_textBox.Visibility = Visibility.Visible;
                    TypeMemory_textBox.Visibility = Visibility.Visible;
                    TypeMemory_textBox.Text = $"Тип памяти:{MotherBoardID.TypeMotherBoardMemory}";
                    Form_Factor_textBox.Visibility = Visibility.Visible;
                    Form_Factor_textBox.Text = $"Форм-фактор {MotherBoardID.Form_Factor}";
                    break;
                case 3:
                    Title_textBox.Text = CaseID.Name;
                    Cost_textBox.Text = $"Цена: {CaseID.Cost} руб.";
                    Charastericts_textBox.Text = CaseID.Сharacteristics;
                    Form_Factor_textBox.Visibility = Visibility.Visible;
                    Form_Factor_textBox.Text = $"Форм-фактор {CaseID.Form_Factor}";
                    break;
                case 4:
                    Title_textBox.Text = GPUID.Name;
                    Charastericts_textBox.Text = GPUID.Сharacteristics;
                    Cost_textBox.Text = $"Цена: {GPUID.Cost} руб.";
                    break;
                case 5:
                    Title_textBox.Text = CoolerID.Name;
                    Charastericts_textBox.Text = CoolerID.Сharacteristics;
                    Cost_textBox.Text = $"Цена: {CoolerID.Cost} руб.";
                    break;
                case 6:
                    Title_textBox.Text = RAMID.Name;
                    Cost_textBox.Text = $"Цена: {RAMID.Cost} руб.";
                    Charastericts_textBox.Text = RAMID.Сharacteristics;
                    TypeMemory_textBox.Visibility = Visibility.Visible;
                    TypeMemory_textBox.Text = $"Тип памяти:{RAMID.TypeMemory}";
                    break;
                case 7:
                    Title_textBox.Text = PowerSupplyID.Name;
                    Charastericts_textBox.Text = PowerSupplyID.Сharacteristics;
                    Cost_textBox.Text = $"Цена: {PowerSupplyID.Cost} руб.";
                    break;
                case 8:
<<<<<<< HEAD
                    Title_textBox.Text = MonitorID.Name;
                    Charastericts_textBox.Text = MonitorID.Сharacteristics;
                    Cost_textBox.Text = $"Цена: {MonitorID.Cost} руб.";
                    break;
                case 9:
                    Title_textBox.Text = MouseID.Name;
                    Cost_textBox.Text = $"Цена: {MouseID.Cost} руб.";
                    break;
                case 10:
                    Title_textBox.Text = KeyboardID.Name;
                    Cost_textBox.Text = $"Цена: {KeyboardID.Cost} руб.";
=======
                    //Title_textBox.Text = ;
                    //Cost_textBox.Text =;
                    break;
                case 9:
                    //Title_textBox.Text =;
                    //Cost_textBox.Text =;
                    break;
                case 10:
                    //Title_textBox.Text =;
                    //Cost_textBox.Text =;
>>>>>>> cbbf8d9f865399896303020726371375ab28ec26
                    break;
            }
        }

        private void AddToChoose_button_Click(object sender, RoutedEventArgs e)
        {
            switch (CurrentItem)
            {
                case 1:
                    ChooseCurrentItemShow.ComputerReadyNot.CPU = CPUID;
                    creatingForm.Close();
                    Close();
                    break;
                case 2:
                    ChooseCurrentItemShow.ComputerReadyNot.MotherBoard = MotherBoardID;
                    creatingForm.Close();
                    Close();
                    break;
                case 3:
                    ChooseCurrentItemShow.ComputerReadyNot.Case = CaseID;
                    creatingForm.Close();
                    Close();
                    break;
                case 4:
                    ChooseCurrentItemShow.ComputerReadyNot.GPU = GPUID;
                    creatingForm.Close();
                    Close();
                    break;
                case 5:
                    ChooseCurrentItemShow.ComputerReadyNot.Cooler = CoolerID;
                    creatingForm.Close();
                    Close();
                    break;
                case 6:
                    ChooseCurrentItemShow.ComputerReadyNot.RAM = RAMID;
                    creatingForm.Close();
                    Close();
                    break;
                case 7:
                    ChooseCurrentItemShow.ComputerReadyNot.PowerSupply = PowerSupplyID;
                    creatingForm.Close();
                    Close();
                    break;
                case 8:
<<<<<<< HEAD
                    ChooseCurrentItemShow.PeripheryReadyNot.Monitor = MonitorID;
                    creatingForm.Close();
                    Close();
                    break;
                case 9:
                    ChooseCurrentItemShow.PeripheryReadyNot.Mouse = MouseID;
                    creatingForm.Close();
                    Close();
                    break;
                case 10:
                    ChooseCurrentItemShow.PeripheryReadyNot.Keyboard = KeyboardID;
                    creatingForm.Close();
                    Close();
=======
                    //Title_textBox.Text = ;
                    //Cost_textBox.Text =;
                    break;
                case 9:
                    //Title_textBox.Text =;
                    //Cost_textBox.Text =;
                    break;
                case 10:
                    //Title_textBox.Text =;
                    //Cost_textBox.Text =;
>>>>>>> cbbf8d9f865399896303020726371375ab28ec26
                    break;
            }
        }
    }
}
