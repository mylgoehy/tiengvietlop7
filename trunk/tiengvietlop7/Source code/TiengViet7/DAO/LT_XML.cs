using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DAO
{
    public class LT_XML
    {
        public static XmlDocument Doc(string Ten_tap_tin)
        {
            XmlDocument kq = new XmlDocument();
            kq.Load(Ten_tap_tin);            
            return kq;
        }        
    }    
}
