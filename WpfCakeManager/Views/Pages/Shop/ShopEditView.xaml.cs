using CakeManager.Entities;
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
    public partial class ShopEditView : Page
    {
        private ShopEditViewModel shopEditViewModel;

        public ShopEditViewModel ShopEditViewModel
        {
            get
            {
                return shopEditViewModel;
            }

            set
            {
                shopEditViewModel = value;
            }
        }

        public ShopEditView(Shop shop)
        {
            InitializeComponent();
            this.shopEditViewModel = new ShopEditViewModel(this, shop);
        }
    }
}
