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
    public partial class ShopUserControl : BaseUserControl
    {
        private Shop shop;
        private MySQLManager<Shop> shopManager;
        private WebServiceManager<Shop> shopWebService;

        public Shop Shop
        {
            get { return shop; }
            set
            {
                shop = value;
                this.OnPropertyChanged("Shop");
            }
        }

        public ShopUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            this.shopWebService = new WebServiceManager<Shop>(DataConnectionResource.LOCALAPI);
            this.shopManager = new MySQLManager<Shop>(DataConnectionResource.LOCALMYQSL);
        }

        public async void Load(Shop shop)
        {
            this.shop = shop;
            if (shop.Address != 0)
                this.AddressUserControl.Load(shop.Address);
            else
                this.AddressUserControl.Address = new Address();
        }

        public Int32 Update()
        {
            if (this.shop.Id == 0)
            {
                this.shop.Address = this.AddressUserControl.Update();
                //this.shop = this.shopWebService.Post(this.shop);
                this.shopManager.Insert(this.shop);
            }
            else
            {
                this.shopManager.Update(this.shop);
            }
            return this.shop.Id;
        }

        //public async Task<Int32> Update()
        //{
        //    if (this.shop.Id == 0)
        //    {
        //        this.shop.Address = this.AddressUserControl.Update();
        //        this.shop = await this.shopWebService.Post(this.shop);
        //        await this.shopManager.Insert(this.shop);
        //    }
        //    else
        //    {
        //        await this.shopManager.Update(this.shop);
        //    }
        //    return this.shop.Id;
        //}
    }
}
