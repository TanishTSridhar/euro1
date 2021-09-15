using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace exp3
{
    class Program
    {


        string filename = @"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp3\mytest.txt";

        public void createFILE()
        {
            FileStream fs = File.Create(filename);
            Console.WriteLine("A file created with name mytest.txt");
            Console.ReadLine();
            fs.Close();
        }

        public void deleteFILE()
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
                Console.WriteLine("The file mytest.txt deleted successfully.");
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("File does not exist");
                Console.ReadLine();
            }

        }


        public void checkFILE()
        {
            if (File.Exists(filename))
            {

                Console.WriteLine("A file created with name mytest.txt");
                Console.ReadLine();
            }
            else
            {
                FileStream fs = File.Create(filename);
                Console.WriteLine("A file created with name mytest.txt");
                Console.ReadLine();
                fs.Close();
            }


        }

        public void writeFILE()

        {
            FileStream fs = File.OpenWrite(filename);

            Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
            fs.Write(title, 0, title.Length);
            fs.Close();
            Console.WriteLine("Content ADDED");
            Console.ReadLine();




        }


        public void readFILE()
        {
            StreamReader sr = File.OpenText(filename);

            while (sr.Peek() > 0)
            {

                string line = sr.ReadLine();

                Console.WriteLine(line);

            }
            sr.Close();
        }

            
           static void Main(string[] args)
            {
                Program obj = new Program();
                obj.createFILE();
                 obj.deleteFILE();
                obj.checkFILE();
                obj.writeFILE();
                obj.readFILE();

            }


        }
    } 
