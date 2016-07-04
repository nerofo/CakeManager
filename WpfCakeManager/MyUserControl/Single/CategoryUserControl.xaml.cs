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
    /// Logique d'interaction pour CategoryUserControl.xaml
    /// </summary>
    public partial class CategoryUserControl : BaseUserControl
    {
        private Category category;

        public Category Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
                this.OnPropertyChanged("Category");
            }
        }

        public CategoryUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
