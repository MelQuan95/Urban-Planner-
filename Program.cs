using System;

namespace urbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {



            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 25,
                Stories = 100
            };
            FiveOneTwoEigth.Depth = 25;

            FiveOneTwoEigth.Construct();

            FiveOneTwoEigth.Purchase("Denzal Washington");

            FiveOneTwoEigth.getInfo();

            Building NineteenSeventeen = new Building("1917 9th Avenue")
            {
                Width = 100,
                Stories = 7
            };
            NineteenSeventeen.Depth = 25;

            NineteenSeventeen.Construct();

            NineteenSeventeen.Purchase("Nick Cage");

            NineteenSeventeen.getInfo();

            Building EightOneEight = new Building("818 8th Avenue")
            {
                Width = 35,
                Stories = 25
            };
            EightOneEight.Depth = 77;

            EightOneEight.Construct();

            EightOneEight.Purchase("GOD");

            EightOneEight.getInfo();



            Building OneFourSeven = new Building("147 10th Street")
            {
                Width = 85,
                Stories = 18
            };
            OneFourSeven.Depth = 98;

            OneFourSeven.Construct();

            OneFourSeven.Purchase("MelQuan Green");

            OneFourSeven.getInfo();











        }

    }
}
