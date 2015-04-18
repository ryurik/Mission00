using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public readonly string[] _names = { "Книги", "Спорт инвентарь", "Некоторый товар", "Продукты питания" };

        static void Main(string[] args)
        {
            ArrayList itemsList = new ArrayList();
            
            Double allItemsCosts = 0;

            for (int i = 0; i < 100000; i++)
            {
                itemsList.Add(new Item());
                allItemsCosts += ((Item) itemsList[i]).WholeCost();
            }

            Console.WriteLine("Общая стоимость товара {0:N2}", allItemsCosts);
            Console.ReadKey();
        }
    }
}
