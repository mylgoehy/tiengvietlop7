using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Temp
{
    public partial class PageSwitcher : UserControl
    {
        public PageSwitcher()
        {
            InitializeComponent();
        }
        // 1st overload
      public void Navigate( UserControl nextPage )
      {
         this.Content = nextPage;
      }
 
       // 2nd overload
      public void Navigate(UserControl nextPage, object state)
      {
          this.Content = nextPage;
          ISwitchable s = nextPage as ISwitchable;
          if (s != null)
          {
              s.UtilizeState(state);
          }
          else
          {
              throw new ArgumentException("nextPage is not ISwitchable! " + nextPage.Name.ToString());
          }
      }
    }
}
