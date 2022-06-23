using PcSborka.Entity;
using PcSborka.Views.UserControls;
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

namespace PcSborka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ChoosePeripheryWindow.xaml
    /// </summary>
    public partial class ChoosePeripheryWindow : Window
    {
        CreatePcForThePeopl_dbEntities Dbcontext;
        int countPeriphery = 0;

        public ChoosePeripheryWindow()
        {
            InitializeComponent();

            Dbcontext = CreatePcForThePeopl_dbEntities.DBContext;
        }

        private void ChooseCPU_button_Click(object sender, RoutedEventArgs e)
        {
            CheckCount();
            Window nextWindow = new ChooseCurrentItemShow(8);
            nextWindow.ShowDialog();


            if (ChooseCurrentItemShow.ComputerReadyNot.Cooler != null)
            {
                ChooseMonitor_button.IsEnabled = false;

                Monitor_listView.Items.Clear();

                Monitor_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.PeripheryReadyNot.Monitor, 8));

                ChooseCurrentItemShow.PeripheryReadyNot.SumPeriphery += ChooseCurrentItemShow.PeripheryReadyNot.Monitor.Cost;

                if(CountIsExist())
                {
                    CreatePeriphery_button.Visibility = Visibility.Visible;
                }
            }
        }

        private void ChooseMotherBoard_button_Click(object sender, RoutedEventArgs e)
        {
            CheckCount();
            Window nextWindow = new ChooseCurrentItemShow(9);
            nextWindow.ShowDialog();


            if (ChooseCurrentItemShow.ComputerReadyNot.Cooler != null)
            {
                ChooseMouse_button.IsEnabled = false;

                Mouse_listView.Items.Clear();

                Mouse_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.PeripheryReadyNot.Mouse, 9));

                ChooseCurrentItemShow.PeripheryReadyNot.SumPeriphery += ChooseCurrentItemShow.PeripheryReadyNot.Mouse.Cost;

                if (CountIsExist())
                {
                    CreatePeriphery_button.Visibility = Visibility.Visible;
                }
            }
        }

        private void ChooseCase_button_Click(object sender, RoutedEventArgs e)
        {
            CheckCount();
            Window nextWindow = new ChooseCurrentItemShow(10);
            nextWindow.ShowDialog();


            if (ChooseCurrentItemShow.ComputerReadyNot.Cooler != null)
            {
                ChooseKeyboard_button.IsEnabled = false;

                Keyboard_listView.Items.Clear();

                Keyboard_listView.Items.Add(new CurrentItemControl(ChooseCurrentItemShow.PeripheryReadyNot.Keyboard, 10));

                ChooseCurrentItemShow.PeripheryReadyNot.SumPeriphery += ChooseCurrentItemShow.PeripheryReadyNot.Keyboard.Cost;

                if (CountIsExist())
                {
                    CreatePeriphery_button.Visibility = Visibility.Visible;
                }
            }
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            ChooseCurrentItemShow.PeripheryReadyNot = new Periphery();

            Close();
        }

        private bool CountIsExist()
        {
            if(countPeriphery != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckCount()
        {
            switch (countPeriphery)
            {
                case 0:
                    countPeriphery++;
                    break;
                case 1:
                    countPeriphery++;
                    break;
                case 2:
                    countPeriphery++;
                    break;
            }
        }

        private void CreatePeriphery_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
