using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                int regno, num;
                string course, course_title;
                FileStream fs = new FileStream(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp1\exp1.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                Console.WriteLine("Course Details");

                Console.WriteLine("Enter the number of Courses");
                num = Convert.ToInt32(Console.ReadLine());

                sw.WriteLine("Course Details");
                sw.WriteLine("*****************");
                sw.WriteLine("Number of Courses : " + num);
                 sw.WriteLine(" ");



            for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Enter the REG.NO");
                    regno = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Course");
                    course = Console.ReadLine();

                    Console.WriteLine("Enter the Course Title");
                    course_title = Console.ReadLine();

               
                    sw.WriteLine("RegNo : " + regno);
                    sw.WriteLine("Course : " + course);
                    sw.WriteLine("Title : " + course_title);
                    sw.WriteLine(" ");
                }
                    
                    sw.Close();

                    fs.Close();


            }
        }
    }


