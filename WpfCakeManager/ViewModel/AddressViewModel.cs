using CakeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCakeManager.Views;

namespace WpfCakeManager.ViewModel
{
    public class AddressViewModel
    {
        private AddressView addressView;

        public AddressViewModel(AddressView addressView)
        {
            this.addressView = addressView;

            Address address = new Address("2 rue des pouet", 35410,"Nouvoitou","FR");
            this.addressView.addressUserControl.Address = address;
        }
    }
}
