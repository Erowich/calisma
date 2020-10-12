using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBuradaRobotKesif
{
    class Program
    {
        static void Main(string[] args)
        {
            String robotXPosition=null;
            String robotYPosition=null;
            char robotDirection;
            bool isInteger = true;
            String _robotDirection=null;
            Console.WriteLine("Robot'un x ve y eksenlerinin sınırlarını belirlemek adına x ve y koordinat sınırlarını boşluk bırakarak giriniz");
            var maksimumRobotPoints = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            //var startPositions = Console.ReadLine().Trim().Split(' ');
            while (isInteger)
            {
                Console.WriteLine("Robot'un Başlangıç X eksenini rakam olarak veriniz");
                 robotXPosition = Console.ReadLine();
                if (int.TryParse(robotXPosition, out int output))
                {
                    Console.WriteLine("Robot'un Başlangıç Y eksenini rakam olarak veriniz");
                    robotYPosition = Console.ReadLine();
                    if(int.TryParse(robotYPosition,out int outputa))
                    {
                        Console.WriteLine("Robot'un Başlangıç Yön eksenini sayı olarak veriniz (N,E,W,S)");
                        robotDirection = Convert.ToChar(Console.ReadLine());
                        if (Char.IsLetter(robotDirection))
                        {
                            Console.WriteLine("Bilgileriniz doğrudur Robotun başlangıç yönü:{0} {1} {2}", robotXPosition, robotYPosition, robotDirection);
                            _robotDirection = Convert.ToString(robotDirection).ToUpper();
                            isInteger = false;
                        }
                        else
                        {
                            Console.WriteLine("Robota 'Z' ekseninde yön vermek için lütfen pusula yönü veriniz('N,E,W,S'");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Robota 'Y' ekseninde yön vermek için lütfen rakam giriniz");
                    }
                }
                else
                {
                    Console.WriteLine("Robota 'X' ekseninde yön vermek için lütfen rakam giriniz");
                }
                
            }
       

            Position position = new Position();

                position.X = Convert.ToInt32(robotXPosition);
                position.Y = Convert.ToInt32(robotYPosition);
                position.Direction = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), _robotDirection);

            RobotMove r = new RobotMove();
            Console.WriteLine("Lütfen Robota Yön vermek için 'L,M,R' tuslarına sırayla basarak yön veriniz");
            var robotMovings = Console.ReadLine().ToUpper();

            try
            {
                r.RobotMoving(maksimumRobotPoints, robotMovings,position);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
