using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BaiHocVanHocDto
    {
        private int _soTT;
        private VanBanDto _vanBan;
        private DocHieuDto _docHieu;
        private string _loaiBaiHocVH;

        public int SoThuTu
        {
            get { return _soTT; }
            set {
                _soTT = value;
            }
        }

        public VanBanDto VanBan
        {
            get { return _vanBan; }
            set {
                _vanBan = value;
            }
        }

        public DocHieuDto DocHieu
        {
            get { return _docHieu; }
            set {
                _docHieu = value;
            }
        }

        public string LoaiBaiHocVanHoc
        {
            get { return _loaiBaiHocVH; }
            set {
                _loaiBaiHocVH = value;
            }
        }
    }
}
