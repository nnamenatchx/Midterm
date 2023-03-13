class Program {
    static void Main(string[] args) {
        Console.Write("Number :" );
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double w1 = double.Parse(Console.ReadLine());
        double h1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double w2 = double.Parse(Console.ReadLine());
        double h2 = double.Parse(Console.ReadLine());

        double x1Left = x1 - w1 / 2;
        double y1Right = x1 + w1 / 2;
        double w1Top = y1 - h1 / 2;
        double h1Bottom = y1 + h1 / 2;
        double x2Left = x2 - w1 / 2;
        double y2Right = x2 + w2 / 2;
        double w2Top = y2 - h2 / 2;
        double h2Bottom = y2 + h2 / 2;

        double overlapWidth =
        
        double overlapHeight =

        double overlapArea = 0;

        if(overlapArea > 0 && (double) > 0) {
            overlapArea = (double) overlapWidth;
        }

        if(overlapArea > 8) {
            Console.WriteLine("Too Much Overlaping");
        }
        else(overlapArea > 0) {
            Console.WriteLine("Not Much Overlapping")
        }
        else {
            Console.WriteLine("No Overlapping");
        }
    }
}