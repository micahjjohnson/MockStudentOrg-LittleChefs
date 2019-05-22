using System;
using System.Globalization;
using System.Text;

namespace LittleChefs
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected string phone;
        protected string email;
        protected long id;
        protected Address homeAddress;
        protected DateTime dobb;
        protected string gender;
        protected int relationship;

        public string addressLabel()
        {
            StringBuilder addLabel = new StringBuilder();
            addLabel.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstName) + " ");
            addLabel.Append(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastName) + "\n");
            addLabel.Append(homeAddress.label());
            return addLabel.ToString();
        }

        internal void setHomeAddress(Address address)
        {
            homeAddress = address;
        }

        internal Address getHomeAddress()
        {
            return homeAddress;
        }

        public string getDOB()
        {
            return dobb.ToShortDateString();
        }

        public DateTime getDateObjectDOB()
        {
            return dobb;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getFName()
        {
            return firstName + " " + lastName;
        }

        public string getFullName()
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstName + " " + lastName);
            //return firstName.First().ToString().ToUpper() + " " + lastName.First().ToString().ToUpper();
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getPhoneNumsOnly()
        {
            return phone;
        }

        public int getRelationship()
        {
            return relationship;
        }

        public string getPhone()
        {
            return phone;
        }

        public string getFormattedPhone()
        {
            return String.Format("{0:(###) ###-####}", double.Parse(phone));
        }

        public void setDOB(DateTime dt)
        {
            this.dobb = dt;       
        }

        public void setFirstName(string fn)
        {
            this.firstName = fn.Trim();
        }

        public void setRelationship(int v)
        {
            relationship = v;
        }

        public void setGender(int g)
        {
            switch (g)
            {
                case 1: gender = "M";
                    break;
                case 2: gender = "F";
                    break;
            }
        }

        public void setHomeAddress(string lineOne, string lineTwo, string city, string state, string zip)
        {
            homeAddress = new Address();
            homeAddress.setLineOne(lineOne);
            homeAddress.setLineTwo(lineTwo);
            homeAddress.setCity(city);
            homeAddress.setState(state);
            homeAddress.setZIP(zip);
        }

        public void setLastName(string ln)
        {
            this.lastName = ln.Trim();
        }

        public void setPhone(string phone)
        {
            this.phone = phone.Trim();
        }

        public void setId(long id)
        {
            this.id = id;
        }

        public long getId()
        {
            return id;
        }

        public void setEmail(string email)
        {
            this.email = email.Trim();
        }

        public string getEmail()
        {
            return email;
        }
    }
}
