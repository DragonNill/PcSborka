using System.Windows;

namespace PcSborka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для OrderCreate.xaml
    /// </summary>
    public partial class OrderCreate : Window
    {
        public OrderCreate()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            Window backWindow = new MainWindow();
            backWindow.Show();
            Close();
        }

        private void ChooseComputer_button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Window chooseComputerWindow = new ChooseWindow();
            chooseComputerWindow.ShowDialog();
            Show();
            if (ChooseCurrentItemShow.ComputerReadyNot.PowerSupply != null)
            {
                ComponentsInfo_textblock.Text = $"Сумма стоимости комплектующих:{ChooseCurrentItemShow.ComputerReadyNot.SumComponents} руб.\nВы успешно cобрали комплекующие, \n теперь вы можете сделать заказ";
                ChooseComputer_button.IsEnabled = false;

                Periphery_textBlock.Text = "Или выбрать периферию";

                ChooseFinishedComputer_button.Visibility = Visibility.Hidden;
                ChooseFinishedPeriphery_button.Visibility = Visibility.Hidden;
                FinishedInfo_textBlock.Visibility = Visibility.Hidden;

                CreateOrder_button.Visibility = Visibility.Visible;
                ChooseComputer_button.IsEnabled = false;
            }
            else
            {
                if (ChooseCurrentItemShow.ComputerReadyNot.isBuildComputer == true)
                {
                    ComponentsInfo_textblock.Text = $"Сумма стоимости комплектующих:{ChooseCurrentItemShow.ComputerReadyNot.SumComponents} руб.\nВы успешно выбрали комплекующие,\nих вам дособерут сотрудники ,\n теперь вы можете сделать заказ";

                    ChooseComputer_button.IsEnabled = false;

                    Periphery_textBlock.Text = "Или выбрать периферию";

                    ChooseFinishedComputer_button.Visibility = Visibility.Hidden;
                    ChooseFinishedPeriphery_button.Visibility = Visibility.Hidden;
                    FinishedInfo_textBlock.Visibility = Visibility.Hidden;

                    CreateOrder_button.Visibility = Visibility.Visible;
                    ChooseComputer_button.IsEnabled = false;
                }
                else
                {
                    ChooseCurrentItemShow.ComputerReadyNot = new Entity.Computer();
                }
            }

        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ChooseCurrentItemShow.ComputerReadyNot = new Entity.Computer();
        }
<<<<<<< HEAD

        private void ChoosePeriphery_button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Window choosePeriphery = new ChoosePeripheryWindow();
            choosePeriphery.ShowDialog();
            Show();
        }
=======
>>>>>>> cbbf8d9f865399896303020726371375ab28ec26
    }
}
