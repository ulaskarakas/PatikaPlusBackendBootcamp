namespace PatikaWeekFiveApp
{
    public class Car
    {
        public DateTime ProductionDate { get; set; } = new DateTime();
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumbersOfDoor { get; set; }

        public Car(string serialNumber, string brand, string model, string color, int numbersOfDoor)
        {
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            NumbersOfDoor = numbersOfDoor;
        }

        public void Display()
        {
            Console.WriteLine($"Car created.\nProduction Date: {ProductionDate.ToString("dd-MM-yyyy")} | Serial Number: {SerialNumber} | Brand: {Brand} | Model: {Model} | Color: {Color} | Numbers Of Door: {NumbersOfDoor}");
        }
    }
}
