using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    public class ProductViewModel
    {
        private ProductView productView;
        private Product product;
        private MySQLManager<Product> productManager;
        private WebServiceManager<Product> productWebService;

        public ProductViewModel(ProductView productView, Product product)
        {
            this.productView = productView;
            this.productView.ValidateB.Click += ValidateB_Click;
            this.product = product;
            this.productManager = new MySQLManager<Product>(DataConnectionResource.LOCALMYQSL);
            this.productWebService = new WebServiceManager<Product>(DataConnectionResource.LOCALAPI);
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Update(this.product);
            this.productView.NavigationService.GoBack();
        }

        private async void Update(Product product)
        {
            if (this.product.Id == 0)
            {
                product = await this.productWebService.Post(product);
                this.productManager.Insert(product);
            }
            else
            {
                product = await this.productWebService.Put(product);
                this.productManager.Update(product);
            }
        }
    }
}
