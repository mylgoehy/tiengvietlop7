using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BaiHocVanHocDTO
    {
        private int _SoThuTu;
        public int SoThuTu
        {
            get { return _SoThuTu; }
            set { _SoThuTu = value; }
        }

        private string _LoaiBaiHocVanHoc;
        public string LoaiBaiHocVanHoc
        {
            get { return _LoaiBaiHocVanHoc; }
            set { _LoaiBaiHocVanHoc = value; }
        }

        private VanBanDTO _VanBan;
        public VanBanDTO VanBan
        {
            get { return _VanBan; }
            set { _VanBan = value; }
        }

        private DocHieuDTO _DocHieu;
        public DocHieuDTO DocHieu
        {
            get { return _DocHieu; }
            set { _DocHieu = value; }
        }
    }
}
