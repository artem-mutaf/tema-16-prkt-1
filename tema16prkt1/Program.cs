using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema16prkt1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            ///<summary>
            ///Объявляем переменную по текущему времени
            ///<summary>
            DateTime data = DateTime.Now;
            
            Console.WriteLine("Текущая дата:\n");
            Console.WriteLine(data.ToShortDateString());
            Console.WriteLine(data.ToString("d MMM yyyy"));
            Console.WriteLine(data.ToLongDateString());
            Console.WriteLine(data.ToString("ddd,d MMM yyyy"));
            Console.WriteLine(data.ToString("dddd,d MMMM yyyy\n"));

            Console.WriteLine("Текущее время:\n");
            Console.WriteLine(data.ToString("H:mm:ss"));
            Console.WriteLine(data.ToString("HH:mm\n"));

            Console.WriteLine("Текущая дата и время:\n");
            Console.WriteLine(data);
            Console.WriteLine(data.ToLongDateString()+data.ToString("HH:mm"));
            Console.WriteLine(data.ToLongDateString()+ data.ToString("HH:mm:ss"));
            Console.WriteLine(data.ToString("R"));
            Console.WriteLine(data.ToString("u\n"));

            //Задание 2
            DateTime data1 = DateTime.Now;
            Console.Write("Введите ваш возраст - ");
            //Переменная для самостоятельного ввода возвраста
            int data2 = int.Parse(Console.ReadLine());// 17
            Console.WriteLine($"Вы родились в {data1.Year-data1.Month-data2} году");// Вы родились в 2006 году
            //А чтобы определить возвраст в 3 задании, мы просто можем воспользоваться тем же кодом просто введя год рождения
            DateTime data4 = DateTime.Now;
            Console.Write("Введите год в котором родились - ");
            //Переменная для самостоятельного ввода года рождения
            int data5 = int.Parse(Console.ReadLine());// 2006
            Console.WriteLine($"Вам {data4.Year - data4.Month - data5} лет"); // Вам 17 лет



            Console.ReadKey();
        }
    }
}
