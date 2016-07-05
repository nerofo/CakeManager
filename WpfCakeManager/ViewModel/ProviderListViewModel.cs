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
            Provider provider = new Provider();
            List<Provider> providers = new List<Provider>();
            providers.Add(provider);
            this.providerListView.ProviderListUserControl.LoadItems(providers);
        }
    }
}
