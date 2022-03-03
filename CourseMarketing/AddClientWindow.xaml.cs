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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public AddClientWindow()
        {
            InitializeComponent();

        }

        
        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (BoxAddSurname.Text == null)
                errors.AppendLine("Не укаказана фамилия");
            if (BoxAddName.Text == null)
                errors.AppendLine("Не укаказано имя");
            if (BoxAddPatronymic.Text == null)
                errors.AppendLine("Не укаказано отчество");
            if (BoxAddCompany.Text == null)
                errors.AppendLine("Не укаказано наименование компании");
            if (BoxAddEmail.Text == null)
                errors.AppendLine("Не укаказан адрес электронной почты");
            if (BoxAddPhone.Text == null)
                errors.AppendLine("Не укаказан номер телефона");
           
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            } 

            BDOn.Contxt().ClientM.Add(new ClientM()
            {
                Surname = BoxAddSurname.Text,
                Name = BoxAddName.Text,
                Patronymic = BoxAddPatronymic.Text,
                Company_Name = BoxAddCompany.Text,
                Phone_Number = BoxAddPhone.Text,
                Email = BoxAddEmail.Text

            });

            BDOn.Contxt().SaveChanges();
            ((Clients)this.Owner).BDListClient();
            Close();


        }
    }
}
