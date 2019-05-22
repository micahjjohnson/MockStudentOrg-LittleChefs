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
    public partial class FormSection : Form
    {
        private LC lc;
        private Course course;
        private Section section;
        private int dayCount;
        private int weeks;

        private List<string> dayList = new List<string>();
        private DateTime startDate;
        private DateTime endDate;


        public FormSection()
        {
            InitializeComponent();
            lc = Resources.littleChefs;
            foreach (Course c in Resources.littleChefs.ControlClass.getCourseList())
            {
                courseSelection.Items.Add(c.getCourseName());
            }
            collapse();
        }
        public Section getSection()
        {
            return section;
        }
        public Panel getSectionPanel()
        {
            return panel1;
        }

        private void expandPanel()
        {
            next_panel.Visible = false;
            section_panel.Visible = true;
            this.Size = new Size(704, 538);
            panel1.Size = new Size(676, 488);
        }
        private void collapse()
        {
            this.Size = new Size(704, 192);
            panel1.Size = new Size(676, 143);
            //section_panel.Visible = false;
        }
        private void calculateWeekLength()
        {
            weeks = ((endDate - startDate).Days) / 7;

            if (weeks > 0)
            {
                week_lbl.Text = weeks + " week(s)";
            }
        }
        private void calculateMoneyValue()
        {
            double cash = 0;
            try
            {
                if (freq_pay_indicator.SelectedIndex == 0)
                {
                    cash = double.Parse(money.Text) * weeks;
                }
                if (freq_pay_indicator.SelectedIndex == 1)
                {
                    cash = (double.Parse(money.Text) * dayCount) * weeks;
                }
            }
            catch { }

            money_lbl.Text = "$ " + cash;
        }
        private void calcTimeSpan()
        {
            try
            {
                var StartTime = DateTime.Parse(startHour.Text + ":" + startMin.Text+" "+ comboBox4.SelectedItem.ToString().ToUpper());
                var EndTime = DateTime.Parse(endHour.Text + ":" + endMin.Text + " " + comboBox2.SelectedItem.ToString().ToUpper());
                var timespan = EndTime - StartTime;

                length_lbl.Text = timespan.Duration().ToString();
            }
            catch { }
        }
        private void refreshFields()
        {
            calculateMoneyValue();
            calculateWeekLength();
            calcTimeSpan();
        }
        private bool requiredFieldsAreEmpty()
        {
            return sectionName.Text.Length == 0 || startHour.Text.Length == 0
                || startMin.Text.Length == 0 || endHour.Text.Length == 0
                || endMin.Text.Length == 0 || money.Text.Length == 0;
        }

        private void next_Click(object sender, EventArgs e)
        {
            courseSelection.Enabled = false;

            foreach (Course c in Resources.littleChefs.ControlClass.getCourseList())
            {
                if (courseSelection.SelectedText.Equals(c.getCourseName()))
                {
                    course = c;
                }
            }
            expandPanel();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;

            if (c.Checked)
            {
                ++dayCount;
                dayList.Add(c.Text);
            }
            else
            {
                if (dayCount > 0)
                {
                    --dayCount;
                    dayList.Remove(c.Text);
                }
            }
            dayCount_lbl.Text = dayCount + " day(s)";
            refreshFields();
        }
        private void sectionName_Label_TextChanged(object sender, EventArgs e)
        {
            section_lbl.Text = sectionName.Text.ToUpper() + number.Text;
        }
        private void start_date_ValueChanged(object sender, EventArgs e)
        {
            startDate = start_date.Value;
            refreshFields();
        }
        private void end_date_ValueChanged(object sender, EventArgs e)
        {
            endDate = end_date.Value;
            refreshFields();
        }

        private void univ_TextChanged(object sender, EventArgs e)
        {
            refreshFields();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!requiredFieldsAreEmpty())
            {
                section = new Section(section_lbl.Text, number.Text, decimal.Parse(money.Text));
                section.setStartDate(startDate);
                section.setEndDate(endDate);
                section.setStartTime(int.Parse(startHour.Text), int.Parse(startMin.Text));
                section.setEndTime(int.Parse(endHour.Text), int.Parse(endMin.Text));
                section.setFreqDayList(dayList);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter all required fields.");
            }
        }

        private void courseSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            next.Enabled = true;
        }
    }
}
