﻿﻿﻿﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, liran World!");
Console.WriteLine("my demo is working");

int counter = 60;
while (counter >= 0)
{
    Console.Write($"Seconds remaining: {counter}\r");
    System.Threading.Thread.Sleep(1000); // Wait 1 second
    counter--;
}
Console.WriteLine(); // Add a newline after the counter finishes

Console.WriteLine("Press any key to terminate.");
Console.ReadKey();
