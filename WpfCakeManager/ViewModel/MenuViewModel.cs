using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class MenuViewModel
    {
        #region Attributes
        private MenuView menuView;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor for menu
        /// </summary>
        /// <param name="menuView"></param>
        public MenuViewModel(MenuView menuView)
        {
            this.menuView = menuView;
            this.menuView.ClientManagerBtn.Click += ClientManagerBtn_Click;
            this.menuView.ProviderManagerBtn.Click += ProviderManagerBtn_Click;
            this.menuView.ProductManagerBtn.Click += ProductManagerBtn_Click;
            this.menuView.OwnerManagerBtn.Click += OwnerManagerBtn_Click;
            this.menuView.OrderManagerBtn.Click += OrderManagerBtn_Click;
        }
        #endregion

        #region Methods
        private void OrderManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.menuView.NavigationService.Navigate(new OrderListView());
        }

        private void OwnerManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.menuView.NavigationService.Navigate(new OwnerView());
        }

        private void ProductManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.menuView.NavigationService.Navigate(new ProductListView());
        }

        private void ProviderManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.menuView.NavigationService.Navigate(new ProviderListView());
        }

        private void ClientManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.menuView.NavigationService.Navigate(new ClientListView());
        }
        #endregion
    }
}
