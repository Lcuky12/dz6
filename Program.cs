using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            int time = 20;
            Console.WriteLine(age);
            Console.WriteLine(time);
            int temporaryAge;
            temporaryAge = time;
            time = age;
            Console.WriteLine(temporaryAge);
            Console.WriteLine(time);
        }
    }
}
