namespace ConsoleAppAssignment3C
{
    internal class Program
    {
        //Entry point
        static void Main(string[] args)
        {
            double distance, time, kmph, mph;
            //Distance as input
            Console.Write("Enter the distance in km: ");
            double.TryParse(Console.ReadLine(), out distance);
            //Time as input
            Console.Write("Enter the time in hours: ");
            double.TryParse(Console.ReadLine(), out time);
            //To calculate speed in kilometers
            kmph = distance / time;
            //To calculate speed in miles
            mph = kmph * 0.621371;
            //Display result
            Console.WriteLine($"Speed in kilometers per hour: {kmph}");
            Console.WriteLine($"Speed in Miles per hour: {mph}");
            // To Keep the console window open
            Console.ReadKey();
        }
    }
}
