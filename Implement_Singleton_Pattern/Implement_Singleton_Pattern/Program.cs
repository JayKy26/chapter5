using System;

public sealed class Singleton
{
    // lưu trữ thể hiện duy nhất
    private static readonly Singleton Instance;

    // tổng số thể hiệnđược tạo
    private static int TotalInstances = 0;


    private Singleton()
    {
        Console.WriteLine("Private constructor is call");
    }

    
    static Singleton()
    {
        Console.WriteLine("Static constructor is called.");
        Instance = new Singleton();
        TotalInstances++;
        Console.WriteLine($"Singleton instance is created. Number of instances: {TotalInstances}");
        Console.WriteLine("Exit from static constructor");
    }

    // lấy thể hiện duy nhất của lớp
    public static Singleton GetInstance => Instance;

    //  tổng số thể hiện đã được tạo ra
    public int GetTotalInstances => TotalInstances;

   
    public void Print() => Console.WriteLine("Heloo");
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("#1. Trying to get a Singleton instance, called firstInstance.");
  
        Singleton firstInstance = Singleton.GetInstance;
        Console.WriteLine("Invoke Print() method:");
       
        firstInstance.Print();

        Console.WriteLine("#2. Trying to get another Singleton instance, called secondInstance.");
      
        Singleton secondInstance = Singleton.GetInstance;
        Console.WriteLine($"Number of instances: {secondInstance.GetTotalInstances}");
        Console.WriteLine("Invoke Print() method:");
        
        secondInstance.Print();

        // Check ca 2tham chiếu có trỏ đến cùng thể hiện không
        if (firstInstance.Equals(secondInstance))
        {
            Console.WriteLine("=> The firstInstance and secondInstance are the same.");
        }
        else
        {
            Console.WriteLine("=> Different instance exists.");
        }

        Console.Read();
    }
}
