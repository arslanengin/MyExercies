using System;

namespace Interfaces
{
    class Program
    {
        //classlara arayuz gorevı gorur classların o operasyonları ımzalamasını zorunlu hale getırır
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new BirinciMevzuat());
            customerManager.Add();
        }

         class CustomerManager
        {
             void AddWithoutInterface(int mevzuat)
            {
                if(mevzuat == 1)
                {
                    Console.WriteLine("Musterı 1. mevzuata göre eklendi");
                }
                else
                {
                    Console.WriteLine("Musterı 2.mevzuata göre eklendi");
                }
            }

            private  IMevzuat _mevzuat;
            public CustomerManager(IMevzuat mevzuat)
            {
                _mevzuat = mevzuat;
            }
            public void Add()
            {
                _mevzuat.IslemYap();
            }
         }

        interface IMevzuat
        {
            void IslemYap();
        }

        class BirinciMevzuat : IMevzuat
        {
            public void IslemYap()
            {
                Console.WriteLine("Birinci mevzuata göre işlem yapıldı");
            }
        }

        class İkinciMevzuat : IMevzuat
        {
            public void IslemYap()
            {
                Console.WriteLine("İkinci mevzuata göre işlem yapıldı");
            }
        }
    }
}
