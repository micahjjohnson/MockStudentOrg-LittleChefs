namespace LittleChefs
{
    public class ReferenceObject
    {
        private ReferenceNo referenceNo;

        public void setBillReferenceNo()
        {
            referenceNo = new ReferenceNo(Resources.refrenceNumber, 1);
        }

        public void setPaymentReferenceNo()
        {
            referenceNo = new ReferenceNo(Resources.refrenceNumber, 2);
        }

        public ReferenceNo getReferenceObject()
        {
            return referenceNo;
        }
    }
}