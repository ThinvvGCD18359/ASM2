using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    public class Infor
    {
        public int StudentID;
        public string Name;
        public string Email;
        public string ClassID;

        public Infor(int studenID, string name, string email, string classID)
        {
            StudentID = studenID;
            Name = name;
            Email = email;
            ClassID = classID;
        }
        public void DisplayInfor()
        {
            Console.WriteLine("ID: {0} || Name: {1} || ClassID: {2}" +
                "\nEmail: {3}", StudentID, Name, ClassID, Email);
        }
    }
}
