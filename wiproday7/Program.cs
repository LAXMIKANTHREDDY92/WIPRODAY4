using System;
// declarinmg delegate
public delegate void MyDelegate(string message);
class Program
{
    public static void ShowMessage(string message)//declaring method that matches delegates signature
    {
        Console.WriteLine(message);
    }
    static void Main(string[] args)
    {
        // creating an instance for the delegate and point it to the Showmessage
        MyDelegate del = new MyDelegate(ShowMessage);
        del("laxmi kanth");
    }


}