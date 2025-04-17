namespace PatikaConstructorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Baby babyOne = new Baby();
            babyOne.Name = "Ahmet";
            babyOne.Surname = "Pak";
            babyOne.BirthDate = DateTime.Now;

            Baby babyTwo = new Baby("Mehmet", "Ekim");
            babyTwo.BirthDate = DateTime.Now;

            Console.Write($"Birinci bebegin ");
            babyOne.DisplayBaby(babyOne.Name, babyOne.Surname, babyOne.BirthDate);

            Console.Write($"Ikinci bebegin ");
            babyTwo.DisplayBaby(babyTwo.Name, babyTwo.Surname, babyTwo.BirthDate);

        }
    }
}