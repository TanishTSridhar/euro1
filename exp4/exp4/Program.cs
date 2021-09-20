using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exp4
{
    class Program
    {
        public void ReadPerticularLine(int n)
        {
            FileStream fs = new FileStream(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp4\exp4\exp4text.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int i = 1;
            while (i < n)
            {
                string line = sr.ReadLine();
                i++;
            }
            Console.WriteLine(sr.ReadLine());

        }

        public void TotalLines()
        {
            FileStream fs = new FileStream(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp4\exp4\exp4text.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();

            int i = 1;

            while (sr.Peek() > 0)
            {
                line = sr.ReadLine();
                i++;
            }

            Console.WriteLine("Total number of lines = " + i);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ReadPerticularLine(2);
            obj.TotalLines();
        }
    }
}
