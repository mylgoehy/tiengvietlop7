using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class BaiHocBus
    {
        public static BaiHocDto LayBaiHoc(string ten_tap_tin)
        {
            BaiHocDto kq = BaiHocDao.LayBaiDoc(ten_tap_tin);
            return kq;
        }
    }


}
