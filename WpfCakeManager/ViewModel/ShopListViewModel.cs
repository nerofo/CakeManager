using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class ShopListViewModel
    {
        private ShopListView shopListView;

        public ShopListViewModel(ShopListView shopListView)
        {
            this.shopListView = shopListView;
        }
    }
}
