using HepsiBuradaRobotKesif.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaRobotKesif
{



    public class Position
    {
        public IRobotMoving robotMoving;
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionEnum Direction { get;set; }

        public Position()
        {
            X = Y = 0;
            Direction = DirectionEnum.N;
        }

     
    }
}
