using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TiengViet7
{
    /// <summary>
    /// Interaction logic for CompositionPageDetail.xaml
    /// </summary>
    public partial class CompositionPageDetail : Window
    {
        public CompositionPageDetail()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            CompositionPage compositionPage = new CompositionPage();
            compositionPage.Show();
            this.Close();
        }
    }
}
