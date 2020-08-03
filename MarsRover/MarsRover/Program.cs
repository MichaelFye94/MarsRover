using System;
using System.Numerics;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Rover...");

            Rover rover;

            var boundaryVals = Console.ReadLine().Split(' ');
            int.TryParse(boundaryVals[0], out int boundaryX);
            int.TryParse(boundaryVals[1], out int boundaryY);
            var boundary = new Vector2(boundaryX, boundaryY);

            while (true)
            {
                string positionInput = Console.ReadLine();
                if(string.IsNullOrEmpty(positionInput))
                {
                    break;
                }

                var positionVals = positionInput.Split(' ');
                var orders = Console.ReadLine();

                var position = (int.Parse(positionVals[0]), int.Parse(positionVals[1]), positionVals[2]);
                rover = new Rover(position, boundary);

                Console.WriteLine(rover.ProcessOrders(orders));
            }
        }
    }
}
