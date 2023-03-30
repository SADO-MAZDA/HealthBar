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
            float health; 
            float lenghtHealthBar;
            float maxPercent = 100;

            Console.Write("Введите длину HealthBar - ");
            lenghtHealthBar = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите процент здоровья - ");
            health = Convert.ToSingle(Console.ReadLine());

            if (health <= maxPercent)
            {
                DrawHealtBar(health, lenghtHealthBar, ConsoleColor.Red);
                Console.ReadKey();
            }
            else
            {
                Console.Write("Процент здоровья должен быть не больше" +maxPercent + "\nНажмите любую клавишу и ведите число здоровья еще раз ...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DrawHealtBar(float value,float maxValue,ConsoleColor color )
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            float percentHealth ;
            float maxPercent = 100;
            
            percentHealth = value / maxValue * maxPercent;

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
        }
    }
}
