using System;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string[] nameAndTown = Console.ReadLine().Split(" ",4);
            string firstname = nameAndTown[0];
            string lastname = nameAndTown[1];
            string adress = nameAndTown[2];
            string town = nameAndTown[3];
            string allname = $"{firstname} {lastname}";
            MyThreeuple<string, string, string> TownName = new MyThreeuple<string, string, string>(allname, adress, town);

            string[] beerNameTrorfol = Console.ReadLine().Split();
            string name = beerNameTrorfol[0];
            int beer = int.Parse(beerNameTrorfol[1]);
            bool istrue=beerNameTrorfol[2]=="drunk";
            string isTrue = "";
            if (istrue)
            {
                isTrue = "True";
            }
            else
            {
                isTrue = "False";
            }
            MyThreeuple<string, int, string> BeerName = new MyThreeuple<string, int, string>(name, beer,isTrue );

            string[] bankAcount = Console.ReadLine().Split(" ",4);
            string names = bankAcount[0];
            double acount = double.Parse(bankAcount[1]);
            string bankname = bankAcount[2];
            MyThreeuple<string, double, string> Nameacount =
                new MyThreeuple<string, double, string>(names, acount, bankname);

            Console.WriteLine(TownName.ToString());
            Console.WriteLine(BeerName.ToString());
            Console.WriteLine(Nameacount.ToString());
        }
    }
}
