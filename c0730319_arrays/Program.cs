
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730319_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            studentinformation _mary = new studentinformation("mary", 3.8, 20);
            studentinformation _john = new studentinformation("john", 3.8, 10);
            studentinformation _mark = new studentinformation("mark", 0.2, 3);
            studentinformation _steve = new studentinformation("steve", 2.9, 16);
            studentinformation _cindy = new studentinformation("cindy", 3.9, 18);
            Console.ReadLine();
        
    }

        class studentinformation
        {
            public string name;
            public double gpa;
            public int attendance;

            public studentinformation(string aname, double cgpa, int dattendance)
            {

            name = aname;
            gpa = cgpa;
            attendance =dattendance;

            }
        }
    }
    
}

