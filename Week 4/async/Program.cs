﻿class Program 
{
    static void Main(string[] arga)
    {
        Method1();
        Method2();
        Console.ReadKey();
    }
    public static async Task Method1()
    {
        await Task.Run(()=>{
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Method 1 is running");
                Task.Delay(100).Wait();
            }
        });
    }
    public static void Method2()
    {
        for(int i=0; i<25; i++)
        {
            Console.WriteLine("Method 2 is running");
            Task.Delay(100).Wait(); 
        }
    }
}