using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleChefs
{
    public partial class Form14 : Form
    {
        List<SplitContainer> weekList = new List<SplitContainer>();
        int x = 12;
        int startY = 174;

        public Form14()
        {
            InitializeComponent();
            pageSetup(2);
        }

        public void pageSetup(int weeks)
        {
            var sp = new Form8(1);
            var sp2 = new Form8(2);
            weekList.Add(sp.getWeekPanel());
            weekList.Add(sp2.getWeekPanel());


            weekList[0].Location = new Point(x, startY);
            weekList[0].Visible = true;
            this.Controls.Add(weekList[0]);
            getNewCoordinates();
            weekList[1].Location = new Point(x, startY);
            weekList[1].Visible = true;
            this.Controls.Add(weekList[1]);

        }

        private void getNewCoordinates()
        {
            startY += 195;
        }
    }
}
