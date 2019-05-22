using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleChefs
{
    public partial class Cal : Form
    {
        public Cal()
        {
            InitializeComponent();

            Calendar cal = CultureInfo.InvariantCulture.Calendar;
            MessageBox.Show(cal.GetDaysInMonth(2017, 2)+"");
            MessageBox.Show(cal.GetDayOfWeek(new DateTime(2017 - 2 - 1))+"");
        }
    }
}
