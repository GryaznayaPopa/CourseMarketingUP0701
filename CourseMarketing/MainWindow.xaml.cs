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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CourseMarketing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(LoginBox.Text))
            {
                if (!String.IsNullOrEmpty(PassBox.Text))
                {
                    IQueryable<Users> users = BDOn.Contxt().Users.Where(p => p.Login == LoginBox.Text && p.Password == PassBox.Text);
                   
                    if (users.Count() == 1)
                    {
                        MessageBox.Show($"Добро пожаловать, {users.First().Name} {users.First().Surname}");
                        Menu menus = new Menu(users.First());
                        menus.Show();
                        Close();
                    }
                    else MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
