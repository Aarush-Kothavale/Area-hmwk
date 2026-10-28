namespace Programming_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumOfPeople = 0;
            Console.WriteLine("How many people?");
            NumOfPeople = Convert.ToInt32(Console.ReadLine());
            int cost = NumOfPeople * 15;
            if (NumOfPeople > 5) 
            {
                cost = cost - 5;
                Console.WriteLine("The total cost come to " + cost);
            }
            else
            {
                Console.WriteLine("The total cost come to £" + cost);
            }
        }
    }
} 
