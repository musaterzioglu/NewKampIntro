using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKampIntro
{
    class ETicaret
    {
      
        static void Main(string[] args)
        {
            string[] computers = new string[] {"LENOVO","CASPER","HP","DELL","ASUS" };

            for (int i = 0; i < computers.Length; i++)
            {
                Console.WriteLine(computers[i]);
            }

            foreach (string computer in computers)
            {
                Console.WriteLine(computer);
            }

        }
        

    }
}
