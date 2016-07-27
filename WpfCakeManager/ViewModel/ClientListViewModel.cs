﻿using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class ClientListViewModel
    {
        private ClientListView clientListView;

        public ClientListViewModel(ClientListView clientListView)
        {
            this.clientListView = clientListView;
            this.clientListView.EditBtn.Click += EditBtn_Click;
            this.clientListView.AddB.Click += AddB_Click;
            this.clientListView.ClientListUserControl.LoadItems();
        }

        private void NavigationService_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            this.clientListView.ClientListUserControl.LoadItems();
        }

        private void AddB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientListView.NavigationService.LoadCompleted += NavigationService_LoadCompleted;
            this.clientListView.NavigationService.Navigate(new ClientView(null));
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientListView.NavigationService.LoadCompleted += NavigationService_LoadCompleted;
            Client client = (Client)this.clientListView.ClientListUserControl.ListClientL.SelectedItem;
            if (client == null)
                MessageBox.Show("Veuiller selectionner un client");
            else
                this.clientListView.NavigationService.Navigate(new ClientView(client));
        }
    }
}
