using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleChefs
{
    public class Payment : ReferenceObject
    {
        private DateTime submitted;
        private DateTime postDate;
        private decimal amount;
        private int paymentNo;
        private int method;
        private string notes;
        private Employee employee;

        public Payment(DateTime post, decimal total, Bill billRef, Employee e, int m)
        {
            base.setPaymentReferenceNo();
            submitted = DateTime.Now;
            amount = total;
            postDate = post;
            billRef.addPaymentRef(this);
            method = m;
            employee = e;
        }

        public decimal getAmount()
        {
            return amount;
        }

        public DateTime getSubmittedDate()
        {
            return submitted;
        }

        public DateTime getPostDate()
        {
            return postDate;
        }

        public int getPaymentNo()
        {
            return paymentNo;
        }

        public Employee getEmployee()
        {
            return employee;
        }

        public void editNotes(string x)
        {
            notes = x;
        }

        public string getNotes()
        {
            return notes;
        }
    }
}
