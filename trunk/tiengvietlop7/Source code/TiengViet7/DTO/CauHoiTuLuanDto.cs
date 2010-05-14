using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CauHoiTuLuanDto
    {        

        private int _soTT;
        private string _noiDung;

        public CauHoiTuLuanDto()
        {
            _soTT = 0;
            _noiDung = "";
        }

        public int SoTT
        { 
            get { return _soTT; }
            set {
                _soTT = value;
            }
        }

        public string NoiDung
        { 
            get {return _noiDung;}
            set {
                _noiDung = value;
            }
        }

    }
}
