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
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    public class ShopEditViewModel
    {
        private ShopEditView shopEditView;
        private Shop shop;
        private MySQLManager<Shop> shopManager;

        private WebServiceManager<Shop> shopWebService;
        

        public ShopEditViewModel(ShopEditView shopEditView, Shop shop)
        {
            this.shopEditView = shopEditView;
            this.shopEditView.ValidateB.Click += ValidateB_Click;

            this.shopManager = new MySQLManager<Shop>(DataConnectionResource.LOCALMYQSL);
            this.shopWebService = new WebServiceManager<Shop>(DataConnectionResource.LOCALAPI);

            this.shopEditView.ShopUserControl.Load(shop);
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //Update(this.shop);
            this.shopEditView.ShopUserControl.Update();
            this.shopEditView.NavigationService.Navigate(new ShopListView());
        }
    }
}
