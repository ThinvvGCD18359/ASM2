using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    public class Grade
    {
        public int GradeID;
        private double Maths;
        private double Literature;
        private double English;
        private double Biology;
        private double History;
        private double Geography;
        public Grade(int gradeID)
        {
            GradeID = gradeID;
        }
        public Grade (int gradeID, double maths, double literature, double english, double biology, double history, double geography)
        {
            GradeID = gradeID;
            Maths = maths;
            Literature = literature;
            English = english;
            Biology = biology;
            History = history;
            Geography = geography;
        }

        public double AddMath(double maths)
        {
            if (0<=maths && maths <= 10)
            {
                Maths = maths;
            }
            else
            {
                Console.WriteLine("Error!!! Score must be between 0 and 10");
            }
            return Maths;
        }
        public double AddLiterature(double literature)
        {
            if (0 <= literature && literature <= 10)
            {
                Literature = literature;
            }
            else
            {
                Console.WriteLine("Error!!! Score must be between 0 and 10");
            }
            return Literature;
        }
        public double AddEnglish(double english)
        {
            if (0 <= english && english <= 10)
            {
                English = english;
            }
            else
            {
                Console.WriteLine("Error!!! Score must be between 0 and 10");
            }
            return English;
        }
        public double AddBiology(double biology)
        {
            if (0 <= biology && biology <= 10)
            {
                Biology = biology;
            }
            else
            {
                Console.WriteLine("Error!!! Score must be between 0 and 10");
            }
            return Biology;
        }
        public double AddHistory(double history)
        {
            if (0 <= history && history <= 10)
            {
                History = history;
            }
            else
            {
                Console.WriteLine("Error!!! Score must be between 0 and 10");
            }
            return History;
        }
        public double AddGeography(double geography)
        {
            if (0 <= geography && geography <= 10)
            {
                Geography = geography;
            }
            else
            {
                Console.WriteLine("Error!!! Score must be between 0 and 10");
            }
            return Geography;
        }
        public double GetMath()
        {
            return Maths;
        }
        public double GetLiterature()
        {
            return Literature;
        }
        public double GetEnglish()
        {
            return English;
        }
        public double GetBiology()
        {
            return Biology;
        }
        public double GetHistory()
        {
            return History;
        }
        public double GetGeography()
        {
            return Geography;
        }

        public void ShowGrades()
        {
            Console.WriteLine(GradeID);
            Console.WriteLine("___________________________________________________________________________________________");
            Console.WriteLine("|Maths: {0} |Literature: {1} |English: {2} |Biology: {3} |History: {4} |Geography: {5} |", Maths, Literature, English, Biology, History, Geography);
        }
        public double Average(int id)
        {
            double average;
            Console.WriteLine("Avarage score is: " + (average = (Maths + Literature + English + Biology + History + Geography) / 6));
            return average = (Maths + Literature + English + Biology + History + Geography) / 6;
        }
    }
}
