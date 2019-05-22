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
    public partial class FormWeekView : Form
    {
        private readonly int sizeWidth = 115;
        private readonly int sizeHeight = 22;

        private readonly Point SevenAM = new Point(104, 34);
        private readonly Point Seven15 = new Point(104, 54);
        private readonly Point Seven30 = new Point(104, 75);
        private readonly Point Seven45 = new Point(104, 96);

        public FormWeekView()
        {
            InitializeComponent();

            Button b = new Button();
            b.Size = new Size(sizeWidth, sizeHeight); ;
            b.Location = SevenAM;
            b.Visible = true;
            panel1.Controls.Add(b);
            b.BringToFront();
        }

        public void checkAppointmentBookAvailability()
        {

        }

        public Point getLocationPoint(int startTime)
        {
            if (startTime == 7)
            {
                return new Point(104, 34);
            }
            if (startTime == 7)
            {
                return new Point();
            }
            if (startTime == 8)
            {
                return new Point();
            }
            if (startTime == 9)
            {
                return new Point();
            }
            if (startTime == 10)
            {
                return new Point();
            }
            if (startTime == 11)
            {
                return new Point();
            }
            else
            {
                return new Point(0, 0);
            }
        }

        private void newButton(Appointment app)
        {
            Button b = new Button();

            if (app.getLength() == 1)
            {
                b.Size = new Size(sizeWidth, sizeHeight); ;
            }
            if (app.getLength() == 2)
            {
                b.Size = new Size(sizeWidth, sizeHeight * 2); ;
            }
            if (app.getLength() == 3)
            {
                b.Size = new Size(sizeWidth, sizeHeight * 3); ;
            }
            if (app.getLength() == 4)
            {
                b.Size = new Size(sizeWidth, sizeHeight * 4); ;
            }

            if (app.getStartTime().Hour == 7)
            {
                b.Location = SevenAM;
            }
            {

            }
        }
    }
}
