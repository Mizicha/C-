using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag1 = false;
            for(; ; )
            {
                Console.Clear();
                Console.WriteLine("1.Input marks");
                Console.WriteLine("2.Exit");
                try
                {
                    int k = Convert.ToInt32(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Input number of subjects: ");
                            Student stud = new Student();
                            int n = stud.getN;
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write("Name of subject №" + (i + 1) + ": ");
                                string subj = "";
                                subj = Console.ReadLine();

                                Console.Write("Mark: ");
                                int x = Convert.ToInt32(Console.ReadLine());

                                stud.mark[i] = new Marks(x, subj);
                                Console.WriteLine("-----------");
                            }

                            Console.Clear();
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine(stud.mark[i].getSubject + ": " + stud.mark[i].getMark);
                            }

                            Console.WriteLine("Average mark: " + stud.GetAvgMark());
                            flag1 = true;
                            Console.WriteLine("Press any key to continue");
                            Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Reseting all marks..");
                            stud.ResetAllMarks();
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine(stud.mark[i].getSubject + ": " + stud.mark[i].getMark);
                            }
                            Console.WriteLine("Press any key to exit");
                            Console.ReadLine();
                            return;
                            break;
                        case 2:
                            return;
                        default:
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
            try
            {
                

                
            }
            catch (Exception)
            {
                Console.WriteLine("Try again");
                Console.ReadLine();
            }
        }
    }
}
