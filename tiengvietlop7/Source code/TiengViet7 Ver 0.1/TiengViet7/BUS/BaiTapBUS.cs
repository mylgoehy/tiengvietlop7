using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class BaiTapBUS
    {
        public static BaiTapDTO[] LayBaiTapTheoTieuDeVanBan(string BaiHoc_XML, string tieude)
        {
            BaiTapDTO[] DanhSachBaiTap = BaiTapDAO.LayBaiTapTheoTieuDeVanBan(BaiHoc_XML, tieude);
            return DanhSachBaiTap;
        }

        public static string[] LayNoiDungCauHoi(BaiTapDTO BaiTap)
        {
            ArrayList myList = new ArrayList();

            foreach (CauHoiTuLuanDTO CauHoiTuLuan in BaiTap.ArrCauHoi)
            {
                string nd = CauHoiTuLuan.NoiDung;
                myList.Add(nd);
            }

            string[] DanhSachCauHoi = (string[])myList.ToArray(typeof(string));
            return DanhSachCauHoi;
        }
    }
}
