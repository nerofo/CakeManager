using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCakeManager.ViewModel;
using WpfCakeManager.Views;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class OrderListViewModel
    {
        private OrderListView orderListView;

        public OrderListViewModel(OrderListView orderListView)
        {
            this.orderListView = orderListView;
            this.orderListView.EditBtn.Click += EditBtn_Click;
            this.orderListView.AddB.Click += AddB_Click;
            this.orderListView.SearchOrderBtn.Click += SearchOrderBtn_Click;
            this.orderListView.ClientListUserControl.LoadItems();
        }

        private void SearchOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            Client client = (Client)this.orderListView.ClientListUserControl.ListClientL.SelectedItem;
            if (client == null)
                MessageBox.Show("Veuiller selectionner un client");
            else
            {
                this.orderListView.OrderListUserControl.LoadItems(client.Id);
            }
        }

        private void AddB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Client client = (Client)this.orderListView.ClientListUserControl.ListClientL.SelectedItem;
            if (client == null)
                MessageBox.Show("Veuiller selectionner un client");
            else
            {
                Order order = new Order();
                order.ClientId = client.Id;
                this.orderListView.NavigationService.Navigate(new OrderView(order, client));
            }
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            //this.orderListView.NavigationService.Navigate(new OrderView());
        }
    }
}
