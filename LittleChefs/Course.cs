using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleChefs
{
    public class Course
    {
        private List<Section> sections = new List<Section>();
        private string name;
        private string description;

        public Course(string v)
        {
            name = v;
        }
        public void addSection(Section section)
        {
            sections.Add(section);
        }
        public string getCourseName()
        {
            return name;
        }
        public void setDescription(string descrip)
        {
            description = descrip;
        }
        public string getDescription()
        {
            return description;
        }
        public List<Section> getSections()
        {
            return sections;
        }
    }
}