namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Mazda";
            myCar.Model = "Mazda 2";
            myCar.Year = 2014;
        
            myCar.Description();
            var friendsCar = new Car()
            {
                Make = "Honda",
                Model = "Odyssey",
                Year = 2001
            };
            friendsCar.Description();
        }
    }
}
