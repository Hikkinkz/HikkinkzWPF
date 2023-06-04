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
    /// Логика взаимодействия для CarWindow.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        public CarWindow()
        {
            InitializeComponent();
        }

        private void Button_repair_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Данная функция в разработке - запись по телефону +7-777-777-77-77");

        }

        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPageWindow = new UserPageWindow();
            userPageWindow.Show();
            Hide();
        }
    }
}
