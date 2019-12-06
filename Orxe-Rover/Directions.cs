using System;
using System.Collections.Generic;
using System.Text;

namespace Orxe_Rover
{
    class Directions
    {

        private static readonly Dictionary<string, string> onLeftList = new Dictionary<string, string>()
                                            {
                                                {"N","W"},
                                                {"S","E"},
                                                {"E","N"},
                                                {"W","S"}

                                            };

        private static readonly Dictionary<string, string> onRightList = new Dictionary<string, string>()
                                            {
                                                {"N","E"},
                                                {"S","W"},
                                                {"E","S"},
                                                {"W","N"}

                                            };

        private static readonly Dictionary<string, string> actionList = new Dictionary<string, string>()
                                            {
                                                {"N","01"},
                                                {"S","02"},
                                                {"E","10"},
                                                {"W","20"}

                                            };


        private static readonly Dictionary<char, int> actionMapper = new Dictionary<char, int>()
                                            {
                                                {'0',0},
                                                {'1',1},
                                                {'2',-1}

                                            };

        public static string GetDirectionBySide(string currentDirection,char side)
        {
            if (side == 'L') {
                return onLeftList[currentDirection];
            }
            else{
                return onRightList[currentDirection];
            }
        }

        public static string GetActionString(string direction)
        {
            return actionList[direction];
        }

        public static int GetActionValue(char actionChar)
        {
            return actionMapper[actionChar];
        }

    }
}
