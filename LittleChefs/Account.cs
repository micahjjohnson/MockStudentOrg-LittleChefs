using System.Collections.Generic;

namespace LittleChefs
{
    public class Account
    {
        private Student student;
        private Address billingAddress;
        private List<Bill> invoices;
        private string notes;

        public Account(Student s)
        {
            student = s;
            student.setUpAccount(this);
            billingAddress = student.getHomeAddress();
            invoices = new List<Bill>();
            createNewBill();
        }

        private void createNewBill()
        {
            var bill = new Bill(student);
            invoices.Insert(0, bill);
        }

        public List<Bill> getInvoiceList()
        {
            return invoices;
        }

        public void updateBillingAddress(Address a)
        {
            billingAddress = a;
        }

        public Address getBillingAddress()
        {
            return billingAddress;
        }

        public string getNotes()
        {
            return notes;
        }

        public void editNotes(string newNote)
        {
            notes = newNote;
        }
    }
}
