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
    /// Логика взаимодействия для AddContractWindow.xaml
    /// </summary>
    public partial class AddContractWindow : Window
    {
        public AddContractWindow()
        {
            InitializeComponent();
            FIOClientCombo.ItemsSource = BDOn.Contxt().ClientM.ToList();
            PayStatusBox.ItemsSource = BDOn.Contxt().StatusPaymentMar.ToList();
            StatusContcractBox.ItemsSource = BDOn.Contxt().StatusContractMar.ToList();
            ServiceContractBox.ItemsSource = BDOn.Contxt().ServiceMar.ToList();

          
        }

    
           
        

        private void AddContractButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (FIOClientCombo.Text == null)
                errors.AppendLine("Не укаказана фамилия");
            if (NContractBox.Text == null)
                errors.AppendLine("Не укаказано имя");
            if (DateCreationBox.Text == null)
                errors.AppendLine("Не укаказано отчество");
            if (DateExecBox.Text == null)
                errors.AppendLine("Не укаказано наименование компании");
            if (PayStatusBox.Text == null)
                errors.AppendLine("Не укаказан адрес электронной почты");
            if (DescriptionBox.Text == null)
                errors.AppendLine("Не укаказан номер телефона");
            if (StatusContcractBox.Text == null)
                errors.AppendLine("Не укаказан номер телефона");
            if (ServiceContractBox.Text == null)
                errors.AppendLine("Не укаказан номер телефона");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            BDOn.Contxt().ContractMar.Add(new ContractMar()
            {
               ClientM = FIOClientCombo.SelectedItem as ClientM,
               Number_Contract = NContractBox.Text,
               Date_Creation  = DateCreationBox.Text,
               Date_Execution = DateExecBox.Text,
               Detail_Order = DescriptionBox.Text,
              StatusContractMar = StatusContcractBox.SelectedItem as StatusContractMar,
              ServiceMar = ServiceContractBox.SelectedItem as ServiceMar,
              StatusPaymentMar = PayStatusBox.SelectedItem as StatusPaymentMar
          
            });
         

            BDOn.Contxt().SaveChanges();
            ((Orders)this.Owner).BDListContract();
            Close();
        }
    }
}
