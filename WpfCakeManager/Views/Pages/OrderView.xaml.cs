using CakeManager.Entities;
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
using System.Windows.Shapes;
using WpfCakeManager.ViewModel;

namespace WpfCakeManager.Views
{
    /// <summary>
    /// Logique d'interaction pour AddressView.xaml
    /// </summary>
    public partial class OrderView : Page
    {
        private OrderViewModel orderViewModel;

        public OrderViewModel OrderViewModel
        {
            get
            {
                return orderViewModel;
            }

            set
            {
                orderViewModel = value;
            }
        }

        public OrderView(Order order, Client client)
        {
            InitializeComponent();
            this.OrderViewModel = new OrderViewModel(this, order, client);
        }
    }
}
