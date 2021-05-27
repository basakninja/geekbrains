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
            string saller = "Kas ninkas: Emilija K.";
            string kassa = "Tr:0072 Kasa:0001";
            int lsNumber = 00000010899;
            int kvitas = 236;
            string address = "Seskines g. 30, Vilnius";


            decimal moketi = 3.49M;
            decimal moketa = 20.00M;


            Console.WriteLine($"{storeName}" +
                $"\nProduotuve \"Drogas\",  tel.:{storePhone}" +
                $"\nAdresas:    {address}" +
                $"\nKasa Nr.1, Sas.Nr  LS  {lsNumber}A" +
                $"\n                          #00337738" +
                $"\nKvitas 70/{kvitas}" +
                $"\n   {kassa}              #" +
                $"\n   {saller}         #" +
                $"\n                                  #" +
                $"\nLACTACYD INT.HIG.EM          {costSuPVM} A" +
                $"\n+++++++++++++++++++++++++++++++++++" +
                $"\nTarp ne suma                 {costSuPVM}  " +
                $"\n+++++++++++++++++++++++++++++++++++" +
                $"\n                              {moketi} " +
                $"\n                                   " +
                $"\nMoketi                    EUR {moketi} " +
                $"\nMoketa                   EUR {moketa} " +
                $"\nGraza                    EUR {moketa-moketi} " +
                $"\nKasininkas (-) Emilija K." +
                $"\nLF 00000010899A {date:yyyy-MM-dd HH:mm:ss}");

        }
    }
}
