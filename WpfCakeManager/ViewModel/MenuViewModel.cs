using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class MenuViewModel
    {
        private MenuView menuView;

        public MenuViewModel(MenuView menuView)
        {
            this.menuView = menuView;
            this.menuView.ClientManagerBtn.Click += ClientManagerBtn_Click;
        }

        private void ClientManagerBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.menuView.NavigationService.Navigate(new ClientListView());
        }
    }
}
