namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.WriteLine("what fruit would you like to find");
            string FruitToFind = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < fruits.Length; i++) 
            {
                if (fruits[i] == FruitToFind) 
                {
                    found = true;
                    Console.WriteLine(found);
                    break;

                }
                else if (i == fruits.Length - 1) 
                {
                    Console.WriteLine(found);
                    break;
                } 
            }
        }
    }
}
