using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCakeManager.Views;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class ShopListViewModel
    {
        private ShopListView shopListView;
       

        public ShopListViewModel(ShopListView shopListView)
        {
            this.shopListView = shopListView;
            this.shopListView.AddBtn.Click += AddBtn_Click;
            this.shopListView.EditBtn.Click += EditBtn_Click;
            this.shopListView.ValidateBtn.Click += ValidateBtn_Click;

            this.shopListView.ShopListUserControl.LoadItems();
        }

        private void ValidateBtn_Click(object sender, RoutedEventArgs e)
        {
            Shop shop = (Shop)this.shopListView.ShopListUserControl.ListShopL.SelectedItem;
            if (shop == null)
                MessageBox.Show("Veuiller selectionner un magasin");
            else
                this.shopListView.NavigationService.Navigate(new ShopView(shop));
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Shop shop = (Shop)this.shopListView.ShopListUserControl.ListShopL.SelectedItem;
            if (shop == null)
                MessageBox.Show("Veuiller selectionner un magasin");
            else
                this.shopListView.NavigationService.Navigate(new ShopEditView(shop));
        }

        private void AddBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.shopListView.NavigationService.Navigate(new ShopEditView(new Shop()));
        }
    }
}
