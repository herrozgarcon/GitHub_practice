namespace gitprac.extention;

public  static class extent
{
    public static void display(this List<int> numbers)
    {
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
    
}