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
    public partial class FormStudent : Form
    {
        private List<string> errors = new List<string>();
        private List<Parent> parentList = new List<Parent>();
        private readonly static int PARENT_ONE = 0;
        private readonly static int PARENT_TWO = 1;

        private Student student;
        private int emergencyCounter;
        private LC lc;

        public FormStudent()
        {
            InitializeComponent();
            lc = Resources.littleChefs;
            student = new Student();
            parentList.Add(new Parent());
            parentList.Add(new Parent());
        }
        public Panel getPanel()
        {
            return panel1;
        }
        public Student getStudent()
        {
            return student;
        }
        public void prefillForm(Student s)
        {
            try
            {
                this.student = s;
                //fill student
                student_fn.Text = student.getFirstName();
                student_ln.Text = student.getLastName();
                email.Text = student.getEmail();
                //dateTimePicker.Value = student.getDOB();
                student_phone_one.Text = student.getPhone().Substring(0, 3);
                student_phone_two.Text = student.getPhone().Substring(3, 3);
                student_phone_three.Text = student.getPhone().Substring(6, 4);
                street.Text = student.getHomeAddress().getLineOne();
                apt.Text = student.getHomeAddress().getLineTwo();
                city.Text = student.getHomeAddress().getCity();
                state.Text = student.getHomeAddress().getState();
                zip.Text = student.getHomeAddress().getZip();
                pictureBox1.Image = new Bitmap(student.getImagePath());

                parent_fn.Text = student.getParents()[0].getFirstName();
                parent_ln.Text = student.getParents()[0].getLastName();
                p_email.Text = student.getParents()[0].getEmail();
                parent_phone_one.Text = student.getParents()[0].getPhone().Substring(0, 3);
                parent_phone_two.Text = student.getParents()[0].getPhone().Substring(3, 3);
                parent_phone_three.Text = student.getParents()[0].getPhone().Substring(6, 4);
                parent_work_street.Text = student.getParents()[0].getWorkAddress().getLineOne();
                parent_work_room.Text = student.getParents()[0].getWorkAddress().getLineTwo();
                parent_work_city.Text = student.getParents()[0].getWorkAddress().getCity();
                parent_work_state.Text = student.getParents()[0].getWorkAddress().getState();
                parent_work_zip.Text = student.getParents()[0].getWorkAddress().getZip();
            }
            catch { }
        }
        private bool requiredFieldsAreEmpty()
        {
            return (student_fn.Text.Length == 0 || student_ln.Text.Length == 0
               || student_phone_one.Text.Length < 3 || student_phone_two.Text.Length < 3
               || student_phone_three.Text.Length < 4 || street.Text.Length == 0
               || city.Text.Length == 0 || state.Text.Length == 0
               || zip.Text.Length == 0);
        }
        private bool requiredParentFieldsAreEmpty()
        {
            return (parent_fn.Text.Length == 0 || parent_ln.Text.Length == 0
               || parent_phone_one.Text.Length < 3 || parent_phone_two.Text.Length < 3
               || parent_phone_three.Text.Length < 4 || parent_work_street.Text.Length == 0
               || parent_work_city.Text.Length == 0 || parent_work_state.Text.Length == 0
               || parent_work_zip.Text.Length == 0);
        }
        private void updateParentPanel()
        {
            parent2.Text = parentList[PARENT_TWO].getFullName();
        }
        private void addParent_Click(object sender, EventArgs e)
        {
            var form3 = new FormParent();
            form3.setParent(new Parent());
            form3.ShowDialog();
            if (form3.DialogResult != DialogResult.Cancel)
            {
                try
                {
                    parent2Panel.Visible = true;
                    addParent.Enabled = false;
                    parentList[PARENT_TWO] = form3.getParentInfo();
                    updateParentPanel();
                }
                catch { }
            }
        }
        private void editParent_Click(object sender, EventArgs e)
        {
            var form3 = new FormParent("Edit Parent");
            form3.setParent(parentList[PARENT_TWO]);
            form3.formIsEditMode(true);
            form3.ShowDialog();

            if (form3.DialogResult != DialogResult.Cancel)
            {
                if (form3.getDeleteMode())
                {
                    form3.isNotDeleteMode();
                    parent2Panel.Visible = false;
                    addParent.Enabled = true;
                }
                else
                {
                    parentList[PARENT_TWO] = form3.getParentInfo();
                    this.DialogResult = DialogResult.OK;
                }
                form3.formIsEditMode(false);
            }
            updateParentPanel();
        }
        private void updateEmergencyListBox()
        {
            emerContact_listbox.Items.Clear();
            foreach (Person p in student.getEmergContacts())
            {
                emerContact_listbox.Items.Add(p.getFullName());
            }
        }
        private void addEmerCont_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.setPerson(new Person());
            form7.ShowDialog();
            if (form7.DialogResult != DialogResult.Cancel)
            {
                student.addEmergContact(form7.getContactInfo());
                updateEmergencyListBox();
                ++emergencyCounter;
            }
        }
        private void emerContact_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Person person = student.getEmergContact(emerContact_listbox.SelectedItem.ToString());
                var form7 = new Form7("Edit Emergency Contact");
                form7.setPerson(person);
                form7.formIsEditMode(true);
                form7.ShowDialog();

                if (form7.getDeleteMode())
                {
                    student.deleteEmergContact(form7.getContactInfo().getFullName());
                    --emergencyCounter;
                    form7.isNotDeleteMode();
                }
                else
                {
                    student.editEmergContact(person, form7.getContactInfo());
                }

                emerContact_listbox.ClearSelected();
            }
            catch { }

            updateEmergencyListBox();
        }

        private void save_Click(object sender, EventArgs e)
        {
                if (requiredFieldsAreEmpty())
                {
                    errors.Add("Please enter all student information.");
                    // highlight required fields
                }
            if (requiredParentFieldsAreEmpty())
            {
                errors.Add("Please enter parent information.");
                // highlight required fields
            }
            else
            {
                // create new parent
                parentList[PARENT_ONE].setFirstName(parent_fn.Text);
                parentList[PARENT_ONE].setLastName(parent_ln.Text);
                parentList[PARENT_ONE].setEmail(p_email.Text);
                parentList[PARENT_ONE].setPhone(parent_phone_one.Text + parent_phone_two.Text + parent_phone_three.Text);
                parentList[PARENT_ONE].setWorkAddress(parent_work_street.Text, parent_work_room.Text,
                    parent_work_city.Text, parent_work_state.Text, parent_work_zip.Text);
                //create student
                student.setFirstName(student_fn.Text);
                student.setLastName(student_ln.Text);
                student.setDOB(dateTimePicker.Value.Date);
                student.setPhone(student_phone_one.Text + student_phone_two.Text + student_phone_three.Text);
                student.setEmail(email.Text);
                student.setHomeAddress(street.Text, apt.Text, city.Text, state.Text, zip.Text);
                student.addParent(parentList[PARENT_ONE]);
                student.addParent(parentList[PARENT_TWO]);
                student.getStudentAccount().updateBillingAddress(student.getHomeAddress());

                if (male_rb.Checked)
                {
                    student.setGender(1);
                }
                if (female_rb.Checked)
                {
                    student.setGender(2);
                }
                this.DialogResult = DialogResult.OK;
            }
            if (errors.Count > 0)
            {
                MessageBox.Show(string.Join("\n", errors.ToArray()));
                errors.Clear();
            }
        }

        private void upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box
                pictureBox1.Image = new Bitmap(open.FileName);
                student.setImagePath(open.FileName);
            }
        }

        private void delete_photo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pictureBox1.Image = null;
                student.setImagePath(null);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}