using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Students
    {
        public List<StudentInfor> StudentInfors;
        public List<Grade> Grades;
        public Students()
        {
            StudentInfors = new List<StudentInfor>();
            Grades = new List<Grade>();
        }
        //in thong tin chi tiet cua hoc sinh 
        public void AddInfor(int studentID, string name, string email, string classID)
        {
            StudentInfors.Add(new StudentInfor(studentID, name, email, classID));
        }
        public void AddGrades(int gradesID, double maths, double literature, double english, double biological, double history, double geography)
        {
            Grades.Add(new Grade(gradesID, maths, literature, english, biological, history, geography));
        }
        public void DetailInfor(int id)
        {
            StudentInfor ResultInfor = null;
            Grade ResultGrades = null;
            ResultInfor = StudentInfors.SingleOrDefault(x => x.StudentID == id);
            {
                if(ResultInfor == null)
                {
                    Console.WriteLine("Error!!! No matching student found");
                }
                else
                {
                    ResultInfor.ShowInfor();
                    ResultGrades = Grades.SingleOrDefault(x => x.GradeID == id);
                    {
                        if (ResultGrades == null)
                        {
                            Console.WriteLine("Error!!! No transcript matching student ID found");
                        }
                        else
                        {
                            ResultGrades.ShowGrades();
                        }
                    }
                }
            }
        }
    }
}
