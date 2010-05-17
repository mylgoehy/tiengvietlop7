using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DTO
{
    public class BaiTapDTO
    {
        private int _SoThuTu;
        public int SoThuTu
        {
            get { return _SoThuTu; }
            set { _SoThuTu = value; }
        }

        private ArrayList _arrCauHoi;
        public System.Collections.ArrayList ArrCauHoi
        {
            get { return _arrCauHoi; }
            set { _arrCauHoi = value; }
        }
    }
}
