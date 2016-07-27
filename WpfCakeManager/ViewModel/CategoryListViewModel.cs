﻿using CakeManager.Database;
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
    class CategoryListViewModel
    {
        private CategoryListView categoryListView;
        private MySQLManager<Category> categoryManager;

        public CategoryListViewModel(CategoryListView categoryListView)
        {
            this.categoryListView = categoryListView;
            this.categoryManager = new MySQLManager<Category>(DataConnectionResource.LOCALMYQSL);
            this.categoryListView.AddB.Click += AddB_Click;
            this.categoryListView.EditBtn.Click += EditBtn_Click;
            Load();
        }

        private async void Load()
        {
            Shop shop = Session.Shop;
            this.categoryListView.CategoryListUserControl.LoadItems(shop.Id);
        }

        private void AddB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.categoryListView.NavigationService.LoadCompleted += NavigationService_LoadCompleted;
            this.categoryListView.NavigationService.Navigate(new CategoryView(new Category()));
        }

        private void NavigationService_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            this.Load();
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.categoryListView.NavigationService.LoadCompleted += NavigationService_LoadCompleted;
            Category category = (Category)this.categoryListView.CategoryListUserControl.ListCategoryL.SelectedItem;
            if (category == null)
                MessageBox.Show("Veuiller selectionner une catégorie");
            else
                this.categoryListView.NavigationService.Navigate(new CategoryView(category));
        }
    }
}
