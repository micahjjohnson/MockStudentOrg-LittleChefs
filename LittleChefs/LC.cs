using System;
using System.Collections.Generic;
using System.IO;

namespace LittleChefs
{
    public class LC
    {
        private List<Login.Account> loginAccounts;
        private readonly static string directory = @"C:\Users\johnsonmi\Documents\Visual Studio 2015\Projects\LittleChefs\data\Students\Student Information\";
        private int saveCounter;
        private ControllerClass controlClass;
        private ControllerEmployee controlEmployee;
        private ControllerStudent controlStudent;

        public LC()
        {
            controlClass = new ControllerClass();
            controlEmployee = new ControllerEmployee();
            controlStudent = new ControllerStudent();

            // lists
            loginAccounts = new List<Login.Account>();

            /*//login data
            var loginOne = new Login.Account("mike", "111");
            var loginTwo = new Login.Account("john", "123");
            loginAccounts.Add(loginOne);
            loginAccounts.Add(loginTwo);
            */
            loadLoginData();
            //MessageBox.Show(loginAccounts[0].getPassword());

            //courses

            loadStudentData();
        }

        public ControllerClass ControlClass
        {
            get
            {
                return controlClass;
            }
        }

        public ControllerEmployee ControlEmployee
        {
            get
            {
                return controlEmployee;
            }
        }

        public ControllerStudent ControlStudent
        {
            get
            {
                return controlStudent;
            }
        }

        public List<Login.Account> getAccountList()
        {
            return loginAccounts;
        }

        private void loadLoginData()
        {
            //try
            //{
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\johnsonmi\Documents\Visual Studio 2015\Projects\LittleChefs\data\Students\login.txt");
            while ((line = file.ReadLine()) != null)
            {
                var s = new Student();
                string[] loginDetails = line.Split(',');
                loginAccounts.Add(new Login.Account(loginDetails[0], loginDetails[1]));
                //loginAccounts.Add(new Login.Account(loginDetails[2], loginDetails[3]));

                //MessageBox.Show(string.Join(",", loginDetails.ToArray()));
            }
            file.Close();
            //}
            //catch { }
        }

        private void loadStudentData()
        {
            var sectionOne = new Section("Sec Name", "1234", 5.99m);

            string[] fileEntries = Directory.GetFiles(directory);

            foreach (string st in fileEntries)
            {
                try
                {
                    string line;
                    System.IO.StreamReader file = new System.IO.StreamReader(st);
                    while ((line = file.ReadLine()) != null)
                    {
                        var s = new Student();
                        string[] studentDetails = line.Split(',');
                        s.setStudentDetails(studentDetails[0], studentDetails[1], studentDetails[2],
                            studentDetails[3], studentDetails[4], studentDetails[5], studentDetails[6]);
                        s.setHomeAddress(studentDetails[7], studentDetails[8], studentDetails[9],
                            studentDetails[10], studentDetails[11]);
                        s.setImagePath(studentDetails[12]);
                        s.addParent(new Parent(studentDetails[13], studentDetails[14]));
                        s.getParents()[0].setPhone(studentDetails[15]);
                        s.getParents()[0].setEmail(studentDetails[16]);
                        s.getParents()[0].setWorkAddress(studentDetails[17], studentDetails[18], studentDetails[19],
                            studentDetails[20], studentDetails[21]);
                        ControlStudent.newStudent(s);
                        ControlStudent.enrollStudent(sectionOne, s);
                        //MessageBox.Show(string.Join(",", studentDetails.ToArray()));
                    }
                    file.Close();
                }
                catch { }
            }
        }

        public void saveStudentToFile(Student student)
        {
            string studentData = student.getFirstName() + ","
                + student.getLastName() + ","
                + student.getDateObjectDOB().Year.ToString() + ","
                + student.getDateObjectDOB().Month.ToString() + ","
                + student.getDateObjectDOB().Day.ToString() + ","
                + student.getPhone() + ","
                + student.getEmail() + ","
                + student.getHomeAddress().getLineOne() + ","
                + student.getHomeAddress().getLineTwo() + ","
                + student.getHomeAddress().getCity() + ","
                + student.getHomeAddress().getState() + ","
                + student.getHomeAddress().getZip() + ","
                + student.getImagePath() + ","
                + student.getParents()[0].getFirstName() + ","
                + student.getParents()[0].getLastName() + ","
                + student.getParents()[0].getPhone() + ","
                + student.getParents()[0].getEmail() + ","
                + student.getParents()[0].getWorkAddress().getLineOne() + ","
                + student.getParents()[0].getWorkAddress().getLineTwo() + ","
                + student.getParents()[0].getWorkAddress().getCity() + ","
                + student.getParents()[0].getWorkAddress().getState() + ","
                + student.getParents()[0].getWorkAddress().getZip();

            // Write the string to a file.
            string saveAs = directory + "file" + saveCounter + ".txt";
            System.IO.StreamWriter file = new System.IO.StreamWriter(saveAs);
            file.WriteLine(studentData);
            file.Close();
        }
    }
}