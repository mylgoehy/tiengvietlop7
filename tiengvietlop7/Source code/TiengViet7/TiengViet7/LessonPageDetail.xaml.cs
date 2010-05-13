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
    /// Interaction logic for LessonPageDetail.xaml
    /// </summary>
    public partial class LessonPageDetail : Window
    {
        public LessonPageDetail()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            LessonPage lessonPage = new LessonPage();
            lessonPage.Show();
            this.Close();
        }
    }
}
