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
            LoadCategory();
            //this.productListView.ProductListUserControl.LoadItems(products);
        }

        private void AddB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Category category = (Category)this.productListView.CategoryListUserControl.ListCategoryL.SelectedItem;
            if (category == null)
                MessageBox.Show("Veuiller selectionner une catégorie");
            else
            {
                Product product = new Product();
                product.Category = category;
                this.productListView.NavigationService.Navigate(new ProductView(product));
            }
                
        }

        private void SearchProductBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Category category = (Category)this.productListView.CategoryListUserControl.ListCategoryL.SelectedItem;
            LoadProduct(category);
        }



        private async void LoadCategory()
        {
            Shop shop = Session.Shop;
            List<Category> categories = this.categoryManager.GetList("category", "Shop_Id", shop.Id);
            this.productListView.CategoryListUserControl.LoadItems(categories);
        }

        private async void LoadProduct(Category category)
        {
            List<Product> products = this.productManager.GetList("product", "Category_Id", category.Id);
            this.productListView.ProductListUserControl.LoadItems(products);
        }
    }
}
