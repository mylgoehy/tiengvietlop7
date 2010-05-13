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
using System.Windows.Media.Animation;

namespace TiengViet7
{
    /// <summary>
    /// Interaction logic for CompositionPage.xaml
    /// </summary>
    public partial class CompositionPage : Window
    {
        public CompositionPage()
        {
            InitializeComponent();
        }

        double _marqueeTimeInSeconds = 7;

        private void LeftToRightMarquee()
        {
            double height = canMain.ActualHeight - tbmarquee.ActualHeight;
            tbmarquee.Margin = new Thickness(0, height / 2, 0, 0);
            DoubleAnimation doubleAnimation = new DoubleAnimation();
            doubleAnimation.From = -tbmarquee.ActualWidth;
            doubleAnimation.To = canMain.ActualWidth;
            doubleAnimation.RepeatBehavior = RepeatBehavior.Forever;
            doubleAnimation.Duration = new Duration(TimeSpan.FromSeconds(_marqueeTimeInSeconds));
            tbmarquee.BeginAnimation(Canvas.LeftProperty, doubleAnimation);
        }

        private void CompositionPage_Loaded(object sender, RoutedEventArgs e)
        {
            LeftToRightMarquee();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void Bai_01_Click(object sender, RoutedEventArgs e)
        {
            CompositionPageDetail compositionPageDetail = new CompositionPageDetail();
            compositionPageDetail.Show();
            this.Close();
        }
    }
}
