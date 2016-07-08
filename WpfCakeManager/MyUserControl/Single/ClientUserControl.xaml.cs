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
using CakeManager.Database;
using CakeManager.Enums;
using CakeManager.Session;

namespace WpfCakeManager.MyUserControl.Single
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class ClientUserControl : BaseUserControl
    {

        private Client client;
        private MySQLManager<Client> clientManager;
        private Address address;

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
            this.clientManager = new MySQLManager<Client>(DataConnectionResource.LOCALMYQSL);
        }

        public async void Load(Int32 clientId)
        {
            if (clientId != 0)
            {
                this.client = await this.clientManager.Get(clientId);
                this.AddressUserControl.Load(this.client.AddressId);
            }
            else
            {
                this.client = new Client();
                this.AddressUserControl.Address = new Address();
            }
                
        }

        public Int32 Update()
        {
            this.client.ShopId = Session.Shop.Id;
            if (this.client.Id == 0)
            {
                Int32 addressId = this.AddressUserControl.Update();
                this.client.AddressId = addressId;
                this.clientManager.Insert(this.client);
                //this.address = this.addressWebService.Post(this.address).Result;
                //this.category = this.categoryManager.Insert(this.category).Result;
            }
            else
            {
                
            }
            return this.client.Id;
        }
    }
}
