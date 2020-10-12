using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaRobotKesif.Interfaces
{
   public interface IRobotMoving
    {
        void RobotMoving(List<int> maxPoints, string moves,Position position);
        void RobotMoveInSameDirection(Position position);
        void RobotMovingLeft(Position position);
        void RobotMovingRight(Position position);
    }
}
