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
    /// Логика взаимодействия для EditClientWindow.xaml
    /// </summary>
    public partial class EditClientWindow : Window
    {
       // private Users users;
        public EditClientWindow(object clientmarw)
        {
            InitializeComponent();
            DataContext = BDOn.Contxt().ClientM.Where(p => p.id_Client == (int)clientmarw).First();

        }

        private void SaveChangesClientButton_Click(object sender, RoutedEventArgs e)
        {
             BDOn.Contxt().SaveChanges();
             ((Clients)this.Owner).BDListClient();
            Close();
            
        }
    }
}
