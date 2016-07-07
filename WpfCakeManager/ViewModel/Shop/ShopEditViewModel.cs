using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views;

namespace WpfCakeManager.ViewModel
{
    public class ShopEditViewModel
    {
        private ShopEditView shopEditView;
        private Shop shop;
        private MySQLManager<Shop> shopManager;
        private MySQLManager<Address> addressManager;
        private WebServiceManager<Shop> shopWebService;

        public ShopEditViewModel(ShopEditView shopEditView, Shop shop)
        {
            this.shopEditView = shopEditView;
            this.shopEditView.ValidateB.Click += ValidateB_Click;

            this.shopManager = new MySQLManager<Shop>(DataConnectionResource.LOCALMYQSL);
            this.addressManager = new MySQLManager<Address>(DataConnectionResource.LOCALMYQSL);
            this.shopWebService = new WebServiceManager<Shop>(DataConnectionResource.LOCALAPI);

            Load(shop);
        }

        private async void Load(Shop shop)
        {
            if (shop.Id != 0)
            {
                shop.Address = await addressManager.Get(shop.Address_Id);
                this.shopEditView.ShopUserControl.Shop = shop;
            }
            this.shop = shop;
            this.shopEditView.ShopUserControl.Shop = shop;
        }

        private async void Update(Shop shop)
        {
            if (this.shop.Id == 0)
            {
                shop = await this.shopWebService.Post(shop);
                this.shopManager.Insert(shop);
            }
            else
            {
                shop = await this.shopWebService.Put(shop);
                this.shopManager.Update(shop);
            }
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Update(this.shop);
            this.shopEditView.NavigationService.GoBack();
        }
    }
}
