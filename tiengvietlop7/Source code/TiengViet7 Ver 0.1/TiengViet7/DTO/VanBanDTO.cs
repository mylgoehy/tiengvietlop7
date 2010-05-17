using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DTO
{
    public class VanBanDTO
    {
        private string _TieuDe;
        public string TieuDe
        {
            get { return _TieuDe; }
            set { _TieuDe = value; }
        }

        private string _PhuDe;
        public string PhuDe
        {
            get { return _PhuDe; }
            set { _PhuDe = value; }
        }

        private string _AmThanh;
        public string AmThanh
        {
            get { return _AmThanh; }
            set { _AmThanh = value; }
        }

        private ArrayList _arrDoanVan;
        public System.Collections.ArrayList ArrDoanVan
        {
            get { return _arrDoanVan; }
            set { _arrDoanVan = value; }
        }
    }
}
