using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace DTO
{
    public class VanBanDto
    {
        private string _tieuDe;
        private string _phuDe;
        private string _amThanh;        
        private ArrayList _cacDoanVan;
        

        public string TieuDe
        {
            get { return _tieuDe; }
            set {
                _tieuDe = value;
            }
        }

        public string PhuDe
        {
            get { return _phuDe; }
            set
            {
                _phuDe = value;
            }
        }

        public string AmThanh
        {
            get { return _amThanh; }
            set
            {
                _amThanh = value;
            }
        }

        public ArrayList DanhSachDoanVan
        {
            get { return _cacDoanVan; }
            set {
                _cacDoanVan = value;
            }
        }
    }
}
