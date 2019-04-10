using System;
using System.Collections.Generic;
using System.Linq;

namespace Wayfair
{
    public class ElevatorController  
    {
        public List<int> pressed = new List<int>();
        private List<Elevator> elevators = new List<Elevator>();

        public ElevatorController()
        {
            elevators.Add(new Elevator("A"));
            elevators.Add(new Elevator("B"));
            elevators.Add(new Elevator("C"));
        }

        protected Elevator GetElevator(int floor)
        {
            //Get the closest elevator
            Elevator nearElevlator = null;
            foreach (var elevator in elevators)
            {
                if (nearElevlator == null) nearElevlator = elevator;
                var nearDiff = Math.Abs(nearElevlator.CurrentFloor - floor);
                var currDiff = Math.Abs(elevator.CurrentFloor - floor);
                if(nearDiff > currDiff) nearElevlator = elevator;
            }
            return nearElevlator;
        }

        public Elevator PressButtonToGetElevator(int floor)
        {
            if (pressed.Contains(floor)) return null;
            pressed.Add(floor);
            var elevator = GetElevator(floor);
            elevator.PressButton(floor);
            elevator.Go();
            return elevator;
        }
    }
}