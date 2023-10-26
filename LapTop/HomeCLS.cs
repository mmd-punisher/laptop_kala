using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTop
{
    internal class HomeCLS
    {
        public HomeForm khaneh = null;
        public void Tarikh()
        {
            string[] Month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            DateTime dt1 = new DateTime();
            DateTime dt = DateTime.Now;
            khaneh.label2.Text = dt.Day.ToString();
            khaneh.label5.Text = Month[dt.Month - 1].ToString();
            khaneh.label6.Text = dt.Year.ToString();
        }
       
    }
}
