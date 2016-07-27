using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.ViewModel
{
    class OwnerViewModel
    {
        private OwnerView ownerView;

        public OwnerViewModel(OwnerView ownerView)
        {
            this.ownerView = ownerView;
            this.ownerView.ValidateB.Click += ValidateB_Click;
        }

        private void ValidateB_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.ownerView.OwnerUserControl.Update();
            this.ownerView.NavigationService.GoBack();
        }
    }
}
