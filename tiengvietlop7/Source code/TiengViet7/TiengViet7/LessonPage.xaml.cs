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
    /// Interaction logic for LessonPage.xaml
    /// </summary>
    public partial class LessonPage : Window
    {
        public LessonPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {      
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void LessonPage_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Bai_01_Click(object sender, RoutedEventArgs e)
        {
            LessonPageDetail lessonPageDetail = new LessonPageDetail();
            lessonPageDetail.Show();
            this.Close();
        }
    }
}
