using System;
class lec2{
    static void Main(){
        Console.WriteLine("Please enter your name");
        string userName=Console.ReadLine();
        // Console.WriteLine("Hello "+userName);
        Console.WriteLine("Hello {0}",userName);
    }
}