﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
using TravelApp.Services;

namespace TravelApp.Views
{
    /// <summary>
    /// Interaction logic for LogInPageView.xaml
    /// </summary>
    public partial class LogInPageView : UserControl, IPasswordSupplier
    {
        public LogInPageView()
        {
            InitializeComponent();
        }

        public SecureString GetPassword { get => pBox.SecurePassword; }

        public bool ConfirmPassword()
        {
            throw new NotImplementedException();
        }
    }
}
