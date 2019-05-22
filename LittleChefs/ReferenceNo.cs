namespace LittleChefs
{
    public class ReferenceNo
    {
        private int referenceNumber;
        private int referenceType;

        public ReferenceNo(int refer, int v)
        {
            this.referenceNumber = refer;
            referenceType = v;
        }

        public int getReferenceNumber()
        {
            return referenceNumber;
        }
        public int getReferenceType()
        {
            return referenceType;
        }
    }
}