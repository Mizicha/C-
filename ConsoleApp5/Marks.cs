using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Marks : Student
    {
        
        public string Subject;
        public int Mark;
        

        public Marks(int Mark, string Subject)
        {
            this.Mark = Mark;
            this.Subject = Subject;
        }

        public void setMark(int x)
        {
            this.Mark = x;
        }

        public void setSubject(String subj)
        {
            this.Subject = subj;
        }

        public int getMark
        {
            get { return this.Mark; }
        }

        public String getSubject
        {
           get { return Subject; } 
        }
    }
}
