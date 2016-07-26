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

        public ClientViewModel(ClientView clientView)
        {
            this.clientView = clientView;

            Client client = new Client();
            this.clientView.ClientUserControl.Load(0);
            this.clientView.ValidateB.Click += ValidateB_Click;
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.clientView.ClientUserControl.Update();
            this.clientView.NavigationService.GoBack();
        }
    }
}
