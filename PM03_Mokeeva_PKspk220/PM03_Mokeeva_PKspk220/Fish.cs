using System;
using System.Collections.Generic;
using System.Text;

namespace PM03_Mokeeva_PKspk220
{
    class Fish
    {
        public string type = "";
        public string proiz = "";
        public string price = "";

        public Fish(string type, string proiz, string price)
        {
            this.type = type;
            this.proiz = proiz;
            this.price = price;
        }

        /*public string GetTypeFish(string type)
        {
            return type;
        }

        public string GetProizFish(string proiz)
        {
            return proiz;
        }

        public string GetProceFish(string price)
        {
            return price;
        }*/
    }
}
