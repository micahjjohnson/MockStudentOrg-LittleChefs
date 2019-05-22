using System;
using System.Text;

namespace LittleChefs
{
    public class Address
    {		
        protected AddressType type;
        protected string lineOne;
        protected string lineTwo;
        protected string city;
        protected string state;
        protected string zip;

        public string label()
        {
            StringBuilder addlabel = new StringBuilder();
            addlabel.Append(lineOne + "\n");

            if (lineTwo.Length != 0)
            {
                addlabel.Append(lineTwo + "\n");
            }

            addlabel.Append(city + ", ");
            addlabel.Append(state + " ");
            addlabel.Append(zip);
            return addlabel.ToString();
        }

        public void setAddressType(AddressType type)
        {
            this.type = type;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public void setLineOne(string lineOne)
        {
            this.lineOne = lineOne;
        }

        public void setLineTwo(string lineTwo)
        {
            this.lineTwo = lineTwo;
        }

        public void setState(string state)
        {
            this.state = state.Trim();
        }

        public void setZIP(string zip)
        { 
            this.zip = zip;
        }

        public string getLineOne()
        {
            return lineOne;
        }

        public string getLineTwo()
        {
            return lineTwo;
        }

        public string getCity()
        {
            return city;
        }

        public string getState()
        {
            return state;
        }

        public string getZip()
        {
            return zip;
        }
    }
}
