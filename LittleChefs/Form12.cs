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
    public partial class Form12 : Form
    {
        private int counter;
        private ControllerStudent controller;

        public Form12()
        {
            InitializeComponent();
        }
        public Panel getStudentEntryListPanel()
        {
            return panel1;
        }
        public void loadEntries()
        {
            counter = 0;
            entries_listlView.Items.Clear();
            foreach (Student s in controller.getStudents())
            {
                ++counter;
                entries_listlView.Items.Add(new ListViewItem(new string[6]
                    {counter.ToString(), s.getFullName(), s.getId().ToString(), s.getEmail(), "true", "true"}));
            }
        }

        private void organizeByLastName()
        {

        }
    }
}
