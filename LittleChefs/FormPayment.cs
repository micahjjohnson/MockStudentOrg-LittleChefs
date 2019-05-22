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
    public partial class FormPayment : Form
    {
        private Student student;
        private LC lc;

        public FormPayment()
        {
            InitializeComponent();
        }
        public FormPayment(Student student)
        {
            InitializeComponent();
            this.student = student;
            dateTimePicker1.Value = DateTime.Now;
            lc = Resources.littleChefs;

            studentName.Text = student.getFullName();
        }
        private void save_Click(object sender, EventArgs e)
        {
            /*APayment payment = new RPayment();
            payment.setDate(dateTimePicker1.Value.Date);
            payment.setAmount(double.Parse(amount.Text));
            student.getStudentAccount().newPayment(payment);
            */

            Payment pay = new Payment(dateTimePicker1.Value.Date, decimal.Parse(amount.Text), new Bill(student), new Employee(), 0);
            this.DialogResult = DialogResult.OK;
        }
        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Button b = sender as Button;
            panel2.BringToFront();

            if (b == cash_bt)
            {
                cash_gb.Location = panel2.Location;
                cash_gb.Size = panel2.Size;
                cash_gb.Visible = true;
                cash_gb.BringToFront();
            }
            if (b == card_bt)
            {
                card_gb.Location = panel2.Location;
                card_gb.Size = panel2.Size;
                card_gb.Visible = true;
                card_gb.BringToFront();
            }
            if (b == check_bt)
            {
                check_gb.Location = panel2.Location;
                check_gb.Size = panel2.Size;
                check_gb.Visible = true;
                check_gb.BringToFront();
            }
            if (b == moneyorder_bt)
            {
                moneyorder_gb.Location = panel2.Location;
                moneyorder_gb.Size = panel2.Size;
                moneyorder_gb.Visible = true;
                moneyorder_gb.BringToFront();
            }           
        }
    }
}
