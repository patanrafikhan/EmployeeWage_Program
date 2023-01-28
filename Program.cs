using System;

namespace Employeewage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage App");
           
            Random ren =new Random();
            int n=ren.Next();
            if (n == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
