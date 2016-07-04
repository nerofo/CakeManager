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
using WpfCakeManager.Views;
using WpfCakeManager.Views.Pages;

namespace WpfCakeManager.Views
{
    /// <summary>
    /// Logique d'interaction pour NavigationWindows1.xaml
    /// </summary>
    public partial class NavigationWindows1 : NavigationWindow
    {
        public NavigationWindows1()
        {
            InitializeComponent();
            this.NavigationService.Navigate(new ClientListView());
        }
    }
}
