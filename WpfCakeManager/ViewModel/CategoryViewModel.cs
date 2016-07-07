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
        private MySQLManager<Category> categoryManager;
        private WebServiceManager<Category> categoryWebService;

        public CategoryViewModel(CategoryView categoryView, Category category)
        {
            this.categoryView = categoryView;
            this.category = category;
            this.categoryManager = new MySQLManager<Category>(DataConnectionResource.LOCALMYQSL);
            this.categoryWebService = new WebServiceManager<Category>(DataConnectionResource.LOCALAPI);
            this.categoryView.ValidateB.Click += ValidateB_Click;
            this.categoryView.CategoryUserControl.Category = category;
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Update(this.category);
            this.categoryView.NavigationService.GoBack();
        }

        private async void Update(Category category)
        {
            category.Shop = Session.Shop;
            if (this.category.Id == 0)
            {
                category = await this.categoryWebService.Post(category);
                this.categoryManager.Insert(category);
            }
            else
            {
                category = await this.categoryWebService.Put(category);
                this.categoryManager.Update(category);
            }
        }
    }
}
