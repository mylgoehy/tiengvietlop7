using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Temp
{
    public static class Switcher
    {
        public static PageSwitcher pageSwitcher;

        public static void Switch(UserControl newPage)
        {

            if (pageSwitcher != null)
            {
                pageSwitcher.Navigate(newPage);
            }
            else
            {

                throw new Exception("Switcher.pageSwitcher is null");
            }
        }

        public static void Switch(UserControl newPage, object state)
        {
            if (pageSwitcher != null)
            {
                pageSwitcher.Navigate(newPage, state);
            }
            else
            {
                throw new Exception("Switcher.pageSwitcher is null");
            }
        }
    }
}
