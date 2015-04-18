using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            ArrayList itemsListClass = new ArrayList();
            ArrayList itemsListStuct = new ArrayList();
            
            Double allItemsCosts = 0;
            Random rnd = new Random();

            // Working with Class
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                itemsListClass.Add(new Item()
                {
                    Name = GoodNames.GetRandomGoodName(),
                    Price = rnd.NextDouble() * 1000,
                    Quantity = rnd.Next(1000)
                });
                allItemsCosts += ((Item) itemsListClass[i]).WholeCost();
            }
            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            Console.WriteLine("Общая стоимость товара {0:N2} руб", allItemsCosts);
            Console.WriteLine("Затраченное время при работе с классом {0}", elapsedTime);


            // Working with Stuct
            allItemsCosts = 0;
            stopWatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                itemsListStuct.Add(new ItemStruct(
                    GoodNames.GetRandomGoodName(),
                    rnd.NextDouble() * 1000,
                    rnd.Next(1000)
                ));
                allItemsCosts += ((ItemStruct)itemsListStuct[i]).WholeCost();
            }
            stopWatch.Stop();

            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            Console.WriteLine("Общая стоимость товара {0:N2} руб", allItemsCosts);
            Console.WriteLine("Затраченное время при работе со структурой {0}", elapsedTime);


            Console.ReadKey();
        }
    }
}
