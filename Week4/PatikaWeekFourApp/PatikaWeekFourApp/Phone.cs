namespace PatikaWeekFourApp
{
    public class Phone : BaseMachine
    {
        // Properties
        public bool WithLicense { get; set; }

        // Constructors
        public Phone(string serialNumber, string name, string description, string operatingSystem, bool withLicense)
        {
            SerialNumber = serialNumber;
            Name = name;
            Description = description;
            OperatingSystem = operatingSystem;
            WithLicense = withLicense;
        }

        // Methods
        public override void GetProductName()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Name}");
        }
        public override void PrintInformation()
        {
            Console.WriteLine($"Product Type: Phone\nProduction Date: {ProductionDate}\nSerial Number: {SerialNumber}\nName: {Name}\nDescription: {Description}\nOperating System: {OperatingSystem}\nWithLicense: {WithLicense}\nCreation Date: {ProductionDate}");
        }
    }
}
