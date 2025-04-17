public class Program
{
    public static void Main(string[] args)
    {
        List<string> visitors = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        int n = 0;
        foreach (var item in visitors)
        {
            Console.WriteLine($"{n+1} - {item}");
            n++;
        }

        /*
        for (int i = 0; i < visitors.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {visitors[i]}");
        }
        */
    }
}