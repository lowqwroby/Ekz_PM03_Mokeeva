using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PM03_Mokeeva_PKspk220
{
    class FishControl
    {

        private Fish[] mas;
        private int n;

        public FishControl(Fish[] mas, int n)
        {
            this.mas = mas;
            this.n = n;
        }

        public void CreateMasFish(Fish[] mas, int n)
        {
            try
            {
                string t, prz, pr;

                for(int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine("Рыба №" + (i + 1) + "\n");
                    Console.Write("Введите вид рыбы: ");
                    t = Console.ReadLine();
                    Console.Write("Введите производителя рыбы: ");
                    prz = Console.ReadLine();
                    Console.Write("Введите цену рыбы: ");
                    pr = Console.ReadLine();

                    Console.WriteLine();

                    mas[i] = new Fish(t, prz, pr);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void Sort()
        {
            try
            {
                Fish temp1;

                for(int i = 0; i < mas.Length - 1 ; i++)
                {
                    if(mas[i].type[0] < mas[i + 1].type[0] && int.Parse(mas[i].price) < int.Parse(mas[i + 1].price))
                    {
                        temp1 = mas[i];
                        mas[i] = mas[i + 1];
                        mas[i + 1] = temp1;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }            
        }

        public string ToStringFish(Fish mas)
        {
            return "Вид рыбы: " + mas.type + "\nПроизводитель рыбы: " + mas.proiz + "\nЦена рыбы: " + mas.price + "\n";
        }

        public void ReadInFile()
        {
            try
            {
                using (StreamWriter write = new StreamWriter("fish.txt"))
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        write.Write(ToStringFish(mas[i]));
                    }
                    write.Write("\n\r\n\r");
                }                 

                Console.WriteLine("Запись в файл произведена успешно");
            }
            catch(Exception ex)
            {
                Console.Write(ex);
            }
            
        }

    }
}
