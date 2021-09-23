using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace exp9
{
    class Program
    {
        public static long totalSize;

        static void Main(string[] args)
        {
            if (!Directory.Exists(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp6\exp6") )
            {
                Console.WriteLine("The directory does not exist.");
                return; 
            }

            String[] files = Directory.GetFiles(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp6\exp6");
            Parallel.For(0, files.Length, index =>
            { FileInfo fi = new FileInfo(files[index]); long size = fi.Length; Interlocked.Add(ref totalSize, size); }); 

            Console.WriteLine("Directory '{0}':", @"C: \Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp6\exp6"); 
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
            Console.ReadLine();
        }
    }
}
