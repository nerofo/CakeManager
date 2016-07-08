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
            this.categoryManager = new MySQLManager<Category>(DataConnectionResource.LOCALMYQSL);
            this.productListView.CategoryListUserControl.LoadItems(Session.Shop.Id);
        }

        private void AddB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
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

        private void SearchProductBtn_Click(object sender, System.Windows.RoutedEventArgs e)
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
