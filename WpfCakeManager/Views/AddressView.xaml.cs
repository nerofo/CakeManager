using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfCakeManager.ViewModel;

namespace WpfCakeManager.Views
{
    /// <summary>
    /// Logique d'interaction pour AddressView.xaml
    /// </summary>
    public partial class AddressView : Window
    {
        private AddressViewModel addressViewModel;

        public AddressViewModel AddressViewModel
        {
            get
            {
                return addressViewModel;
            }

            set
            {
                addressViewModel = value;
            }
        }

        public AddressView()
        {
            InitializeComponent();
            this.AddressViewModel = new AddressViewModel(this);
        }
    }
}
