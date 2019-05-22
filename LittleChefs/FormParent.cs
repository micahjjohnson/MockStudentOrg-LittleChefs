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
    public partial class FormParent : Form
    {
        private Parent parent;
        private bool deleteMode;

        public FormParent(string title)
        {
            InitializeComponent();
            this.Text = title;
        }
        public FormParent()
        {
            InitializeComponent();
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

        public Parent getParentInfo()
        {
            return parent;
        }

        public void setParent(Parent p)
        {
            this.parent = p;
        }

        public bool getDeleteMode()
        {
            return deleteMode;
        }
        public bool requiredParentFieldsAreEmpty()
        {
            return (parent_fn.Text.Length == 0 || parent_ln.Text.Length == 0
               || parent_phone_one.Text.Length < 3 || parent_phone_two.Text.Length < 3
               || parent_phone_three.Text.Length < 4 || parent_work_street.Text.Length == 0
               || parent_work_city.Text.Length == 0 || parent_work_state.Text.Length == 0
               || parent_work_zip.Text.Length == 0 || email.Text.Length == 0);
        }
        private void preFillForm()
        {
            parent_fn.Text = parent.getFirstName();
            parent_ln.Text = parent.getLastName();
            email.Text = parent.getEmail();
            parent_phone_one.Text = parent.getPhone().Substring(0, 3);
            parent_phone_two.Text = parent.getPhone().Substring(3, 3);
            parent_phone_three.Text = parent.getPhone().Substring(6, 4);
            parent_work_street.Text = parent.getWorkAddress().getLineOne();
            parent_work_room.Text = parent.getWorkAddress().getLineTwo();
            parent_work_city.Text = parent.getWorkAddress().getCity();
            parent_work_state.Text = parent.getWorkAddress().getState();
            parent_work_zip.Text = parent.getWorkAddress().getZip();
            if (parent.getRelationship() == 0)
            {
                mother_rb.Checked = true;
            }
            if (parent.getRelationship() == 1)
            {
                father_rb.Checked = true;
            }
            if (parent.getRelationship() == 2)
            {
                guardian_rb.Checked = true;
            }
        }
        /*-------------------CLICKS-------------------*/
        private void save_Click(object sender, EventArgs e)
        {
            if (!requiredParentFieldsAreEmpty())
            {
                parent.setFirstName(parent_fn.Text);
                parent.setLastName(parent_ln.Text);
                parent.setEmail(email.Text);
                parent.setPhone(parent_phone_one.Text + parent_phone_two.Text + parent_phone_three.Text);
                parent.setWorkAddress(parent_work_street.Text, parent_work_room.Text, parent_work_city.Text, parent_work_state.Text, parent_work_zip.Text);
                if (mother_rb.Checked)
                {
                    parent.setRelationship(0);
                }
                if (father_rb.Checked)
                {
                    parent.setRelationship(1);
                }
                if (guardian_rb.Checked)
                {
                    parent.setRelationship(2);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please enter all requirements.");
            }             
        }
        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteMode = true;
                this.DialogResult = DialogResult.OK;
            }
        }       
    }
}
