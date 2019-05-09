using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Quiz01
{
    class GClass<T>
    {
        private List<T> list;
        private int i
        {
            set; get;
        }
        

        public GClass()
        {
            list = new List<T>();
        }

        public String getValue()
        {
            String str = "";
            foreach (T e in list)
                str += (e.ToString() + " ");

            return str;
        }

        public void setValue(params T[] args)
        {
            foreach (T e in args)
                list.Add(e);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            GClass<int> gc = new GClass<int>();
            gc.setValue(10, 20, 30);
            Console.WriteLine(gc.getValue());


        }
    }
}
