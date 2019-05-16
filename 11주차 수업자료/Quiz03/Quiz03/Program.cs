using System;
using System.Reflection;

namespace Quiz03
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            Type type = a.GetType();

            FieldInfo[] fields = type.GetFields();

            foreach(FieldInfo f in fields)
            {
                Console.WriteLine("Type:{0}, Name:{1}", f.FieldType.Name, f.Name);
            }

            String b = "awda";
            Type type2 = b.GetType();

            FieldInfo[] fields2 = type2.GetFields();

            foreach (FieldInfo f in fields2)
            {
                Console.WriteLine("Type:{0}, Name:{1}", f.FieldType.Name, f.Name);
            }



            String c = "awda";
            Type type3 = c.GetType();

            MemberInfo[] fields3 = type3.GetMembers();

            foreach (MemberInfo f in fields3)
            {
                Console.WriteLine("13123 Type:{0}, Name:{1}", f, f.Name);
            }
        }
    }
}
