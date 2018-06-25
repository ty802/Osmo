﻿using Osmo.ViewModel;
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

namespace Osmo.UI
{
    /// <summary>
    /// Interaction logic for TemplatePreview.xaml
    /// </summary>
    public partial class TemplatePreview : Grid
    {
        public TemplatePreview()
        {
            InitializeComponent();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            TemplatePreviewViewModel vm = DataContext as TemplatePreviewViewModel;
            if (!string.IsNullOrWhiteSpace(vm.PreviewText))
            {
                Clipboard.SetText(vm.PreviewText);
            }
        }
    }
}
