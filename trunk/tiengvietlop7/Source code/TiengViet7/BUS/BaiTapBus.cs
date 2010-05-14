using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class BaiTapBus
    {
        public static BaiTapDto[] LayBaiTapTheoTieuDeVanBan(string filename, string tieude)
        {
            BaiTapDto[] kq = BaiTapDao.LayBaiTapTheoTieuDeVanBan(filename, tieude);
            return kq;
        }

        public static string[] LayNoiDungCauHoi(BaiTapDto bt)
        {
            ArrayList myList = new ArrayList();
            foreach (CauHoiTuLuanDto ch in bt.DanhSachCauHoiTuLuan)
            {
                string nd = ch.NoiDung;
                myList.Add(nd);
            }
            string[] danh_sach_cau_hoi = (string[])myList.ToArray(typeof(string));
            return danh_sach_cau_hoi;
        }
    }
}
