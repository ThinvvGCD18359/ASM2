using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManager
{
    public class Student
    {
        public List<Infor> Infors;
        public List<Point> Points;
        public Student()
        {
            Infors = new List<Infor>();
            Points = new List<Point>();
        }
        //in thong tin chi tiet cua hoc sinh 
        public void AddInfor(int studenID, string name, string email, string classID)
        {
            Infors.Add(new Infor(studenID, name, email, classID));
        }
        public void AddPoint(int pointID, double maths, double literature, double english, double biological, double history, double geography)
        {

            Points.Add(new Point(pointID, maths, literature, english, biological, history, geography));
        }

        public void DetailInfor(int id)
        {
            Infor ResultInfor = null;
            Point ResultPoint = null;
            ResultInfor = Infors.SingleOrDefault(x => x.StudentID == id);
            {
                if(ResultInfor == null)
                {
                    Console.WriteLine("Error!!! No matching student found");
                }
                else
                {
                    ResultInfor.DisplayInfor();
                    ResultPoint = Points.SingleOrDefault(x => x.PointID == id);
                    {
                        if (ResultPoint == null)
                        {
                            Console.WriteLine("Error!!! No transcript matching student ID found");
                        }
                        else
                        {
                            ResultPoint.DisplayPoint();
                        }
                    }
                }
            }
        }
    }
}
