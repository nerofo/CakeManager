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
using CakeManager.Entities;

namespace WpfCakeManager.MyUserControl.Single
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class ClientUserControl : BaseUserControl
    {
        //utiliser ceci pour la maj des données clientes
        //MySQLManager<Client> manager1 = new MySQLManager<Client>(DataConnectionResource.LOCALMYQSL);
        //MySQLManager<Address> manager2 = new MySQLManager<Address>(DataConnectionResource.LOCALMYQSL);
        //manager1.Insert(client);

        private Client client;

        public Client Client
        {
            get { return client; }
            set
            {
                client = value;
                this.OnPropertyChanged("Client");  
            }
        }

        public ClientUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            Address address = new Address();
            this.AddressUserControl.Address = address;
        }
    }
}
