using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using BUS;
using DTO;

namespace TiengViet7
{
    public class VanBanGUI
    {
        public static TreeViewItem The_Hien(VanBanDTO vb)
        {
            TreeViewItem kq = new TreeViewItem();
            kq.Tag = vb;
            return kq;
        }
    }
}
