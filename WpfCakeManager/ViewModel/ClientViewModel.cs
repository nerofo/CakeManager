using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    public class ClientViewModel
    {
        private ClientView clientView;

        public ClientViewModel(ClientView clientView, Client client = null)
        {
            this.clientView = clientView;

            if (client == null)
                this.clientView.ClientUserControl.Load(0);
            else
                this.clientView.ClientUserControl.Load(client.Id);

            this.clientView.ValidateB.Click += ValidateB_Click;
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientView.ClientUserControl.Update();
            this.clientView.NavigationService.GoBack();
        }
    }
}
