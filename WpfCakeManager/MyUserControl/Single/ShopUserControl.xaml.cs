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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfCakeManager.MyUserControl
{
    /// <summary>
    /// Logique d'interaction pour ShopUserControl.xaml
    /// </summary>
    public partial class ShopUserControl : BaseUserControl
    {
        private Shop shop;

        public Shop Shop
        {
            get { return shop; }
            set
            {
                shop = value;
                this.OnPropertyChanged("Shop");
            }
        }

        public ShopUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
