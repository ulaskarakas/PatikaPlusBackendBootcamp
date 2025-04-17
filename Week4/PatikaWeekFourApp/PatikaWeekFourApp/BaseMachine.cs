namespace PatikaWeekFourApp
{
    public abstract class BaseMachine
    {
        // Properties
        public DateTime ProductionDate { get; set; } = DateTime.Now;
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        // Methods
        public virtual void PrintInformation()
        {
            Console.WriteLine("Product Information");
        }

        public abstract void GetProductName();

    }
}
