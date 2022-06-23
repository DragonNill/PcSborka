using PcSborka.Entity;
using PcSborka.Views.UserControls;
using System.Windows;
using static PcSborka.Classes.SessionData;

namespace PcSborka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChooseWindow.xaml
    /// </summary>
    public partial class ChooseWindow : Window
    {
        CreatePcForThePeopl_dbEntities Dbcontext;
        bool isChecked = false;

        public ChooseWindow()
        {
            InitializeComponent();

            Dbcontext = CreatePcForThePeopl_dbEntities.DBContext;
        }

        private void ChooseCooler_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(5);
            nextWindow.ShowDialog();


            if (ChooseCurrentItemShow.ComputerReadyNot.Cooler != null)
            {
                ChooseCooler_button.IsEnabled = false;

                Cooler_listView.Items.Clear();

                Cooler_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.ComputerReadyNot.Cooler, 5));

                ChooseRAM_button.Visibility = Visibility.Visible;

                ChooseCurrentItemShow.ComputerReadyNot.SumComponents += ChooseCurrentItemShow.ComputerReadyNot.Cooler.Cost;
            }
        }

        private void ChooseRAM_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(6,ChooseCurrentItemShow.ComputerReadyNot.MotherBoard.TypeMotherBoardMemory,3);
            nextWindow.ShowDialog();

            if (ChooseCurrentItemShow.ComputerReadyNot.RAM != null)
            {
                ChooseRAM_button.IsEnabled = false;

                RAM_listView.Items.Clear();

                RAM_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.ComputerReadyNot.RAM, 6));

                ChoosePowerSupply_button.Visibility = Visibility.Visible;

                ChooseCurrentItemShow.ComputerReadyNot.SumComponents += ChooseCurrentItemShow.ComputerReadyNot.RAM.Cost;
            }
        }

        private void ChoosePowerSupply_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(7);
            nextWindow.ShowDialog();

            if (ChooseCurrentItemShow.ComputerReadyNot.PowerSupply != null)
            {
                ChoosePowerSupply_button.IsEnabled = false;

                BuildPC_checkBox.IsEnabled = false;

                PowerSupply_listView.Items.Clear();

                PowerSupply_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.ComputerReadyNot.PowerSupply, 7));

                CreateComputer_button.Visibility = Visibility.Visible;

                ChooseCurrentItemShow.ComputerReadyNot.SumComponents += ChooseCurrentItemShow.ComputerReadyNot.PowerSupply.Cost;
            }
        }

<<<<<<< HEAD
=======
        private void Update_button_Click(object sender, RoutedEventArgs e)
        {
            ChooseCurrentItemShow.ComputerReadyNot = new Computer();

            Window updateWindow = new ChooseWindow();
            updateWindow.Show();
            Close();
        }

>>>>>>> cbbf8d9f865399896303020726371375ab28ec26
        private void ChooseGPU_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(4);
            nextWindow.ShowDialog();

            if (ChooseCurrentItemShow.ComputerReadyNot.GPU != null)
            {
                ChooseGPU_button.IsEnabled = false;

                GPU_listView.Items.Clear();

                GPU_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.ComputerReadyNot.GPU, 4));

                ChooseCooler_button.Visibility = Visibility.Visible;

                ChooseCurrentItemShow.ComputerReadyNot.SumComponents += ChooseCurrentItemShow.ComputerReadyNot.GPU.Cost;
            }
        }

        private void ChooseCase_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(3, ChooseCurrentItemShow.ComputerReadyNot.MotherBoard.Form_Factor, 2);
            nextWindow.ShowDialog();

            if (ChooseCurrentItemShow.ComputerReadyNot.Case != null)
            {
                ChooseCase_button.IsEnabled = false;

                Case_listView.Items.Clear();

                Case_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.ComputerReadyNot.Case, 3));

                ChooseGPU_button.Visibility = Visibility.Visible;

                ChooseCurrentItemShow.ComputerReadyNot.SumComponents += ChooseCurrentItemShow.ComputerReadyNot.Case.Cost;
            }
        }

        private void ChooseMotherBoard_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(2,ChooseCurrentItemShow.ComputerReadyNot.CPU.Socket,1);
            nextWindow.ShowDialog();

            if (ChooseCurrentItemShow.ComputerReadyNot.MotherBoard != null)
            {
                ChooseMotherBoard_button.IsEnabled = false;

                MotherBoard_listView.Items.Clear();

                MotherBoard_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.ComputerReadyNot.MotherBoard, 2));

                ChooseCase_button.Visibility = Visibility.Visible;

                ChooseCurrentItemShow.ComputerReadyNot.SumComponents += ChooseCurrentItemShow.ComputerReadyNot.MotherBoard.Cost;
            }
        }

        private void ChooseCPU_button_Click(object sender, RoutedEventArgs e)
        {
            Window nextWindow = new ChooseCurrentItemShow(1);
            nextWindow.ShowDialog();

            if (ChooseCurrentItemShow.ComputerReadyNot.CPU != null)
            {
                ChooseCPU_button.IsEnabled = false;

                CPU_listView.Items.Clear();

                CPU_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.ComputerReadyNot.CPU, 1));

                ChooseMotherBoard_button.Visibility = Visibility.Visible;

                ChooseCurrentItemShow.ComputerReadyNot.SumComponents += ChooseCurrentItemShow.ComputerReadyNot.CPU.Cost;
            }
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CreateComputer_button_Click(object sender, RoutedEventArgs e)
        {
            Dbcontext.Computer.Add(ChooseCurrentItemShow.ComputerReadyNot);
            Dbcontext.SaveChanges();
            Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ChooseCurrentItemShow.ComputerReadyNot.isBuildComputer = true;
            CreateComputer_button.Visibility = Visibility.Visible;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            ChooseCurrentItemShow.ComputerReadyNot.isBuildComputer = false;
            CreateComputer_button.Visibility = Visibility.Hidden;
        }
    }
}
