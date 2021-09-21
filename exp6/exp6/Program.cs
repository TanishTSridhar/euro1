using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;

namespace exp6
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.city = new City();
            obj.name = "TANISH";
            obj.age = 22;
            obj.city.name = "Bangalore";
            obj.city.population = 10000000;

            var binaryformat = new BinaryFormatter();
            Stream s = new FileStream(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp6\exp6\EXP6TEXT.txt", FileMode.Create, FileAccess.Write);
            binaryformat.Serialize(s, obj);
            s.Close();
            Console.WriteLine("Serialization Complete");


            s = new FileStream(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp6\exp6\EXP6TEXT.txt", FileMode.Open, FileAccess.Read);
            Person person = (Person)binaryformat.Deserialize(s);
            Console.WriteLine("Deserialized Complete");
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.city.name);
            Console.WriteLine(person.city.population);

            XmlSerializer sr = new XmlSerializer(typeof(Person));
            FileStream fl = File.Create(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp6\exp6\EXP6TEXT.txt");

            sr.Serialize(fl, obj);
            fl.Close();

            XmlSerializer reader = new XmlSerializer(typeof(Person));
            FileStream fs = File.OpenRead(@"C:\Users\Tanish T Sridhar\Desktop\eurofins tranining\euro1\exp6\exp6\EXP6TEXT.txt");

            Person p = (Person)reader.Deserialize(fs);

            Console.WriteLine("Deseialization Comlete");
            Console.WriteLine(p.name);
            Console.WriteLine(p.age);
            Console.WriteLine(p.city.name);
            Console.WriteLine(p.city.population);

            Console.Read();


        }

    }
    [Serializable]
    public class City
    {
        public string name { get; set; }
        public int population { get; set; }

    }

    [Serializable]
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public City city { get; set; }
    }

}
    

