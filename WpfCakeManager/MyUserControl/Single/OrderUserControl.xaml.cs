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
    /// Logique d'interaction pour OrderUserControl.xaml
    /// </summary>
    public partial class OrderUserControl : BaseUserControl
    {
        private Order order;
        private MySQLManager<Order> orderManager;
        private MySQLManager<Product> productManager;
        private WebServiceManager<Order> orderWebService;

        public Order Order
        {
            get { return order; }
            set
            {
                order = value;
                this.OnPropertyChanged("Order");
            }
        }

        public OrderUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            this.orderManager = new MySQLManager<Order>(DataConnectionResource.LOCALMYQSL);
            this.productManager = new MySQLManager<Product>(DataConnectionResource.LOCALMYQSL);
            this.orderWebService = new WebServiceManager<Order>(DataConnectionResource.LOCALAPI);
        }

        public async void Load(Order order, Client client)
        {
            if (order.Id != 0)
                this.order = order;
            else
                this.order = new Order();
            this.order.ClientId = client.Id;

            //chargement liste produit
            List<Product> products = this.productManager.GetListByWhere("product", "shopId", Session.Shop.Id);
            foreach (var item in products)
            {
                this.ListProductCB.Items.Add(item.ToString());
            }
        }

        public Int32 Update()
        {
            String product = (String)this.ListProductCB.SelectedItem;
            String[] tabProduct = product.Split('-');

            if (this.order.Id == 0)
            {
                //this.address = this.addressWebService.Post(this.address).Result;
                this.order.ProductId = Convert.ToInt32(tabProduct[0]);
                this.order = this.orderManager.Insert(this.order).Result;
            }
            else
            {

            }
            return this.order.Id;
        }
    }
}
