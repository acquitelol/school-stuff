namespace School
{
    class COutputText 
    {
        public void Entry() 
        {
            this.OutputText();
        }

        private void OutputText()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class CDiscount
    {
        public void Entry()
        {
            Console.WriteLine(this.Discount(60, 50));
        }

        private double Discount(double total, double rate)
        {
            return total * (rate / 100);
        }
    }

    class CFlowRate
    {
        public void Entry()
        {
            const double volume = 330;
            const double time = 4;
            double heart;
            heart = this.FlowRate(volume, time);
            Console.WriteLine($"The flow rate of the human heart is {heart} ml/s");
        }

        private double FlowRate(double volume, double time)
        {
            return volume / time;
        }
    }

    class CSquare
    {
        public void Entry()
        {
            int A = 9;
            Console.WriteLine($"Squared: {Square(A)}");
        }

        private int Square(int x)
        {
            return x * x;
        }
    }

    class Dice
    {
        public void Entry()
        {
            this.Output5();
        }

        private void Output5()
        {
            Console.WriteLine("ooooooooooo");
	        Console.WriteLine("o         o");
 	        Console.WriteLine("o  #   #  o");
	        Console.WriteLine("o    #    o");
	        Console.WriteLine("o  #   #  o");
	        Console.WriteLine("o         o");
	        Console.WriteLine("ooooooooooo");
        }
    }

    class Temperature
    {
        public void Entry()
        {
            double C = 30;
            double F = CtoF(C);
            Console.WriteLine($"{C}*C = {F}*F");
        }

        private double CtoF(double C)
        {
            return (C * 1.8) + 32;
        }

        private double FtoC(double F)
        {
            return (F / 1.8) - 32;
        }
    }

    class Miscellaneous
    {
        public void Entry()
        {
            const string digits = "0123456789";
            const string characters = "abcdABCD@#!£";
            const string alphanumerics = digits + characters;

            Console.WriteLine($"The digits are {digits}");
            Console.WriteLine($"The characters are {characters}");
            Console.WriteLine($"The alphanumerics are {alphanumerics}");
        }
    }

    class FishTank
    {
        public void Entry()
        {
            double width = 50;
            double height = 120;
            double depth = 70;

            double volume = this.CalculateVolume(width, height, depth);
            Console.WriteLine($"The volume of the fish tank with width {width}, height {height} and depth {depth} is {volume}.");
        }

        private double CalculateVolume(double width, double height, double depth)
        {
            return (width * height * depth) / 1000;
        }
    }

    class Carpet
    {
        public void Entry()
        {
            double width = 7;
            double length = 6;
            double price_per_metre = 17;

            double price = this.CalculatePrice(width, length, price_per_metre);
            Console.WriteLine($"The price for a carpet with width '{width}', length '{length}', and £ per m^2 '{price_per_metre}' is £{price}");
        }

        private double CalculatePrice(double width, double length, double price_per_metre)
        {
            double metres_squared = width * length;
            double underlay = 3 * metres_squared;
            double grippers = 2 * width + 2 * length;

            const double fitting = 50;
            return underlay + grippers + (metres_squared * price_per_metre) + fitting;
        }
    }
}