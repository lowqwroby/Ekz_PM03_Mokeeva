using System;
using System.Collections.Generic;
using System.Text;

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
                    Console.Write("Введите вид рыбы: ");
                    t = Console.ReadLine();
                    Console.Write("Введите производителя рыбы: ");
                    prz = Console.ReadLine();
                    Console.Write("Введите цену рыбы: ");
                    pr = Console.ReadLine();

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


    }
}
