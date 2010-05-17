using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DTO
{
    public class DocHieuDTO
    {
        private ArrayList _arrBaiTap;
        public System.Collections.ArrayList ArrBaiTap
        {
            get { return _arrBaiTap; }
            set { _arrBaiTap = value; }
        }
    }
}
