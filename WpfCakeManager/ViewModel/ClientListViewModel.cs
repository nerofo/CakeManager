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
            var r1 = client.LoadSingleItem();
            var r1s = client.LoadMultipleItem();
            List<Client> clients = new List<Client>();
            clients.Add(r1);
            this.clientListView.ClientListUserControl.LoadItems(r1s);
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientListView.NavigationService.Navigate(new ClientView());
        }
    }
}
