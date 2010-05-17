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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void GrammarButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void LessonButton_Click(object sender, RoutedEventArgs e)
        {
            LessonPage lessonPage = new LessonPage();
            lessonPage.Show();
            this.Close();
        }

        private void CompositionButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReadMoreButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
