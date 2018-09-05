using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        public String Name;
        public String Group;
        public static int n = Convert.ToInt32(Console.ReadLine());
        public Marks[] mark = new Marks[n];

        public Student()
        {
            this.Name = "Ivan Ivanov";
            this.Group = "PO-31";
        }

        public int getN
        {
           get { return n; }
        }

        public double GetAvgMark()
        {
            double mAvg = 0;
            for (int i = 0; i < n; i++)
            {
                mAvg += mark[i].getMark;
            }
            mAvg /= n;
            return mAvg;
        }

        public void ResetAllMarks()
        {
            for(int i = 0; i < n; i++)
            {
                mark[i].setMark(0);
            }
        }
    }
}
