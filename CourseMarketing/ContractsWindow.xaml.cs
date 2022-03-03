using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        private Users users;
        public Orders(Users users)
        {
            InitializeComponent();
            BDListContract();
        }

        public void BDListContract()
        {
            var masContract = from OrderMar in BDOn.Contxt().ContractMar
                              join ClientM in BDOn.Contxt().ClientM on OrderMar.ClientM equals ClientM           
                              join StatusPaymentMar in BDOn.Contxt().StatusPaymentMar on OrderMar.StatusPaymentMar equals StatusPaymentMar
                              join StatusContractMar in BDOn.Contxt().StatusContractMar on OrderMar.StatusContractMar equals StatusContractMar
                              join ServiceMar in BDOn.Contxt().ServiceMar on OrderMar.ServiceMar equals ServiceMar
                              select new
                            {
                                NumberO = OrderMar.id_Contract,
                                FIOClient = OrderMar.ClientM.Surname + " " + OrderMar.ClientM.Name + " " + OrderMar.ClientM.Patronymic,
                                NumberContract = OrderMar.Number_Contract,
                                DateCreat = OrderMar.Date_Creation,
                                DateExe = OrderMar.Date_Execution,
                                StatusContract = OrderMar.StatusContractMar.Name_Status_Order,
                                DetailContract = OrderMar.Detail_Order,
                                StatusPay = OrderMar.StatusPaymentMar.Name_Status_payment,
                                Service = OrderMar.ServiceMar.Name_Service
                            };
            GridContractData.ItemsSource = masContract.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ContractBackMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu bmenu = new Menu(users);
            bmenu.Show();
            Close();
        }

        private void AddContractButton_Click(object sender, RoutedEventArgs e)
        {
            AddContractWindow addcontwindow = new AddContractWindow();
            addcontwindow.Owner = this;
            addcontwindow.Show();
        }

        private void EditContractButton(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            EditContractWindow contractm = new EditContractWindow(but.Tag);
            contractm.Owner = this;
            contractm.Show();
        }

        private void Button_Delete_Contract(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                int id = Convert.ToInt32(TypeDescriptor.GetProperties(GridContractData.SelectedItem)[0].GetValue(GridContractData.SelectedItem));
                ContractMar poseh = BDOn.Contxt().ContractMar.Where(p => p.id_Contract == id).First();
                BDOn.Contxt().ContractMar.Remove(poseh);
                BDOn.Contxt().SaveChanges();
                BDListContract();
            }
        }
    }
}
