using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleChefs
{
    public class ControllerClass
    {
        private List<Course> courses;
        private List<Section> sections;

        public ControllerClass()
        {
            courses = new List<Course>();
            sections = new List<Section>();

            var courseOne = new Course("Baking");
            var courseTwo = new Course("Cookies");
            var courseThree = new Course("Pizza");
            createCourse(courseOne);
            createCourse(courseTwo);
            createCourse(courseThree);

            //sections
            var sectionOne = new Section("Sec Name", "1234", 5.99m);
            var sectionTwo = new Section("Sec Name", "12345", 5.99m);
            var sectionThree = new Section("Sec Name", "123456", 5.99m);
            createSection(sectionOne, courseOne);
            createSection(sectionTwo, courseOne);
            createSection(sectionThree, courseOne);
        }

        public void assignInstructor(Employee employee, Section s) { }

        public void createCourse(Course c)
        {
            courses.Add(c);
        }

        public void createSection(Section s, Course c)
        {
            s.addCourse(c);
            sections.Add(s);
        }

        public void deleteSection(Section s)
        {
            sections.Remove(s);
        }

        public List<Course> getCourseList()
        {
            return courses;
        }

        public List<Section> getSectionList()
        {
            return sections;
        }
    }
}
