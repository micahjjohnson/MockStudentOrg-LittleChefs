using System;
using System.Collections.Generic;
using System.Text;

namespace LittleChefs
{
    public class Section
    {
        private Course sectionCourse;
        private List<Student> roster;
        private string sectionNum;
        private List<string> freq_days;
        private DateTime startDate;
        private DateTime endDate;
        private string startTime;
        private string endTime;
        private string sectionName;
        private decimal price;

        public Section(string name, string num, decimal p)
        {
            sectionName = name;
            sectionNum = num;
            price = p;
            roster = new List<Student>();
        }
        public string getSectionName()
        {
            return sectionName;
        }
        public void setFreqDayList(List<string> list)
        {
            freq_days = list;
        }
        public List<string> getFreqDayList()
        {
            return freq_days;
        }
        public void addCourse(Course course)
        {
            sectionCourse = course;
            course.addSection(this);
        }
        public Course getSectionCourse()
        {
            return sectionCourse;
        }
        public void addStudent(Student student)
        {
            roster.Add(student);
        }
        public void removeStudent(Student student)
        {
            roster.Remove(student);
        }
        public void setStartDate(DateTime date)
        {
            startDate = date;
        }
        public void setEndDate(DateTime date)
        {
            endDate = date;
        }
        public DateTime getStartDate()
        {
            return startDate;
        }
        public DateTime getEndDate()
        {
            return endDate;
        }

        public void setStartTime(int hours, int minutes) { }
        public void setEndTime(int hours, int minutes) { }

        public void editPrice(decimal price)
        {
            this.price = price;
        }
        public decimal getPrice()
        {
            return price;
        }
        public string getSectionNum()
        {
            return sectionNum;
        }
        public List<Student> getRoster()
        {
            return roster;
        } 
        public string getLongLabel()
        {
            return
                "Name:\t" + sectionName +
                "\nStart Date:\t" + startDate.ToShortDateString() +
                "\nEnd Date:\t" + endDate.ToShortDateString() +
                "\nStart Time:\t" + "\n" +
                "End Time:\t" + "\n" +
                "Frequency:\t" + "\n" +
                "Price:\t $" + price;
        }  
    }
}