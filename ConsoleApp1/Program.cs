using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            new GenerateList().Run(57);

        }
    }
    class GenerateList
    {
        const int LEN = 100;
        ArrayList ListQ;
        public void Run(int AddUpToNumber)
        {
            Random r = new Random();
            ListQ = new ArrayList();
            for (int i = 0; i < LEN; i++)
            {
                ListQ.Add(r.Next(100));
                this.findTwoNumbersThatAddUpTo(AddUpToNumber);
                break;
            }


        }
        public void findTwoNumbersThatAddUpTo(int a)
        {
            Random r = new Random();
            ListQ = new ArrayList();
            int a1 = 0;
            int a2 = 0;
            for (int i = 0; i < LEN; i++)
            {
                int n1 = ListQ.Add(r.Next(100));
                int n2 = ListQ.Add(r.Next(100));
                if (n1 + n2 == a)
                {
                    a1 = n1;
                    a2 = n2;
                    Console.WriteLine(a1 + " " + a2);
                }
            }
        }
    }
}
