using System;

namespace Wayfair
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new ElevatorController();
            var personA = new Person(controller);
            var personB = new Person(controller);

            var elevator = personA.PressButtonToGetAElevator(2);
            elevator.PressButton(5);
            elevator.PressButton(3);
            elevator.PressButton(1);
            elevator.Go();

            elevator = personB.PressButtonToGetAElevator(3);
            elevator.PressButton(4);
            elevator.PressButton(1);
            elevator.Go();

            Console.WriteLine("Press any button to close..");
            Console.ReadLine();
        }
    }
}
