using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleChefs
{
    public class ControllerStudent
    {
        private List<Student> students;

        public ControllerStudent()
        {
            students = new List<Student>();
        }

        public void editStudent(Student student) { }

        public void enrollStudent(Section section, Student student)
        {
            if (!section.getRoster().Contains(student))
            {
                section.addStudent(student);
                student.enroll(section);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public List<Student> getStudents()
        {
            return students;
        }

        public void newStudent(Student student)
        {
            if (!students.Contains(student))
            {
                students.Add(student);
                student.setId(Resources.getNextIdValue());
                Resources.littleChefs.saveStudentToFile(student);
                Account account = new Account(student);
            }
        }
 
        public void withdrawStudent(Section section, Student student)
        {
            if (section.getRoster().Contains(student))
            {
                section.removeStudent(student);
                student.getCourseList().Remove(section);
            }
            else
            {
                throw new NullReferenceException();
            }
        }       
    }
}
