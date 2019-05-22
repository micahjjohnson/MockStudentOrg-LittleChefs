using System;
using System.Collections.Generic;

namespace LittleChefs
{
    public class Student : Person
    {
        private List<Parent> parents = new List<Parent>();
        private List<Person> emergencyContacts = new List<Person>();
        private List<Section> courseList = new List<Section>();
        private string imagePath;
        private Account account;

        public Student()
        {
        }

        public Student(string fn, string ln)
        {
            base.setFirstName(fn);
            base.setLastName(ln);
        }

        public Student(string fn, string ln, string year, string day, string month, string phone, string email)
        {
            firstName = fn;
            lastName = ln;
            dobb = new DateTime(int.Parse(year), int.Parse(day), int.Parse(month));
            this.phone = phone;
            this.email = email;
        }

        public void setStudentDetails(string fn, string ln, string year, string day, string month, string phone, string email)
        {
            int y = int.Parse(year);
            int d = int.Parse(day);
            int m = int.Parse(month);

            base.setFirstName(fn);
            base.setLastName(ln);
            base.setDOB(new DateTime(y, d, m));
            base.setPhone(phone);
            base.setEmail(email);
        }
        public void setUpAccount(Account x)
        {
            account = x;
        }
        public Account getStudentAccount()
        {
            return account;
        }
        public void setImagePath(string path)
        {
            imagePath = path;
        }

        public string getImagePath()
        {
            return imagePath;
        }

        public void enroll(Section s)
        {
            courseList.Add(s);
        }
        public List<Section> getCourseList()
        {
            return courseList;
        }
        public void addEmergContact(Person person)
        {
            emergencyContacts.Add(person);
        }
        public List<Person> getEmergContacts()
        {
            return emergencyContacts;
        }
        public void addParent(Parent parent)
        {
            parents.Add(parent);
        }
        public List<Parent> getParents()
        {
            return parents;
        }
        public Parent getParent(string name)
        {
            foreach (Parent p in parents)
            {
                if (p.getFullName().Equals(name))
                {
                    return p;
                }
            }
            return null;
        }
        public Person getEmergContact(string name)
        {
            foreach (Person p in emergencyContacts)
            {
                if (p.getFullName().Equals(name))
                {
                    return p;
                }
            }
            return null;
        }
        public void deleteParent(string name)
        {
            foreach (Parent p in parents)
            {
                if (p.getFullName().Equals(name))
                {
                    parents.Remove(p);
                }
            }
        }
        public void deleteEmergContact(string name)
        {
            foreach (Person p in emergencyContacts)
            {
                if (p.getFullName().Equals(name))
                {
                    emergencyContacts.Remove(p);
                }
            }
        }
        public void editParent(Parent oldParentInfo, Parent newParentInfo)
        {
            foreach (Parent p in parents)
            {
                if (p.Equals(oldParentInfo))
                {
                    oldParentInfo.setFirstName(newParentInfo.getFirstName());
                    oldParentInfo.setLastName(newParentInfo.getLastName());
                    oldParentInfo.setHomeAddress(newParentInfo.getHomeAddress().getLineOne(),
                        newParentInfo.getHomeAddress().getLineTwo(),
                        newParentInfo.getHomeAddress().getCity(),
                        newParentInfo.getHomeAddress().getState(),
                        newParentInfo.getHomeAddress().getZip());
                    oldParentInfo.setWorkAddress(newParentInfo.getWorkAddress().getLineOne(),
                        newParentInfo.getWorkAddress().getLineTwo(),
                        newParentInfo.getWorkAddress().getCity(),
                        newParentInfo.getWorkAddress().getState(),
                        newParentInfo.getWorkAddress().getZip());
                }
            }
        }

        public void editEmergContact(Person oldPerson, Person newPerson)
        {
            foreach (Person p in emergencyContacts)
            {
                if (p.Equals(oldPerson))
                {
                    oldPerson.setFirstName(newPerson.getFirstName());
                    oldPerson.setLastName(newPerson.getLastName());
                    oldPerson.setHomeAddress(newPerson.getHomeAddress().getLineOne(),
                        newPerson.getHomeAddress().getLineTwo(),
                        newPerson.getHomeAddress().getCity(),
                        newPerson.getHomeAddress().getState(),
                        newPerson.getHomeAddress().getZip());
                }
            }
        }
    }
}