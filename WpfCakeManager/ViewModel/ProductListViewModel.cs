using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using CakeManager.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class ProductListViewModel
    {
        private ProductListView productListView;
        private MySQLManager<Product> productManager;
        private MySQLManager<Category> categoryManager;

        public ProductListViewModel(ProductListView productListView)
        {
            this.productListView = productListView;
            this.productListView.SearchProductBtn.Click += SearchProductBtn_Click;
            this.productListView.AddB.Click += AddB_Click;
            this.productListView.EditBtn.Click += EditBtn_Click;
            this.categoryManager = new MySQLManager<Category>(DataConnectionResource.LOCALMYQSL);
            this.productListView.CategoryListUserControl.LoadItems(Session.Shop.Id);
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            this.productListView.NavigationService.LoadCompleted += NavigationService_LoadCompleted;
            Product product = (Product)this.productListView.ProductListUserControl.ListProductL.SelectedItem;
            if (product == null)
                MessageBox.Show("Veuiller selectionner un produit");
            else
            {
                this.productListView.NavigationService.Navigate(new ProductView(product));
            }
        }

        private void AddB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.productListView.NavigationService.LoadCompleted += NavigationService_LoadCompleted;
            Category category = (Category)this.productListView.CategoryListUserControl.ListCategoryL.SelectedItem;
            if (category == null)
                MessageBox.Show("Veuiller selectionner une catégorie");
            else
            {
                Product product = new Product();
                product.CategoryId = category.Id;
                product.ShopId = Session.Shop.Id;
                this.productListView.NavigationService.Navigate(new ProductView(product));
            }
                
        }

        private void NavigationService_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            RefreshByCategory();
        }

        private void SearchProductBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            RefreshByCategory();
        }

        private void RefreshByCategory()
        {
            Category category = (Category)this.productListView.CategoryListUserControl.ListCategoryL.SelectedItem;
            if (category == null)
                MessageBox.Show("Veuiller selectionner une catégorie");
            else
            {
                this.productListView.ProductListUserControl.LoadItems(category.Id);
            }
        }
    }
}
