using System;
using System.Collections.Generic;

namespace Wayfair
{
    public class Elevator
    {
        private const int MAXFLOORS = 5;
        public int CurrentFloor { get; set; }
        private List<int> stops = new List<int>();

        public string Name { get; set; }

        public Elevator(string name)
        {
            this.Name = name;
            this.CurrentFloor = 1;
        }

        public void PressButton(int floor)
        {
            if (CurrentFloor != floor && floor >= 1 && floor <= MAXFLOORS)
                stops.Add(floor);
        }

        public void Go()
        {
            while (stops.Count > 0)
            {
                var stop = PlanNextStop();
                GoTo(stop);
                stops.Remove(stop);
            }
        }

        protected int PlanNextStop()
        {
            int nextStop = 0;
            var diff = 999;

            stops.Sort();

            foreach (var stop in stops)
            {
                var currDiff = Math.Abs(CurrentFloor - stop);
                if (diff > currDiff)
                {
                    nextStop = stop;
                    diff = currDiff;
                }
            }
            return nextStop;
        }

        protected void GoTo(int floor)
        {
            CurrentFloor = floor;
            System.Console.WriteLine($"Elevator {this.Name} stop at floor {floor}");
        }
    }
}