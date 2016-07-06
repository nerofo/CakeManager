using CakeManager.Database;
using CakeManager.Entities;
using CakeManager.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientListView.NavigationService.Navigate(new ClientView());
        }
    }
}
