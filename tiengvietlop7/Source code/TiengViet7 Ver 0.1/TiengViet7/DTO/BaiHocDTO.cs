using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DTO
{
    public class BaiHocDTO
    {
        private int _SoThuTu;
        public int SoThuTu
        {
            get { return _SoThuTu; }
            set { _SoThuTu = value; }
        }

        private ArrayList _arrBaiHocVanHoc;
        public System.Collections.ArrayList ArrBaiHocVanHoc
        {
            get { return _arrBaiHocVanHoc; }
            set { _arrBaiHocVanHoc = value; }
        }  
    }
}
