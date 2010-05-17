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
    public class BaiHocGUI
    {
        public static void Xuat(TreeViewItem th, BaiHocDTO bh)
        {
            foreach (BaiHocVanHocDTO bhvh in bh.ArrBaiHocVanHoc)
            {
                th.Items.Add(BaiHocVanHocGUI.The_Hien(bhvh));
            }
            th.Tag = bh;
        }
    }
}
