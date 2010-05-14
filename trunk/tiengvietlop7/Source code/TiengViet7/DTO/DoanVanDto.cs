using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DoanVanDto
    {
        private string _noiDung;
        public string NoiDung
        {
            get { return _noiDung; }
            set {
                _noiDung = value;
            }
        }
    }
}
