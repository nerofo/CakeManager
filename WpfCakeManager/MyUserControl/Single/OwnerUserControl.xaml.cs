using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using CakeManager.Session;
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
    /// Logique d'interaction pour OwnerUserControl.xaml
    /// </summary>
    public partial class OwnerUserControl : BaseUserControl
    {
        private Owner owner;
        private MySQLManager<Owner> ownerManager;
        private WebServiceManager<Owner> ownerWebService;

        public Owner Owner
        {
            get { return owner; }
            set
            {
                owner = value;
                this.OnPropertyChanged("Owner");
            }
        }

        public OwnerUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            this.ownerWebService = new WebServiceManager<Owner>(DataConnectionResource.LOCALAPI);
            this.ownerManager = new MySQLManager<Owner>(DataConnectionResource.LOCALMYQSL);
            Load();
        }

        public async void Load()
        {
            this.owner = this.ownerManager.GetByWhere("owner", "shopId", Session.Shop.Id);
            if (this.owner != null && this.owner.Id != 0)
            {
                this.Owner = owner;
            }
            else
            {
                this.owner = new Owner();
            }
        }

        public Int32 Update()
        {
            this.owner.ShopId = Session.Shop.Id;
            if (this.owner.Id == 0)
            {
                //this.shop = this.shopWebService.Post(this.shop).Result;
                Owner owner = this.ownerManager.Insert(this.owner).Result;
            }
            else
            {
                this.ownerManager.Update(this.owner);
            }
            return this.owner.Id;
        }
    }
}
