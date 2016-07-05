using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class ProviderListViewModel
    {
        private ProviderListView providerListView;
        
        public ProviderListViewModel(ProviderListView providerListView)
        {
            this.providerListView = providerListView;

            //TODO JEU DE DONNEES A ENLEVER
            Provider product1 = new Provider();
            product1.Id = 1;
            product1.Name = "George";
            Provider product2 = new Provider();
            product2.Id = 2;
            product2.Name = "Trouduc";

            List<Provider> providers = new List<Provider>();
            providers.Add(product1);
            providers.Add(product2);
            this.providerListView.ProviderListUserControl.LoadItems(providers);
        }
    }
}
