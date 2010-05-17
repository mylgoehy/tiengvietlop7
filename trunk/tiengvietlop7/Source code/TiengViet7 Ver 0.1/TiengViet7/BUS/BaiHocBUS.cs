using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class BaiHocBUS
    {
        public static BaiHocDTO LayBaiHoc(string BaiHoc_XML)
        {
            BaiHocDTO BaiHoc = BaiHocDAO.LayBaiHoc(BaiHoc_XML);
            return BaiHoc;
        }
    }
}
