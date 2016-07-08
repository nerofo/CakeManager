using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
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

namespace WpfCakeManager.MyUserControl.Single
{
    /// <summary>
    /// Logique d'interaction pour AddressUserControl.xaml
    /// </summary>
    public partial class AddressUserControl : BaseUserControl
    {
        private Address address;
        private MySQLManager<Address> addressManager;
        private WebServiceManager<Address> addressWebService;

        public Address Address
        {
            get { return address; }
            set
            {
                address = value;
                this.OnPropertyChanged("Address");
            }
        }

        public AddressUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            this.addressWebService = new WebServiceManager<Address>(DataConnectionResource.LOCALAPI);
            this.addressManager = new MySQLManager<Address>(DataConnectionResource.LOCALMYQSL);
        }

        public async void Load(Int32 addressId)
        {
            this.address = await this.addressManager.Get(addressId);
        }

        public Int32 Update()
        {
            if (this.address.Id == 0)
            {
                //this.address = this.addressWebService.Post(this.address).Result;
                this.address = this.addressManager.Insert(this.address).Result;
            }
            else
            {

            }
            return this.address.Id;
        }
    }
}
