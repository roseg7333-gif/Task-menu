using System.Data;

namespace Task_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<int> numbers = new List<int>();
            while (true)
            {
            
                Console.WriteLine("Menu options: ");
                Console.WriteLine("P. Print numbers ");
                Console.WriteLine("A. Add a number ");
                Console.WriteLine("M. Displat mean of the numbers");
                Console.WriteLine("S. Display the smallest number ");
                Console.WriteLine("L. Display the largest number ");
                Console.WriteLine("C. Clear the list ");
                Console.WriteLine("Q. Quit ");
                Console.WriteLine("Enter your choice: "); 
                string choice=Console.ReadLine();
                switch (choice)
                {
                    case "P":
                    case "p":
                        if(numbers.Count ==0)
                        {
                            Console.WriteLine("The list[] is empty");
                        }
                        else
                        {
                            Console.WriteLine("[");
                            for(int i = 0;i<numbers.Count;i++)
                            {
                                Console.WriteLine($"{numbers[i]}");
                            }
                            Console.WriteLine("]");
                        }
                        break;
 
                    case "A":
                    case "a":
                        Console.WriteLine("Enter an integer: ");
                        int number=Convert.ToInt32(Console.ReadLine());
                        numbers.Add(number);
                        Console.WriteLine(number + " added");
                        break;
                    case "M":
                    case "m":
                        if(numbers.Count ==0)
                        {
                            Console.WriteLine("Unable to calculate the maen no data!");
                        }
                        else
                        {
                            double sum = 0;
                            for(int i = 0; i<numbers.Count;i++)
                            {
                                sum += numbers[i];
                            }
                            double mean=sum/numbers.Count;
                            Console.WriteLine(mean);
                        }
                        break;
                    case "S":
                    case "s":
                       
                        if(numbers.Count ==0)
                        {
                            Console.WriteLine("Unable to find the smalest number no data!");
                        }
                        else
                        {
                            int small = numbers[0];
                            for(int i = 0; i<numbers.Count;i++)
                            {
                                if(numbers[i] <small)
                                {
                                    small= numbers[i];
                                }
                            }
                           
                            Console.WriteLine("The smallest number is " + small);
                        }
                        break;
                    case "l":
                    case "L":
                       
                        if(numbers.Count ==0)
                        {
                            Console.WriteLine("Unable to find the largest number no data!");
                        }
                        else
                        {
                            int large = numbers[0];
                            for(int i = 0; i<numbers.Count;i++)
                            {
                                if(numbers[i] >large)
                                {
                                    large= numbers[i];
                                }
                            }
                            Console.WriteLine("The largest number is " + large);
                        }
                        break;
                    case "c":
                    case "C":
                        numbers.Clear();
                        Console.WriteLine("List cleared");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Good bye");
                        return;
                    default:
                        Console.WriteLine("Unknown selection try again sir!");
                        break;
                }
            }
        }
    }
}
