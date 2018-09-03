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

        public Student()
        {
            this.Name = "Ivan Ivanov";
            this.Group = "PO-31";
        }

        public class Marks 
        {
            public String[] Subject = new string[3];
            public int[] Mark = new int[3];
            public int k = 3; // Размер массива

            public Marks()
            {
                setSubject(0, "Mathematics");
                setSubject(1, "Physics");
                setSubject(2, "Chemistry");
                setMark(0, 8);
                setMark(1, 5);
                setMark(2, 5);
            }

            public void setMark(int x, int y)
            {
                this.Mark[x] = y;
            }

            public void setSubject(int x, String y)
            {
                this.Subject[x] = y;
            }

            public int getMark(int x)
            {
                return this.Mark[x];
            }

            public String getSubject(int x)
            {
                return this.Subject[x];
            }
        }
        
        public void sPrint()
        {
            Marks mrk = new Marks();
            double GetAvgMark()
            {
                double mAvg = 0;
                for (int i = 0; i < mrk.k; i++)
                {
                    mAvg += mrk.getMark(i);
                }
                mAvg /= mrk.k;
                return mAvg;
            }
            void ResetAllMarks()
            {
                for (int i = 0; i < mrk.k; i++)
                {
                    mrk.setMark(i, 0);
                }
            }
            for(; ; )
            {
                try
                {
                    Console.WriteLine("Student's name: " + Name);
                    Console.WriteLine("Student's group: " + Group);

                    Console.WriteLine("Student's marks:");
                    Console.WriteLine("-----");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(mrk.getSubject(i) + ": " + mrk.getMark(i));
                    }
                    Console.WriteLine("-----");
                    Console.WriteLine("Average mark = " + GetAvgMark());
                    Console.WriteLine();
                    Console.WriteLine("Reset all marks?");
                    Console.WriteLine("Yes - 1 / No - 2");
                    int k = Int32.Parse(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            Console.Clear();
                            ResetAllMarks();
                            Console.WriteLine("Student's name: " + Name);
                            Console.WriteLine("Student's group: " + Group);
                            Console.WriteLine("Student's marks:");
                            Console.WriteLine("-----");
                            for (int i = 0; i < mrk.k; i++)
                            {
                                Console.WriteLine(mrk.getSubject(i) + ": " + mrk.getMark(i));
                            }
                            Console.WriteLine("-----");
                            Console.WriteLine("Average mark = " + GetAvgMark());
                            Console.WriteLine();
                            Console.ReadLine();
                            return;
                        case 2:
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Try again");
                            Console.ReadLine();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Try again");
                    Console.ReadLine();
                }
            }
        }
    }
}
