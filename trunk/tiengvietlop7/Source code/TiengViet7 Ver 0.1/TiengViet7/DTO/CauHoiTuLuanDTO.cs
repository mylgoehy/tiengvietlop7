using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CauHoiTuLuanDTO
    {
        private int _SoThuTu;
        public int SoThuTu
        {
            get { return _SoThuTu; }
            set { _SoThuTu = value; }
        }

        private string _NoiDung;
        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }
    }
}
