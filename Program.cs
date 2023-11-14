using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exmpl01();
            Exmpl02();
            Exmpl03();
            Exmpl04();
        }

        static void Exmpl01()
        {
            List<int> list = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomm = random.Next(1, 100);
                list.Add(randomm);
            }
            Console.WriteLine("Коллекция чисел: ");

            foreach (int i in list)
            {
                Console.WriteLine(i);

            }

            Console.ReadKey();
            Console.WriteLine("----------------");

            int max1 = 0;
            int x = 0;
            for (int i = 0; i < 30; i++)
            {
                if (list.ElementAt(i) > max1)
                {
                    max1 = list.ElementAt(i);
                }

            }
            list.RemoveAt(x);
            int max2 = 0;
            for (int i = 0; i < 30; i++)
            {
                if (list.ElementAt(i) > max2)
                {
                    max2 = list.ElementAt(i);
                }

            }
            Console.WriteLine(max1);
            Console.WriteLine(max2);
            for (int i = 0; i < 30; i++)
            {
                if (i % 2 == 1)
                {
                    list.RemoveAt(i);
                }
            }

        }


        static void Exmpl02()



        {
            List<double> numbers = new List<double>();

            numbers.Add(5.5);
            numbers.Add(4.5);
            numbers.Add(3.8);
            numbers.Add(6.9);

            double sum = 0.0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Summa= ");
            Console.WriteLine(sum / numbers.Count);
            Console.ReadKey();


        }


        static void Exmpl03()
        {
            List<int> list = new List<int>();
            List<int> list1 = new List<int>();

            Random rnd = new Random();


            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(100));
            }
            int k = 10;

            for (int i = 10; i > 0; i--)
            {
                list1.Add(list[k]);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(list1);
            }

            Console.ReadKey();
        }

        static void Exmpl04()
        {
          
                string filePath = "C://Users//Asus//VS//C#//ConsoleApp3//employees.txt.txt/";

                List<string[]> lowSalaryEmployees = new List<string[]>();
                List<string[]> highSalaryEmployees = new List<string[]>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] data = reader.ReadLine().Split(',');

                        double salary;
                        if (double.TryParse(data[5], out salary))
                        {
                            if (salary < 10000)
                            {
                                lowSalaryEmployees.Add(data);
                            }
                            else
                            {
                                highSalaryEmployees.Add(data);
                            }
                        }
                    }
                }
                Console.WriteLine("Данные о сотрудниках с зарплатой менее 10000:");
                PrintEmployees(lowSalaryEmployees);

                Console.WriteLine("\nДанные об остальных сотрудниках:");
                PrintEmployees(highSalaryEmployees);

            void PrintEmployees(List<string[]> employees)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(string.Join(", ", employee));
                }
            }
        }
            
        }
    }
         
         


    