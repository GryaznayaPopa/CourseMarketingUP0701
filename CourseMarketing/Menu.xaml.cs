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

namespace CourseMarketing
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private Users users;
        public Menu(Users users)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients(users);
            clients.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Orders orders = new Orders(users);
            orders.Show();
            Close();
        }

        private void ButtonBackLogin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow LoginWIn = new MainWindow();
            LoginWIn.Show();
            Close();
        }
    }
}
