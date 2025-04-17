namespace PatikaWeekFourApp
{
    public class Computer : BaseMachine
    {
        // Fields
        private int _usbPortNumbers;

        // Properties
        public bool WithBluetooth { get; set; }
        public int UsbPortNumbers
        {
            get { return _usbPortNumbers; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _usbPortNumbers = value;
                }
                else
                {
                    Console.WriteLine("Warning: USB Port Numbers should be 2 or 4! If not, it will be assign -1 as default.");
                    _usbPortNumbers = -1;
                }
            }
        }

        // Constructors
        public Computer(string serialNumber, string name, string description, string operatingSystem, int usbPortNumbers, bool withBluetooth)
        {
            SerialNumber = serialNumber;
            Name = name;
            Description = description;
            OperatingSystem = operatingSystem;
            UsbPortNumbers = usbPortNumbers;
            WithBluetooth = withBluetooth;
        }

        // Methods
        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Name}");
        }
        public override void PrintInformation()
        {
            Console.WriteLine($"Product Type: Computer\nProduction Date: {ProductionDate}\nSerial Number: {SerialNumber}\nName: {Name}\nDescription: {Description}\nOperating System: {OperatingSystem}\nUSB Port Number: {UsbPortNumbers}\nWithBluetooth: {WithBluetooth}\nCreation Date: {ProductionDate}");
        }
    }
}
