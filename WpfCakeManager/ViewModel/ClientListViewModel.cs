using CakeManager.Entities;
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

            //TODO JEU DE DONNEES A ENLEVER
            Client client = new Client();
            Client client2 = new Client();
            List<Client> clients = new List<Client>();
            clients.Add(client);
            clients.Add(client2);
            this.clientListView.ClientListUserControl.LoadItems(clients);
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientListView.NavigationService.Navigate(new ClientView());
        }
    }
}
