using System;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Point thong = new Point(7);
            thong.AddMath(5.4);
            thong.AddLiterature(6);
            thong.AddEnglish(7);
            thong.AddBiological(2.5);
            thong.AddHistory(10);
            thong.AddGeography(5);
            thong.DisplayPoint();
            thong.Averages(4);
            Console.ReadKey();
            //test Add và  DetailInfor
            Infor cc = new Infor(4, "Dau Xuan Thong", "xuanthongdau@gmail.com", "GCD0702");
            Student cvc = new Student();
            cvc.AddInfor(4, "Dau Xuan Thong", "xuanthongdau@gmail.com", "GCD0702");
            cvc.AddPoint(4, 5.6, 5, 6, 7, 6.8, 4);
            cvc.DetailInfor(4);
            Console.ReadKey();
        }
    }
}
