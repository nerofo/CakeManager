using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class CategoryListViewModel
    {
        private CategoryListView categoryListView;

        public CategoryListViewModel(CategoryListView categoryListView)
        {
            this.categoryListView = categoryListView;
            this.categoryListView.AddB.Click += AddB_Click;
        }

        private void AddB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
        }
    }
}
