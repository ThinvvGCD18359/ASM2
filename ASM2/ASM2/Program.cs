using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfor cc = new StudentInfor(7, "Vo Van Thin", "thinvvgcd18359@fpt.edu.vn", "GCD0702");
            Students vvt = new Students();
            vvt.AddInfor(7, "Vo Van Thin", "thinvvgcd18359@fpt.edu.vn", "GCD0702");
            vvt.AddGrades(7, 5.6, 5, 6, 7, 6.8, 4);
            vvt.DetailInfor(7);
            Console.ReadKey();  

            Grade thin = new Grade(7);
            thin.AddMath(5.4);
            thin.AddLiterature(6);
            thin.AddEnglish(7);
            thin.AddBiology(2.5);
            thin.AddHistory(10);
            thin.AddGeography(5);
            thin.ShowGrades();
            thin.Average(4);
            Console.ReadKey();
        }
    }
}
