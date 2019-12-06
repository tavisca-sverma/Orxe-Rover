using System;
using System.Collections.Generic;
using System.Text;

namespace Orxe_Rover
{
    class Processor
    {
        public static Position ChangeDirection(char directionSignal, Position position)
        {
                position.direction = Directions.GetDirectionBySide(position.direction,directionSignal);
                return position;       
        }

        public static Position MoveRoverForward(Position position)
        {
            string currentDirection = position.direction;
            string actionString = Directions.GetActionString(currentDirection);

            position.xCoordinate += Directions.GetActionValue(actionString[0]);
            position.yCoordinate += Directions.GetActionValue(actionString[1]);

            return position;
        }

    }
}
