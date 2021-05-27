using System;

namespace _4._Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            string storeName = "UAB \"Drogas\"";
            string storePhone = "52400529";
            decimal storeAPersentage = 20M;
            decimal costBePVM = 2.88M;
            decimal costPVM = Math.Round(costBePVM*(storeAPersentage/100));
            decimal costSuPVM = costPVM + costBePVM;


            decimal moketi = 3.49M;
            decimal moketa = 20.00M;


            Console.WriteLine($"{storeName}" +
                $"\nProduotuve \"Drogas\",  tel.:{storePhone}" +
                $"\nAdresas:    Seskines g. 30, Vilnius" +
                $"\nKasa Nr.1, Sas.Nr  LS  00000010899A" +
                $"\n                          #00337738" +
                $"\nKvitas 70/2369" +
                $"\n   Tr:0072 Kasa:0001              #" +
                $"\n   Kas ninkas: Emilija K.         #" +
                $"\n                                  #" +
                $"\nLACTACYD INT.HIG.EM          3,49 A" +
                $"\n+++++++++++++++++++++++++++++++++++" +
                $"\nTarp ne suma                 3,49  " +
                $"\n+++++++++++++++++++++++++++++++++++" +
                $"\n                              {moketi} " +
                $"\n                                   " +
                $"\nMoketi                       €{moketi} " +
                $"\nMoketa                      €{moketa} " +
                $"\nGraza                       €{moketa-moketi} " +
                $"\nKasininkas (-) Emilija K." +
                $"\nLF 00000010899A {date:yyyy-MM-dd HH:mm:ss}");

        }
    }
}
