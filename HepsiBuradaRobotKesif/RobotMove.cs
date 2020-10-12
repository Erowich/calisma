using HepsiBuradaRobotKesif.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaRobotKesif
{
    public class RobotMove : IRobotMoving
    {
        Position a = new Position();
        public void RobotMoveInSameDirection(Position position)
        {
            switch (position.Direction)
            {
                case DirectionEnum.N:
                    position.Y += 1;
                    break;
                case DirectionEnum.S:
                    position.Y -= 1;
                    break;
                case DirectionEnum.E:
                    position.X += 1;
                    break;
                case DirectionEnum.W:
                    position.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void RobotMoving(List<int> maksimumRobotAxis, string moveRobot,Position position)
        {
            foreach(var move in moveRobot)
            {
                switch (move)
                {
                    case 'M':
                        RobotMoveInSameDirection(position);
                        break;
                    case 'L':
                        RobotMovingLeft(position);
                        break;
                    case 'R':
                        RobotMovingRight(position);
                        break;
                    default:
                        Console.WriteLine($"Invalid Character {move}");
                        break;
                }

                if (a.X < 0 || a.X > maksimumRobotAxis[0] || a.Y < 0 || a.Y > maksimumRobotAxis[1])
                {
                    throw new Exception($"Robot x veya y ekseni sınırlarını aşmış bulunmaktadır (0 , 0) and ({maksimumRobotAxis[0]} , {maksimumRobotAxis[1]})");
                }
            }
        }

        public void RobotMovingLeft(Position position)
        {
            switch (position.Direction)
            {
                case DirectionEnum.N:
                    position.Direction = DirectionEnum.W;
                    break;
                case DirectionEnum.S:
                    position.Direction = DirectionEnum.E;
                    break;
                case DirectionEnum.E:
                    position.Direction = DirectionEnum.N;
                    break;
                case DirectionEnum.W:
                    position.Direction = DirectionEnum.S;
                    break;
                default:
                    break;
            }
        }

        public void RobotMovingRight(Position position)
        {
            switch (position.Direction)
            {
                case DirectionEnum.N:
                    position.Direction = DirectionEnum.E;
                    break;
                case DirectionEnum.S:
                    position.Direction = DirectionEnum.W;
                    break;
                case DirectionEnum.E:
                    position.Direction = DirectionEnum.S;
                    break;
                case DirectionEnum.W:
                    position.Direction = DirectionEnum.N;
                    break;
                default:
                    break;
            }
        }
    }
}
