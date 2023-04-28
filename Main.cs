namespace School 
{
    class CMain
    {
        public static void Main(string[] args)
        {
            COutputText Activity1 = new COutputText();
            Activity1.Entry();

            CDiscount Activity2 = new CDiscount();
            Activity2.Entry();

            CFlowRate Activity3 = new CFlowRate();
            Activity3.Entry();

            CSquare Activity4 = new CSquare();
            Activity4.Entry();

            Dice Activity5 = new Dice();
            Activity5.Entry();

            Temperature Activity6 = new Temperature();
            Activity6.Entry();

            Miscellaneous Activity7 = new Miscellaneous();
            Activity7.Entry();

            FishTank Activity8 = new FishTank();
            Activity8.Entry();

            Carpet Activity9 = new Carpet();
            Activity9.Entry();
        }
    }
}