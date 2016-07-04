﻿using System;
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
using WpfCakeManager.ViewModel;

namespace WpfCakeManager.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour ClientView.xaml
    /// </summary>
    public partial class ClientView : Page
    {
        private ClientViewModel clientViewModel;

        public ClientView()
        {
            InitializeComponent();
            this.clientViewModel = new ClientViewModel(this);
        }
    }
}
