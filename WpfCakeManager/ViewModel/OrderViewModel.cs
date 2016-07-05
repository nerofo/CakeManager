using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views;

namespace WpfCakeManager.ViewModel
{
    public class OrderViewModel
    {
        private OrderView orderView;

        public OrderViewModel(OrderView orderView)
        {
            this.orderView = orderView;
        }
    }
}
