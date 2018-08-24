using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndLambda
{
    class Program
    {
        //public delegate bool TestDel(string s);

        static void Main(string[] args)
        {
            string[] items = { "Larry", "Moe", "Curly", "Shemp" };

            Console.Write("Set Max Length = ");
            int max = int.Parse(Console.ReadLine());

            //Func<string, bool> test = delegate(string s)
            //{
            //    return s.Length > max;
            //};

            string[] result = Where(items, s => s.Length > max);
            foreach (var s in result)
            {
                Console.WriteLine(s);
            }
        }

        static bool TestForlength(string s)
        {
            return s.Length > 3;
        }

        static string[] Where(string[] items, Func<string, bool> test)
        {
            var result = new List<string>();
            foreach (var item in items)
                if (test(item))
                    result.Add(item);
            return result.ToArray();
        }
    }



    public class Rootobject
    {
        public string Id { get; set; }
        public string First_name { get; set; }
        public string Gender { get; set; }
        public string Last_name { get; set; }
        public string Link { get; set; }
        public string Locale { get; set; }
        public string Name { get; set; }
        public int Timezone { get; set; }
        public DateTime Updated_time { get; set; }
        public bool Verified { get; set; }
    }

}
