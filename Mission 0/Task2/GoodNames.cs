using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class GoodNames
    {
        public static readonly string[] Names = { "Книги", "Спорт инвентарь", "Некоторый товар", "Продукты питания" };

        public static string GetRandomGoodName()
        {
            return (!Names.Any()) ? "" : Names[new Random().Next(Names.Count())];
        }

    }
}
