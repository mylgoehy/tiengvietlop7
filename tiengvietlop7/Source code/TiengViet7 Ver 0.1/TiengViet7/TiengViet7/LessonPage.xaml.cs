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

using BUS;
using DTO;
using System.Windows.Forms;

using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

using System.Windows.Threading;

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

        private void LessonPage_Loaded(object sender, RoutedEventArgs e)
        {
            TreeViewItem th = new TreeViewItem();
            th = Bai10;
            string filename = "BaiVanHoc10.xml";
            BaiHocDTO bh1 = new BaiHocDTO();
            bh1 = BaiHocBUS.LayBaiHoc(filename);
            BaiHocGUI.Xuat(th, bh1);
        }    

        private void Image_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	// TODO: Add event handler implementation here.
            
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        Audio AmThanh;
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private void ResetAudio()
        {
            AmThanh.Stop();
            songTrack.Value = 0;
            dispatcherTimer.Stop();
        }

        ImageSourceConverter c = new ImageSourceConverter();

        private void TreeView1_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem th = (TreeViewItem)TreeView1.SelectedItem;
            TreeViewItem th2 = (TreeViewItem)Bai10.Items.GetItemAt(0);
            TreeViewItem th3 = (TreeViewItem)Bai10.Items.GetItemAt(1);

            string BaiHoc_XML = "BaiVanHoc10.xml";
            string[] ArrString;
//            string[] ArrString2;

            if (th == th2 || th == th3)
            {
                Title1.Text = th.Header.ToString();

                VanBanDTO VanBan = new VanBanDTO();
                VanBan = VanBanBUS.LayVanBanTheoTieuDe(BaiHoc_XML, Title1.Text);
                
                //Image1.Source = new BitmapImage(new Uri(VanBan.PhuDe, UriKind.Relative));
                //Image1.SetValue(Image.SourceProperty, new Uri(VanBan.PhuDe, UriKind.RelativeOrAbsolute));
                Image1.Source = (ImageSource)c.ConvertFromString(VanBan.PhuDe);

                ArrString = VanBanBUS.LayNoiDungVanBan(VanBan);

                if (ArrString.Length > 0)
                    textBox1.Text = ArrString[0];
                if (ArrString.Length > 1)
                    textBox2.Text = ArrString[1];

                textBox3.Text = "";

                BaiTapDTO[] DanhSachBaiTap = BaiTapBUS.LayBaiTapTheoTieuDeVanBan(BaiHoc_XML, Title1.Text);
                for (int i = 0; i < DanhSachBaiTap.Length; i++)
                {
                    ArrString = BaiTapBUS.LayNoiDungCauHoi(DanhSachBaiTap[i]);
                    textBox3.Text += ArrString[0];
                }

                if (VanBan.AmThanh != "")
                    AmThanh = new Audio(VanBan.AmThanh);
                //ResetAudio();
            }            
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            songTrack.Maximum = AmThanh.Duration;
            AmThanh.Play();

            dispatcherTimer.Tick += TimerTick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            dispatcherTimer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            songTrack.Value = AmThanh.CurrentPosition;
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            ResetAudio();
        }

        private void songTrack_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            AmThanh.CurrentPosition = songTrack.Value;
        }
    }
}
