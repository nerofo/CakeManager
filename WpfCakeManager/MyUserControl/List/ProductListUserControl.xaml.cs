﻿using CakeManager.Entities;
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
    /// Logique d'interaction pour ProductUserControl.xaml
    /// </summary>
    public partial class ProductListUserControl : BaseUserControl
    {
        private Product product;

        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                this.OnPropertyChanged("Product");
            }
        }

        public ProductListUserControl()
        {
            InitializeComponent();
            
        }
    }
}
