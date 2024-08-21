namespace Classes;

public class Car
{
    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }
    
    public void Description()
    {
        Console.WriteLine($"My car is a {Make} {Model} from the year {Year}.");
    }
}