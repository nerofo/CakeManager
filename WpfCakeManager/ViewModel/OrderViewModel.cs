using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    public class OrderViewModel
    {
        private OrderView orderView;

        public OrderViewModel(OrderView orderView, Order order, Client client)
        {
            this.orderView = orderView;
            this.orderView.OrderUserControl.Load(order, client);
            this.orderView.ValidateB.Click += ValidateB_Click;
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.orderView.OrderUserControl.Update();
            this.orderView.NavigationService.GoBack();
        }
    }
}
