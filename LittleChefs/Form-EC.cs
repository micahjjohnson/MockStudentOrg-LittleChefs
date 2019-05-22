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
    public partial class Form7 : Form
    {
        private Person person;
        private bool deleteMode;

        public Form7()
        {
            InitializeComponent();
        }
        public Form7(string title)
        {
            InitializeComponent();
            this.Text = title;
        }
        public Person getContactInfo()
        {
            return person;
        }
        public void setPerson(Person p)
        {
            this.person = p;
        }
        public void formIsEditMode(bool edit)
        {
            if (edit)
            {
                preFillForm();
                delete.Visible = true;
            }
            else
            {
                delete.Visible = false;
            }
        }
        public void isNotDeleteMode()
        {
            deleteMode = false;
        }
        public bool getDeleteMode()
        {
            return deleteMode;
        }
        private bool requiredFieldsAreEmpty()
        {
            return firstname.Text.Length == 0 ||
            lastname.Text.Length == 0 ||
            phone_one.Text.Length < 3 || 
            phone_two.Text.Length < 3 ||
            phone_three.Text.Length < 4 ||
            street.Text.Length == 0 ||
            city.Text.Length == 0 ||
            state.Text.Length == 0 ||
            zip.Text.Length == 0;
        }
        private void preFillForm()
        {
            firstname.Text = person.getFirstName();
            lastname.Text = person.getLastName();
            phone_one.Text = person.getPhone().Substring(0, 3);
            phone_two.Text = person.getPhone().Substring(3, 3);
            phone_three.Text = person.getPhone().Substring(6, 4); street.Text = person.getHomeAddress().getLineOne();
            room.Text = person.getHomeAddress().getLineTwo();
            city.Text = person.getHomeAddress().getCity();
            state.Text = person.getHomeAddress().getState();
            zip.Text = person.getHomeAddress().getZip();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteMode = true;
                this.DialogResult = DialogResult.OK;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (!requiredFieldsAreEmpty())
            {
                person.setFirstName(firstname.Text);
                person.setLastName(lastname.Text);
                person.setPhone(phone_one.Text + phone_two.Text + phone_three.Text);
                person.setHomeAddress(street.Text, room.Text, city.Text, state.Text, zip.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter all requirements.");
            }           
        }
    }
}
