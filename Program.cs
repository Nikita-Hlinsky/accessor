using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5
{   
    class Student
    {
        private int year;

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 1)
                    year = 1;
                else if (value > 5)
                    year = 5;
                else year = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();

            st1.Year = 6;// записываем в поле, используя аксессор set
            Console.WriteLine(st1.Year);
        }
    }
}
