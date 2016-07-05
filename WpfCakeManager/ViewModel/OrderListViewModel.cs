using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.orderListView.NavigationService.Navigate(new OrderView());
        }
    }
}
