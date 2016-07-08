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
using System.Collections.ObjectModel;
using CakeManager.Database;
using CakeManager.Enums;
using CakeManager.Session;

namespace WpfCakeManager.MyUserControl.List
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class ProductListUserControl : BaseUserControl
    {
        private ObservableCollection<Product> products;
        private MySQLManager<Product> productManager;

        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; this.OnPropertyChanged("Products"); }
        }


        public ProductListUserControl()
        {
            InitializeComponent();
            this.products = new ObservableCollection<Product>();
            this.productManager = new MySQLManager<Product>(DataConnectionResource.LOCALMYQSL);
            this.ListProductL.ItemsSource = this.products;
        }

        public void LoadItems(Int32 idCategory)
        {
            List<Product> items = null;
            if (idCategory == 0)
                items = this.productManager.GetList("product", "shopId", Session.Shop.Id);
            else
                items = this.productManager.GetList("product", "categoryId", idCategory);

            this.products.Clear();
            foreach (var item in items)
            {
                this.Products.Add(item);
            }
        }
    }
}
