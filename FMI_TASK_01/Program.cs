using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMI_TASK_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldCoins;
            int priceCrystals = 5;
            int buyCrystals;
            bool optionPurchase;

            Console.Write("Сколько у вас золотых монет? ");
            goldCoins = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Цена кристалла {priceCrystals} монет. Сколько вы хотите купить кристаллов? ");
            buyCrystals = Convert.ToInt32(Console.ReadLine());

            optionPurchase = goldCoins >= priceCrystals * buyCrystals;
            buyCrystals *= Convert.ToInt32(optionPurchase);
            goldCoins -= priceCrystals * buyCrystals;

            Console.WriteLine($"У вас в сумке осталось {goldCoins} монет и появилось {buyCrystals} кристаллов.");
        }
    }
}
