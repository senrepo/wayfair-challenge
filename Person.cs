namespace Wayfair
{
    public class Person
    {
        private ElevatorController controller;
        public Person(ElevatorController controller)
        {
            this.controller = controller;
        }

        public Elevator PressButtonToGetAElevator(int floor)
        {
            var elvator = controller.PressButtonToGetElevator(floor);
            return elvator;
        }
    }
}