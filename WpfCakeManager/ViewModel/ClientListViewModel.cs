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

            //TODO JEU DE DONNEES A ENLEVER
            Client client = new Client();
            client.Id = 1;
            client.Name = "Plouf";
            Address address = new Address();
            address.Id = 1;
            address.Street = "5 rue des emmerdes";
            client.Address = address;

            MySQLManager<Client> manager1 = new MySQLManager<Client>(DataConnectionResource.LOCALMYQSL);
            MySQLManager<Address> manager2 = new MySQLManager<Address>(DataConnectionResource.LOCALMYQSL);
            manager1.Insert(client);
            
        }

        private void EditBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientListView.NavigationService.Navigate(new ClientView());
        }
    }
}
