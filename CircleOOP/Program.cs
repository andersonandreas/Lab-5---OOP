namespace CircleOOP
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Circle circleRad5 = new Circle(5);
            Console.WriteLine($"Area: {Math.Round(circleRad5.getArea(), 1)}");

            Circle circleRad6 = new Circle(6);
            Console.WriteLine($"Area: {Math.Round(circleRad6.getArea(), 1)}");

        }
    }
}