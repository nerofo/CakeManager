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
    /// Logique d'interaction pour ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : BaseUserControl
    {
        private Product product;
        private MySQLManager<Product> productManager;
        private WebServiceManager<Product> productWebService;

        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                this.OnPropertyChanged("Product");
            }
        }

        public ProductUserControl()
        {
            InitializeComponent();
            //this.CategoryUserControl.Category = this.product.Category;
            this.DataContext = this;
            this.productManager = new MySQLManager<Product>(DataConnectionResource.LOCALMYQSL);
            this.productWebService = new WebServiceManager<Product>(DataConnectionResource.LOCALAPI);
        }

        public async void Load(Product product)
        {
            this.product = product;
        }

        public Int32 Update()
        {
            if (this.product.Id == 0)
            {
                //this.address = this.addressWebService.Post(this.address).Result;
                this.product = this.productManager.Insert(this.product).Result;
            }
            else
            {

            }
            return this.product.Id;
        }
    }
}
