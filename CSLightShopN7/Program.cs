using System;

namespace CSLightShopN7
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldCoin;
            int cristalAmount;
            int desiredQuantityCristal;
            int cristalUnitPrice = 10;

            Console.Write("Укажите начальное количество золота: ");
            goldCoin = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Сколько кристаллов вы хотите купить по цене {cristalUnitPrice} " +
                $"золотых за кристалл? ");

            desiredQuantityCristal = Convert.ToInt32(Console.ReadLine());

            goldCoin -= desiredQuantityCristal * cristalUnitPrice;
            cristalAmount = desiredQuantityCristal;

            Console.WriteLine($"\nВы приобрели {cristalAmount} кристаллов." +
                $"\nУ вас осталось золота {goldCoin} монет");

            Console.ReadLine();
        }
    }
}
