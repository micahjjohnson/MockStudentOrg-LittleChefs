using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleChefs
{
    public class Search
    {
        private List<Student> studentResults = new List<Student>();
        private List<Section> sectionResults = new List<Section>();
        private Course courseResults;

        public Search(List<Student> students, string query)
        {
            foreach (Student s in students)
            {
                if (s.getFName().ToLower().Contains(query.ToLower()))
                {
                    studentResults.Add(s);
                }
            }
        }

        public Search(List<Section> section, string query)
        {
            // search sections for section number
            foreach (Section s in section)
            {
                if (s.getSectionNum().Contains(query))
                {
                    sectionResults.Add(s);
                }
            }
        }

        public void SearchThroughSectionNames(List<Section> section, string query)
        {
            // search sections for course name
            sectionResults.Clear();
            foreach (Section s in section)
            {
                if (s.getSectionCourse().getCourseName().ToLower().Contains(query.ToLower()))
                {
                    sectionResults.Add(s);
                }
            }
        }

        public Search(List<Course> course, string query)
        {
            foreach (Course c in course)
            {
                if (c.getCourseName().Contains(query))
                {
                    courseResults = c;
                }
            }
        }

        public Search()
        {
        }

        public Course getCourseSearchResults()
        {
            return courseResults;
        }

        public List<Student> getSearchResults()
        {
            studentResults.Sort((x, y) => string.Compare(x.getLastName(), y.getLastName()));
            return studentResults;
        }

        public List<Section> getSectionSearchResults()
        {
            return sectionResults;
        }
    }
}
