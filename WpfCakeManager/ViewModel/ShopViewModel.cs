using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class ShopViewModel
    {
        #region Attributes
        private ShopView shopView;
        
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for menu
        /// </summary>
        /// <param name="shopView"></param>
        public ShopViewModel(ShopView shopView)
        {
            this.shopView = shopView;
            this.shopView.ClientManagerBtn.Click += ClientManagerBtn_Click;
            this.shopView.ProviderManagerBtn.Click += ProviderManagerBtn_Click;
            this.shopView.ProductManagerBtn.Click += ProductManagerBtn_Click;
            this.shopView.OwnerManagerBtn.Click += OwnerManagerBtn_Click;
            this.shopView.OrderManagerBtn.Click += OrderManagerBtn_Click;
            this.shopView.CategoryManagerBtn.Click += CategoryManagerBtn_Click;
        }


        #endregion

        #region Methods
        private void CategoryManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.shopView.NavigationService.Navigate(new CategoryListView());
        }

        private void OrderManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.shopView.NavigationService.Navigate(new OrderListView());
        }

        private void OwnerManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.shopView.NavigationService.Navigate(new OwnerView());
        }

        private void ProductManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.shopView.NavigationService.Navigate(new ProductListView());
        }

        private void ProviderManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.shopView.NavigationService.Navigate(new ProviderListView());
        }

        private void ClientManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.shopView.NavigationService.Navigate(new ClientListView());
        }
        #endregion
    }
}
