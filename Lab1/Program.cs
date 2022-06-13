using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, какое количество координат будет введено:");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите координаты по такому шаблону: XX.XXXX..,YY.YYYY..");
            var list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                try
                {
                var line = Console.ReadLine();
                list.Add(line);                    
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var result = new List<string>();
            foreach (var line in list)
            {
                var items = line.Split(new[] { ',' });
                if (items.Length == 2)
                {
                    var x = items[0].Trim().Replace('.', ',');
                    var y = items[1].Trim().Replace('.', ',');
                    result.Add(string.Format("X:{0} Y:{1}", x, y));
                }
            }
            Console.WriteLine("\nРезультат: ");
            foreach (var line in result)
                Console.WriteLine(line);
            Console.ReadLine();
        }
    }
}
