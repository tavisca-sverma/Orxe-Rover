using System;

namespace Mars_Rover
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rover rover = new Rover();
            Console.WriteLine("Enter initial position:");
            string position = Console.ReadLine();
            rover.SetPosition(position);
            Console.WriteLine("Enter command to process:");
            string instruction = Console.ReadLine();
            rover.ProcessInstructions(instruction);
            Console.WriteLine("Updated position is:");
            Console.WriteLine(rover.GetPosition());
            Console.ReadKey();
        }        
    }
}
