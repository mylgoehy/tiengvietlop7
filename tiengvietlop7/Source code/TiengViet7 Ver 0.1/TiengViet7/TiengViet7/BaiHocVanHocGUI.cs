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
    public class BaiHocVanHocGUI
    {
        public static TreeViewItem The_Hien(BaiHocVanHocDTO bhvh)
        { 
            //string ten = "Bai Hoc Van Hoc " + bhvh.SoThuTu;
            TreeViewItem kq = new TreeViewItem();   
         
            VanBanDTO vb = bhvh.VanBan;
            kq.Header = vb.TieuDe;
            kq.Items.Add(VanBanGUI.The_Hien(vb));
            kq.Tag = bhvh;
         
            return kq;
        }
    }
}
