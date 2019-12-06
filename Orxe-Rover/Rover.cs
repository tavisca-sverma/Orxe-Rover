using System;

namespace Orxe_Rover
{
    public class Rover
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

        Position position = new Position();
        public void SetPosition(string positionString)
        {
            position.xCoordinate = (Convert.ToInt32(positionString.Split(',')[0]));
            position.yCoordinate = (Convert.ToInt32(positionString.Split(',')[1]));
            position.direction = (positionString.Split(',')[2]);
        }

        public string GetPosition()
        {
            return position.xCoordinate.ToString() + "," + position.yCoordinate.ToString() + "," + position.direction;
        }

        public void ProcessInstructions(string instruction)
        {
            for (int i = 0; i < instruction.Length; i++)
            {
                if (instruction[i] == 'M')
                {
                    Processor.MoveRoverForward(position);
                }
                else
                {
                    Processor.ChangeDirection(instruction[i], position);
                }
            }
        }
    }
}
