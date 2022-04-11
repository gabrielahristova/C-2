using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i <= openedTabs; i++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    salary -= 100;
                    if (salary < 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                if (site == "Instagram")
                {
                    salary -= 50;
                    if (salary < 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                if (site == "Emag")
                {
                    salary -= 40;
                    if (salary < 0)
                    {
                        Console.WriteLine("You have lost your salary.");
                        break;
                    }
                }
                if (salary > 0 && i == openedTabs - 1)
                {
                    Console.WriteLine(salary);
                }
            }

        }
    }
}
