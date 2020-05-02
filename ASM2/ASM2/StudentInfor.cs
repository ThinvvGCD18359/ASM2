using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class StudentInfor
    {
        public int StudentID;
        public string Name;
        public string Email;
        public string ClassID;

        public StudentInfor(int studentID, string name, string email, string classID)
        {
            StudentID = studentID;
            Name = name;
            Email = email;
            ClassID = classID;
        }
        public void ShowInfor()
        {
            Console.WriteLine("ID: {0} || Name: {1} || ClassID: {2}" +
                "\nEmail: {3}", StudentID, Name, ClassID, Email);
        }
    }
}
