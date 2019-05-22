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
    public partial class Form8 : Form
    {
        Section section = new Section("Sec Name", "1", 5.99m);

        private List<Button> weekButtonList;

        public Form8(int weekNum)
        {
            InitializeComponent();
            weekButtonList = new List<Button>();
            groupBox2.Text = "Week " + weekNum;
            week_Container.Panel2Collapsed = true;

            //section example details
            List<string> fexample = new List<string>();
            fexample.Add("M");
            fexample.Add("W");
            fexample.Add("Th");
            section.setFreqDayList(fexample);
            section.setStartDate(new DateTime(2017, 08, 01));
            section.setEndDate(new DateTime(2017, 09, 01));

            // add buttons to button list
            weekButtonList.Add(button1);
            weekButtonList.Add(button2);
            weekButtonList.Add(button3);
            weekButtonList.Add(button4);
            weekButtonList.Add(button5);
            weekButtonList.Add(button6);
            weekButtonList.Add(button7);

            for (int i = 0; i < section.getFreqDayList().Count; i++)
            {
                weekButtonList[i].Visible = true;
                setButtonDetails(weekButtonList[i], section.getFreqDayList()[i], "1/25/17", i + 1);
            }
        }
        public SplitContainer getWeekPanel()
        {
            return week_Container;
        }


        private void setButtonDetails(Button b, string dayOfWeek, string date, int dayIndex)
        {
            b.Text = dayOfWeek + "\n" + date + "\nDay " + dayIndex;
        }
        private void resize_bt_CheckedChanged(object sender, EventArgs e)
        {
            if (resize_bt.Checked)
            { 
                resize_bt.Text = "collapse";
                week_Container.Size = new Size(784, 180);
                week_Container.Panel2Collapsed = false;
            }
            else
            {
                resize_bt.Text = "expand";
                week_Container.Panel2Collapsed = true;
            }
        }

        private void cancelClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip menu = sender as ContextMenuStrip;
            //Control sourceControl = menu.SourceControl;
            //MessageBox.Show(sourceControl.Name);
        
        }
    }
}
