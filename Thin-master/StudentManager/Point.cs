using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManager
{
    public class Point
    {
        public int PointID;
        private double Maths;
        private double Literature;
        private double English;
        private double Biological;
        private double History;
        private double Geography;
        public Point(int pointID)
        {
            PointID = pointID;
        }
        public Point (int pointID, double maths, double literature, double english, double biological, double history, double geography)
        {
            PointID = pointID;
            Maths = maths;
            Literature = literature;
            English = english;
            Biological = biological;
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
        public double AddBiological(double biological)
        {
            if (0 <= biological && biological <= 10)
            {
                Biological = biological;
            }
            else
            {
                Console.WriteLine("Error!!! Score must be between 0 and 10");
            }
            return Biological;
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
        public double GetMarth()
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
        public double GetBiological()
        {
            return Biological;
        }
        public double GetHistory()
        {
            return History;
        }
        public double GetGeography()
        {
            return Geography;
        }

        public void DisplayPoint()
        {
            Console.WriteLine(PointID);
            Console.WriteLine("___________________________________________________________________________________________");
            Console.WriteLine("|Maths: {0} |Literature: {1} |English: {2} |Biological: {3} |History: {4} |Geography: {5} |", Maths, Literature, English, Biological, History, Geography);
          
        }
        public double Averages(int id)
        {
            double average;
            Console.WriteLine("Avarage score is: " + (average = (Maths + Literature + English + Biological + History + Geography) / 6));
            return average = (Maths + Literature + English + Biological + History + Geography) / 6;
        }
    }
}
