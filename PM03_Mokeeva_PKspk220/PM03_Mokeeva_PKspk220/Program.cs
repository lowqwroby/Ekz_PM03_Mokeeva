using System;

namespace PM03_Mokeeva_PKspk220
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                int n;
                Console.Write("Введите n: ");
                n = int.Parse(Console.ReadLine());
                Fish[] mas = new Fish[n];            

                FishControl fish = new FishControl(mas, n);
            
                fish.CreateMasFish(mas, n);

                fish.Sort();

                for(int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine("Рыба №" + (i + 1));
                    Console.WriteLine("Вид рыбы: " + mas[i].type + "\n" + "Производитель рыбы: " + mas[i].proiz + "\n" + "Цена рыбы: " + mas[i].price + "\n");
                }

                fish.ReadInFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
    }
}
