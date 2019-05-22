using System;
using System.Collections.Generic;

namespace LittleChefs
{
    public class Bill : ReferenceObject
    {
        private Student student;
        private List<Item> billItems;
        private List<Payment> payments;
        private DateTime dateBillWasMade;
        private DateTime dateBillIsDue;
        private int billStatus; // 1 - in progress, 2 - paid in full, 3 - partial payment
        private bool closed;

        public Bill(Student s)
        {
            student = s;
            base.setBillReferenceNo();
            dateBillWasMade = DateTime.Now;
            billItems = new List<Item>();
            payments = new List<Payment>();
            dateBillIsDue = DateTime.Now.AddDays(26);
        }

        public void overrideDueDate(DateTime d) //manager action
        {
            dateBillIsDue = d;
        }

        public void addPaymentRef(Payment pay)
        {
            payments.Add(pay);
        }

        public void updateBillItems()
        {
            billItems.Clear();
            foreach (Section s in student.getCourseList())
            {
                billItems.Add(new Item(s));
            }
        }

        public List<Payment> getPaymentList()
        {
            return payments;
        }

        public decimal calculateBillSubtotal()
        {
            updateBillItems();
            decimal subtotal = 0;
            foreach (Item i in billItems)
            {
                subtotal += i.getSection().getPrice();
            }
            return Decimal.Round(subtotal, 2);
        }

        public decimal calculateBillTotal()
        {
            decimal tax = calculateBillSubtotal() * Resources.TAX;

            return Decimal.Round(calculateBillSubtotal() + tax, 2);
        }
       
        public decimal calculateBalance()
        {
            if (payments.Count > 0)
            {
                decimal totalPayments = 0;
                foreach (Payment p in payments)
                {
                    totalPayments += p.getAmount();
                }

                return Decimal.Round(calculateBillTotal() - totalPayments, 2);
            }
            else
            {
                return calculateBillTotal();
            }
        }
        
        public bool isLate()
        {
            if (DateTime.Now > dateBillIsDue)
            {
                return true;
            }
            else { return false; }
        }

        public void updateBillStatus(int newStatus)
        {
            billStatus = newStatus;

            if (billStatus == 2)
            {
                closed = true;
            }
        }

        public int getBillStatus()
        {
            return billStatus;
        }

        public bool isClosed()
        {
            return closed;
        }

        public DateTime getDueDate()
        {
            return dateBillIsDue;
        }
    }
}
 