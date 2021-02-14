using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Zadanie_8
{
    class vegetables : product
    {
        public int weight;
        public int calories;
    }

    class fruit : product
    {
        public int capacity;
        public int vitamins;
    }

    class dessert : product
    {
        public int calorites;
        public int cacaopercent;
    }
}
