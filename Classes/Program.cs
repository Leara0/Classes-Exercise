namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Odyssey";
            myCar.Year = 2017;
            Console.WriteLine(myCar.Make);
            Console.WriteLine(myCar.Model);
            Console.WriteLine(myCar.Year);
        }
    }
}
