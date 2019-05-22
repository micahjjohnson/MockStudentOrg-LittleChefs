using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LittleChefs
{
    public partial class Form1 : Form
    {
        private Student selectedStudent;

        private List<Panel> formPanelList;
        private List<Panel> bottomFormPanelList;
        private FormStudent studentPanel;
        private FormBilling billingPanel;
        private Form12 studentListEntryPanel;
        private FormSection newSectionPanel;


        private readonly static int STUDENT_FORM = 0;
        private readonly static int BILLING_FORM = 1;
        //private readonly static int STUDENT_FORM = 0;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            //create panel variables
            formPanelList = new List<Panel>();
            bottomFormPanelList = new List<Panel>();
            studentPanel = new FormStudent();
            billingPanel = new FormBilling();
            newSectionPanel = new FormSection();
            studentListEntryPanel = new Form12();


            //add panels to list
            formPanelList.Add(studentPanel.getPanel());                 // 1
            formPanelList.Add(billingPanel.getBillingPanel());          // 2
            formPanelList.Add(newSectionPanel.getSectionPanel());       // 3

            //add panels to bottom list (as default or option)
            bottomFormPanelList.Add(studentListEntryPanel.getStudentEntryListPanel());    //2

            //add panels to form
            foreach (Panel p in formPanelList)
            {
                p.Location = panel1.Location;
                p.Size = panel1.Size;
                this.Controls.Add(p);
            }
            foreach (Panel p in bottomFormPanelList)
            {
                p.Location = panel2.Location;
                p.Size = panel2.Size;
                this.Controls.Add(p);
            }

            showPanelOnTop(0);
            showPanelOnBottom(0);
        }
        public void testMethod()
        {
            showPanelOnTop(1);
            MessageBox.Show("Hello");
            showPanelOnTop(2);
        }
        public void showPanelOnTop(int x)
        {
            panel1.BringToFront();
            switch (x)
            {
                case 0:
                    panel1.BringToFront();
                    schedule.Enabled = false;
                    break;
                case 1:
                    formPanelList[0].BringToFront();
                    billing.Enabled = true;
                    back_bt.Enabled = false;
                    schedule.Enabled = true;
                    break;
                case 2:
                    formPanelList[1].BringToFront();
                    back_bt.Enabled = true;
                    break;
                case 3:
                    formPanelList[2].BringToFront();
                    break;
            }
        }
        public void showPanelOnBottom(int x)
        {
            panel2.BringToFront();
            switch (x)
            {
                case 0:
                    panel2.BringToFront();
                    break;
                case 1:
                    extend_bt.Enabled = true;
                    bottomFormPanelList[0].BringToFront();
                    break;
                /*case 3:
                    //formPanelList[BILLING_FORM].Visible = true;
                    formPanelList[2].BringToFront();
                    break;
                case 4:
                    //formPanelList[BILLING_FORM].Visible = true;
                    formPanelList[3].BringToFront();
                    break;*/
            }
        }
        private Student returnStudent(string s)
        {
            foreach (Student p in Resources.littleChefs.ControlStudent.getStudents())
            {
                if (p.getFullName().Equals(s))
                {
                    return p;
                }
            }
            return null;
        }
        private void search_results_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Student p in Resources.littleChefs.ControlStudent.getStudents())
                {
                    if (p.getFullName().Equals(search_results.SelectedItem.ToString()))
                    {
                        selectedStudent = p;
                        break;
                    }
                }

                studentPanel.prefillForm(selectedStudent);
                showPanelOnTop(1);
                /*
                FormStudent pe = new FormStudent();
                var pp = pe.getPanel();
                pe.prefillForm(selectedStudent);
                pp.Location = panel1.Location;
                pp.Size = panel1.Size;
                pp.Visible = true;
                this.Controls.Add(pp);
                pp.BringToFront();
                panel1.BringToFront();
                pp.BringToFront();
                billing.Enabled = true;
                back_bt.Enabled = false;
                */
            }
            catch (NullReferenceException)
            {
            }   
        }
        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form4();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
        private void search_Click(object sender, EventArgs e)
        {
            //selectedStudent = null;
            search_results.Items.Clear();
            Search s;

            if (comboBox1.SelectedItem.ToString().Equals("Students"))
            {
                s = new Search(Resources.littleChefs.ControlStudent.getStudents(), search_entry.Text.Trim());

                if (s.getSearchResults().Count == 0)
                {
                    search_results.Items.Add("No results found.");
                }
                else
                {
                    foreach (Student p in s.getSearchResults())
                    {
                        search_results.Items.Add(p.getFullName());
                    }
                }
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Sections"))
            {
                s = new Search(Resources.littleChefs.ControlClass.getCourseList(), search_entry.Text.Trim());

                if (s.getSearchResults().Count == 0)
                {
                    search_results.Items.Add("No results found.");
                }
                else
                {
                    foreach (Section se in s.getSectionSearchResults())
                    {
                        search_results.Items.Add(se.getSectionNum());
                    }
                }
            }
            else
            {
                MessageBox.Show("Search not implemented...");
            }
        }
        private void new_Student_Click(object sender, EventArgs e)
        {
            var newStudentForm = new FormStudent();
            newStudentForm.ShowDialog();

            if (newStudentForm.DialogResult != DialogResult.Cancel)
            {
                var workingStudent = newStudentForm.getStudent();
                Resources.littleChefs.ControlStudent.newStudent(workingStudent);
                var enrollForm = new FormEnroll(workingStudent);
                enrollForm.ShowDialog();
            }
        }
        private void billing_Click(object sender, EventArgs e)
        {
            billingPanel.fillInformation(selectedStudent);
            showPanelOnTop(2);
        }
        private void withdraw_Click(object sender, EventArgs e)
        {
            var form10 = new Form10(selectedStudent);
            form10.ShowDialog();

        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedStudent = null;
        }
        private void new_Section_Click(object sender, EventArgs e)
        {
            var section = new FormSection();
            section.ShowDialog();

            if (section.DialogResult != DialogResult.Cancel)
            {
                Resources.littleChefs.ControlClass.createSection(section.getSection(), new Course("sample"));
            }
        }
        private void back_bt_Click(object sender, EventArgs e)
        {
            showPanelOnTop(1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //enrollFormPanel.setStudent(selectedStudent);
            showPanelOnTop(4);
        }

        private void allStudent_Click_1(object sender, EventArgs e)
        {
            studentListEntryPanel.loadEntries();
            showPanelOnBottom(2);
        }

        private void advancedSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_results.Size = new Size(310, 526);
            search_results.Location = new Point(20, 297);
            search_results.Items.Clear();
            advSearchOpts.Visible = true;
        }
    }
}