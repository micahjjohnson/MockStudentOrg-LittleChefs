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
    public partial class FormEnroll : Form
    {
        private Course selectedCourse;

        private List<Section> selectedSectionList = new List<Section>();
        private Student student;

        public FormEnroll()
        {
            InitializeComponent();
            name.Visible = false;
        }
        public FormEnroll(Student s)
        {
            InitializeComponent();
            student = s;

            name.Text = "Student: " + student.getFullName();
        }
        public List<Section> getEnrolledSections()
        {
            return selectedSectionList;
        }
        public Panel getEnrollPanel()
        {
            return panel1;
        }
        public void setStudent(Student selectedStudent)
        {
            student = selectedStudent;
            //MessageBox.Show("trying to set name...");
            name.Text = student.getFullName();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (selectedCourses.SelectedIndex != 0)
            {
                try
                {
                    selectedCourses.SelectedIndex = selectedCourses.SelectedIndex - 1;
                }
                catch
                {
                    selectedCourses.SelectedIndex = selectedCourses.SelectedIndex;
                }
            }
        }
        private void downButton_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCourses.SelectedIndex = selectedCourses.SelectedIndex + 1;
            }
            catch
            {
                selectedCourses.SelectedIndex = selectedCourses.SelectedIndex;
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                selectedCourses.Items.RemoveAt(selectedCourses.SelectedIndex);
            }
            catch { }
        }
        private void save_Click(object sender, EventArgs e)
        {
            foreach (var i in selectedCourses.Items)
            {
                foreach (Section s in Resources.littleChefs.ControlClass.getSectionList())
                {
                    if (s.getSectionCourse().getCourseName().Equals(i.ToString()))
                    {
                        selectedSectionList.Add(s);
                    }
                }
            }

            if (selectedCourses.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one section.");
            }
            else
            {
                try
                {
                    foreach (Section s in getEnrolledSections())
                    {
                        Resources.littleChefs.ControlStudent.enrollStudent(s, student);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch {}
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                var section = search_results.SelectedItem.ToString();
                if (!selectedCourses.Items.Contains(section))
                {
                    selectedCourses.Items.Add(section);
                }
            }
            catch (NullReferenceException) { }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            search_entry.Clear();
            search_results.Items.Clear();
        }
        private void student_schedule_Click(object sender, EventArgs e)
        {
            //var scheduleForm = new Form12();
            //scheduleForm.ShowDialog();
        }
        private void search_Click(object sender, EventArgs e)
        {
            search_results.Items.Clear();
            var searchResults = new Search();
            searchResults.SearchThroughSectionNames(Resources.littleChefs.ControlClass.getSectionList(), search_entry.Text);
            //MessageBox.Show(searchResults.getSectionSearchResults().Count.ToString());
            foreach (Section sec in searchResults.getSectionSearchResults())
            {
                search_results.Items.Add(sec.getSectionCourse().getCourseName());
            }
        }
    }
}