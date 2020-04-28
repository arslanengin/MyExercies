using System;

namespace ValueTypeReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler1 = new string[] { "Mugla", "İstanbul" };
            string[] sehirler2 = new string[] { "Mugla", "İstanbul" };
            sehirler1 = sehirler2;
            sehirler2[0] = "Aydın";
            foreach (var item in sehirler1)
            {
                Console.WriteLine(item);
            }

            string a = "a1";
            string b = "b1";
            b = a;
            a = "a2";
            Console.WriteLine(b);

            //String is a reference type that behaves like a value type
        }
    }
}
