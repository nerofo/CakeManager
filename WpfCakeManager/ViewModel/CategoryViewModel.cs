using CakeManager.API;
using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using CakeManager.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    public class CategoryViewModel
    {
        private CategoryView categoryView;
        private Category category;

        public CategoryViewModel(CategoryView categoryView, Category category)
        {
            this.categoryView = categoryView;
            this.category = category;
            this.categoryView.ValidateB.Click += ValidateB_Click;
            this.categoryView.CategoryUserControl.Category = category;
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.categoryView.CategoryUserControl.Update();
            this.categoryView.NavigationService.Navigate(new CategoryListView());
        }
    }
}
