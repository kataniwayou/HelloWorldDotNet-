﻿﻿﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, liran World!");
Console.WriteLine("my demo is working");

int counter = 60;
while (counter >= 0)
{
    Console.WriteLine($"Seconds remaining: {counter}");
    System.Threading.Thread.Sleep(1000); // Wait 1 second
    counter--;
}

Console.WriteLine("Press any key to terminate.");
Console.ReadKey();
