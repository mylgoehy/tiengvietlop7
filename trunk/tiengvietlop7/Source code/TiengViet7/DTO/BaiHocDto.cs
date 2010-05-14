using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BaiHocDto
    {
        private int _soTT;
        private ArrayList _arrBaiHocVH;

        public int SoThuTu
        {
            get { return _soTT; }
            set {
                _soTT = value;
            }
        }

        public ArrayList DanhSachBaiVanHoc
        {
            get { return _arrBaiHocVH; }
            set {
                _arrBaiHocVH = value;
            }
        }
    }
}
