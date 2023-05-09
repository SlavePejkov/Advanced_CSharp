namespace Class01_Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            List<string> namses = new List<string>();
            string names;
            do
            {
                Console.WriteLine("Please enter a name or press x to stop");
                names = Console.ReadLine();
                if (names != "x")
                {
                    namses.Add(names);
                }
            } while (names != "x");

            Console.WriteLine("Please enter a text");
            string text = Console.ReadLine();

            foreach (string name in namses)
            {
                int count = text.Split(new char[] { ' ', '.', ',', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                    .Count(w => w.ToLower() == name.ToLower());
                Console.WriteLine("{0} appears {1} times in the text.", name, count); 
            }
            
        }
    }
}