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

namespace HikkinkzWPF
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        public UserPageWindow()
        {
            InitializeComponent();
        }

        private void Button_exit_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }

        private void Button_repair_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция в разработке - запись по телефону +7-777-777-77-77");

        }

        private void Button_car_Click(object sender, RoutedEventArgs e)
        {
            CarWindow carWindow = new CarWindow();
            carWindow.Show();
            Hide();
        }
    }
}
