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
    public partial class FormBilling : Form
    {
        private Student student;
        private Bill bill;
        private LC lc;

        public FormBilling()
        {
            InitializeComponent();
            lc = Resources.littleChefs;
        }
        public Panel getBillingPanel()
        {
            return billingPanel;
        }
        public void changeBillView()
        {
            //bill = ;
        }
        public void fillInformation(Student s)
        {
            this.student = s;
            bill = student.getStudentAccount().getInvoiceList()[0];
            idLabel.Text = student.getId().ToString();
            name.Text = student.getFullName();
            street.Text = student.getStudentAccount().getBillingAddress().getLineOne();
            line2.Text = student.getStudentAccount().getBillingAddress().getLineTwo();
            city.Text = student.getStudentAccount().getBillingAddress().getCity();
            state.SelectedItem = student.getStudentAccount().getBillingAddress().getState();
            zip.Text = student.getStudentAccount().getBillingAddress().getZip();
            phone.Text = student.getPhone();
            notes_TB.Text = student.getStudentAccount().getNotes();
            S_Address.Text = student.addressLabel();

            foreach (Bill b in student.getStudentAccount().getInvoiceList())
            {
                billList.Items.Add(b.getDueDate().ToShortDateString());
            }
            updateMoneyFields();
        }


        private void updateMoneyFields()
        {
            sub.Text = "$ " + bill.calculateBillSubtotal();
            total.Text = "$ " + bill.calculateBillTotal();
            due.Text = "$ " + bill.calculateBalance();
        }
        private void updateBilInformation()
        {
            List<Payment> studentBillPaymentList = bill.getPaymentList();
            details.Items.Clear();
            foreach (Payment p in studentBillPaymentList)
            {
                details.Items.Add(new ListViewItem(new string[5] {p.getSubmittedDate().ToShortDateString(),
                    p.getPostDate().ToShortDateString(), "$" + p.getAmount().ToString(), "<PAY METHOD>",
                    p.getEmployee().getId().ToString() }));
            }
        }
        private void saveNotes_Click(object sender, EventArgs e)
        {
            student.getStudentAccount().editNotes(notes_TB.Text);
            this.DialogResult = DialogResult.OK;
        }
        private void new_payment_Click(object sender, EventArgs e)
        {
            FormPayment form9 = new FormPayment(student);
            form9.ShowDialog();
        }
        private void billList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Bill b in student.getStudentAccount().getInvoiceList())
            {
                if (b.getDueDate().ToShortDateString().Equals(billList.SelectedItem.ToString()))
                {
                    //ask if sure to reload reload application
                }
            }
        }
    }
}
