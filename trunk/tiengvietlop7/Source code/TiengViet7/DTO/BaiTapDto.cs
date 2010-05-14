using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BaiTapDto
    {
        private int _soTT;
        private ArrayList _arrCauHoiTuLuan;

        public int SoTT
        {
            get { return _soTT; }
            set {
                _soTT = value;
            }
        }

        public ArrayList DanhSachCauHoiTuLuan
        {
            get { return _arrCauHoiTuLuan; }
            set {
                _arrCauHoiTuLuan = value;
            }
        }
    }
}
