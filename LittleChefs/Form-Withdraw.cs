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
    public partial class Form10 : Form
    {
        private Student student;
        private LC lc;
        private Course selectedCourse;
        private List<Section> selectedSections = new List<Section>();

        public Form10(Student s)
        {
            InitializeComponent();
            lc = Resources.littleChefs;
            student = s;

            name.Text = "Student: " + student.getFullName();
            foreach (Section se in student.getCourseList())
            {
                course_box.Items.Add(se.getSectionCourse().getCourseName());
            }
        }

        /*
        private void save_Click(object sender, EventArgs e)
        {
            foreach (var i in wCourse_box.Items)
            {
                foreach (ACourse c in lc.getCourseList())
                {
                    foreach (Section s in c.getSections())
                    {
                        if (s.getSectionNum().Equals(i.ToString()))
                        {
                            selectedSections.Add(s);
                        }
                    }
                }
            }

            if (selectedSections.Count == 0)
            {
                MessageBox.Show("Please add at least one section.");
            }
            else
            {
                try
                {
                    foreach (Section s in getEnrolledSections())
                    {
                        lc.withdrawStudent(s, student);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (NullReferenceException nfe)
                {
                    MessageBox.Show("Student is not enrolled in course.");
                }
            }
        }
        */

        public List<Section> getEnrolledSections()
        {
            return selectedSections;
        }

        private void add_Click(object sender, EventArgs e)
        {
            var section = course_box.SelectedItem.ToString();
            if (!wCourse_box.Items.Contains(section))
            {
                wCourse_box.Items.Add(section);
            }
        }      
    }
}
