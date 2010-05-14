using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DocHieuDto
    {
        private ArrayList _arrBaiTap;

        public ArrayList DanhSachBaiTap
        {
            get { return _arrBaiTap; }
            set {
                _arrBaiTap = value;
            }
        }
    }
}
