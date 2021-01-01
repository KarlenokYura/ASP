using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_3.Model
{
    public class Singleton: ISingleton
    {
        private int counter = 1;

        public string Get()
        {
            return "instanse_" + counter++;
        }

        public int Set(int c)
        {
            return this.counter = c;
        }
    }
}