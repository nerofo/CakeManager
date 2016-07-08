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

namespace WpfCakeManager.MyUserControl.List
{
    /// <summary>
    /// Logique d'interaction pour ClientUserControl.xaml
    /// </summary>
    public partial class OrderListUserControl : BaseUserControl
    {
        private ObservableCollection<Order> orders;
        private MySQLManager<Order> orderManager;

        public ObservableCollection<Order> Order
        {
            get { return orders; }
            set { orders = value; this.OnPropertyChanged("Orders"); }
        }


        public OrderListUserControl()
        {
            InitializeComponent();
            this.orders = new ObservableCollection<Order>();
            this.orderManager = new MySQLManager<Order>(DataConnectionResource.LOCALMYQSL);
            this.ListOrderL.ItemsSource = this.orders;
        }

        public void LoadItems(Int32 idClient)
        {
            List<Order> items = null;
            if (idClient != 0)
                items = this.orderManager.GetList("orderclient", "clientId", idClient);
            this.orders.Clear();
            foreach (var item in items)
            {
                this.orders.Add(item);
            }
        }
    }
}
