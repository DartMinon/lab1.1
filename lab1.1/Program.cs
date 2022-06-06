using System;

namespace lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Привет, подсказать текущую дату,время? \n 1) Да \n 2) Нет");
            int output1= int.Parse(Console.ReadLine());
            if (output1 == 1)
            {
                Console.WriteLine(DateTime.Now);
            }
            if (output1 == 2)
            {
                Console.WriteLine("Всего хорошего");
            }


        }
    }
}
