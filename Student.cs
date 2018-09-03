using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Student
    {
        char Name, Group;
        
        public class Marks
        {
            char Subject;
            double Mark;
            int k = 3; // Размер массива
            public Marks()
            {
                Marks[0].Subject = "Mathematics";
                Marks[0].Mark = 8;

                Marks[1].Subject = "Physics";
                Marks[1].Mark = 5;

                Marks[2].Subject = "Chemistry";
                Marks[2].Mark = 5;
            }
        }
        
        public double GetAvgMark()
        {
            double mAvg;
            for (int i = 0; i < Marks.k; i++)
            {
                mAvg += Marks[i].Mark;
            }
            mAvg /= Marks.k;
            return mAvg;
        }

        public ResetAllMarks()
        {
            for (int i = 0; i < Marks.k; i++)
            {
                Marks[i].Mark = 0;
            }
        }

        public sPrint()
        {
            //Marks Marks = new Marks();
            Console.WriteLine("Student's name: " + Name);
            Console.WriteLine("Student's group: " + Group);
            Console.WriteLine("Student's marks:");
            Console.WriteLine("-----");
            for (int i = 0; i < Marks.k; i++)
            {
                Console.WriteLine(Marks[i].Subject+": "+ Marks[i].Mark);
            }
            Console.WriteLine("-----");
            Console.WriteLine("Average mark = " + GetAvgMark());
        }
    }
}
