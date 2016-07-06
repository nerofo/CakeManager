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
using CakeManager.Entities;
using System.Collections.ObjectModel;

namespace WpfCakeManager.MyUserControl.List
{
    /// <summary>
    /// Logique d'interaction pour ShopUserControl.xaml
    /// </summary>
    public partial class ShopListUserControl : BaseUserControl
    {
        private ObservableCollection<Shop> shops;

        public ObservableCollection<Shop> Shop
        {
            get { return shops; }
            set { shops = value; this.OnPropertyChanged("Shop"); }
        }


        public ShopListUserControl()
        {
            InitializeComponent();
            this.shops = new ObservableCollection<Shop>();
            this.ListShopL.ItemsSource = this.shops;
        }

        public void LoadItems(List<Shop> items)
        {
            this.shops.Clear();
            foreach (var item in items)
            {
                this.shops.Add(item);
            }
        }
    }
}
