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
    /// Логика взаимодействия для Clients.xaml
    /// </summary>
    public partial class Clients : Window   
    {
        public ClientM clientmar;
        private Users users;
        public Clients(Users users)
        {
            InitializeComponent();
            BDListClient();

            FiltrClientCombo.ItemsSource = BDOn.Contxt().ClientM.ToList();
            FiltrClientCombo.DataContext = BDOn.Contxt().ClientM.ToList(); //editdata update combo
            
        }
        public void BDListClient()
        {
            BDOn.Contxt().ChangeTracker.Entries().ToList().ForEach(p => p.Reload()); //filtr
            var masClient = from ClientMar in BDOn.Contxt().ClientM
                            select new
                            {
                                NumberC = ClientMar.id_Client,
                                Name = ClientMar.Name,
                                Surname = ClientMar.Surname,
                                Patronymic = ClientMar.Patronymic,
                                NameCompany = ClientMar.Company_Name,
                                PhoneNumber = ClientMar.Phone_Number,
                                Email = ClientMar.Email
                            };
            if (!String.IsNullOrEmpty(SearchBoxClient.Text))
            {
                masClient = masClient.Where(p => p.NameCompany.Contains(SearchBoxClient.Text));
            }
            if (!String.IsNullOrEmpty(FiltrClientCombo.Text))
            {
                ClientM ch = FiltrClientCombo.SelectedItem as ClientM;
                masClient = masClient.Where(p => p.Surname == ch.Surname);
            }
            GridClientsData.ItemsSource = masClient.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu bmenu = new Menu(users);
            bmenu.Show();
            Close();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

     

        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addclientwindow = new AddClientWindow();
            addclientwindow.Owner = this;
            addclientwindow.Show();
             
        }

        private void GridClientsData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditClientButton(object sender, RoutedEventArgs e)
        {
            
            Button but = sender as Button;
            EditClientWindow clientmarw = new EditClientWindow(but.Tag);
            clientmarw.Owner = this;
            clientmarw.Show();
            

        }

        private void Button_Delete_Client(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resbox = MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление записи", MessageBoxButton.YesNo);
            if (resbox == MessageBoxResult.Yes)
            {
                //StringBuilder errors = new StringBuilder();
                //errors.AppendLine("Для удаления этого клиента, удалите все заказы связанные с ним");

                int id = Convert.ToInt32(TypeDescriptor.GetProperties(GridClientsData.SelectedItem)[0].GetValue(GridClientsData.SelectedItem));
                //int dsc = ContractMar
                ClientM poseh = BDOn.Contxt().ClientM.Where(p => p.id_Client == id).First();
                //ContractMar pose = BDOn.Contxt().ContractMar.Where(d => d.id_Client == dsc).First();
                //if (poseh.id_Client == pose.id_Client ) 
                //{
                //    MessageBox.Show(errors.ToString());
                //    return;
                //}
                BDOn.Contxt().ClientM.Remove(poseh);
                BDOn.Contxt().SaveChanges();
                BDListClient();
                
            }
        }

        private void Searching_Text(object sender, TextChangedEventArgs e)
        {
            BDListClient();
        }

        private void SortSurnameBox(object sender, SelectionChangedEventArgs e)
        {
            BDListClient(); // Selection Change
            

        }

 

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void CancelFiltrClient_Click(object sender, RoutedEventArgs e)
        {
            FiltrClientCombo.Text = String.Empty;
            FiltrClientCombo.SelectedItem = null;
        }
    }
}
