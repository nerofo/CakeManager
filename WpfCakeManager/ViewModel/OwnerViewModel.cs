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
        }
    }
}
