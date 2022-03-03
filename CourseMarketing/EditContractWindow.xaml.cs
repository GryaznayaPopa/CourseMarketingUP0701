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
    /// Логика взаимодействия для EditContractWindow.xaml
    /// </summary>
    public partial class EditContractWindow : Window
    {
        public EditContractWindow(object contractm)
        {
            InitializeComponent();
            DataContext = BDOn.Contxt().ContractMar.Where(p => p.id_Contract == (int)contractm).First();
        }

        private void SaveContractButton_Click(object sender, RoutedEventArgs e)
        {
            BDOn.Contxt().SaveChanges();
            ((Orders)this.Owner).BDListContract();
            Close();
        }
    }
}
