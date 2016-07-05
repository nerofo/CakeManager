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

namespace WpfCakeManager.MyUserControl.Single
{
    /// <summary>
    /// Logique d'interaction pour OwnerUserControl.xaml
    /// </summary>
    public partial class OwnerUserControl : BaseUserControl
    {
        private Owner owner;

        public Owner Owner
        {
            get { return owner; }
            set
            {
                owner = value;
                this.OnPropertyChanged("Owner");
            }
        }

        public OwnerUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
