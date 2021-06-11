using System;

namespace Mars_Rover
{
    public class Rover
    {
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
