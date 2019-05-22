namespace LittleChefs
{
    public class Parent : Person
    {
        private Address workAddress;

        public Parent()
        {
        }

        public Parent(string fn, string ln)
        {
            base.setFirstName(fn);
            base.setLastName(ln);
        }

        public void setWorkAddress(string lineOne, string lineTwo, string city, string state, string zip)
        {
            workAddress = new Address();
            workAddress.setAddressType(AddressType.WORK);
            workAddress.setLineOne(lineOne);
            workAddress.setLineTwo(lineTwo);
            workAddress.setCity(city);
            workAddress.setState(state);
            workAddress.setZIP(zip);
        }

        internal Address getWorkAddress()
        {
            return workAddress;
        }
    }
}
