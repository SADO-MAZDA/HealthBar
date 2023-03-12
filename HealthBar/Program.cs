using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthBar
{
    class Program
    {
        static void Main(string[] args)
        {
            float healt , maxHealt = 100;
  
            while(true)
            {
                Console.Clear();
                Console.Write("Введите число здоровья");
                healt = Convert.ToSingle(Console.ReadLine());

                if (healt <= maxHealt)
                {
                    DrawHealtBar(healt, maxHealt, ConsoleColor.Red);
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Максимальное количество здоровья - " + maxHealt + "\nНажмите любую клавишу и ведите число здоровья еще раз ...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void DrawHealtBar(float value,float maxValue,ConsoleColor color )
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            float percentHealth ;
            
            percentHealth = value / maxValue * 100;

            for (int i = 0; i < value; i++)
            {
                bar += "+";
            }

            Console.SetCursorPosition(0, 2);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor; 
            bar = "";
            int wholeValue = Convert.ToInt32(value);

            for (int i = wholeValue; i < maxValue; i++)
            {
                bar += ">";
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(bar + "]");
            Console.WriteLine("Заполненность здоровья составляет - "+ percentHealth+ " процентов. ");
        }
    }
}