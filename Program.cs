using System.Numerics;

namespace Assignment7_2_1
{
    internal class Program
    {
        //Implement shell sort on an unsorted array of numbers. Take the array input from user.
        static void Main(string[] args)
        {
            int[] userArr = UserArray();
            Console.WriteLine();
            Console.WriteLine("Initial Array");
            Console.WriteLine();
            Print(userArr);
            Console.WriteLine();
            Console.WriteLine("Shell Sorted Array");
            ShellSort(userArr);
            Print(userArr);
           
        }
        //Tried to add Console lines to see what the data is during the sort
        static void ShellSort(int[] arr)
        {
            int arrayLen = arr.Length;
            // Create gap by dividing array into two, each pass reduce gap by half
            for (int gap = arrayLen/2; gap > 0; gap /= 2)
            {
                Console.WriteLine("<======================First Loop Interation======================>");
                Console.WriteLine($"Current Gap Index: {gap}");
                Console.WriteLine();
                // Start i at gap start, increment index by one until i reachs the end of array
                for (int i = gap; i < arrayLen; i += 1)
                {
                    Console.WriteLine("<======================Second Loop Iteration======================>");
                    //Save current gap index in a temp variable to swap values
                    int temp = arr[i];
                    Console.WriteLine($"Temp Index: {i}, Temp Value: {arr[i]}");
                    Console.WriteLine();
                   
                    int j;
                    // While j is greater or equal to gap and index of j-gap is greater than temp(index of i)
                    // index of j = index of j-gap
                    // j = j - gap
                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        Console.WriteLine("<======================Third Loop Iteration======================>");
                        Console.WriteLine($"Index of J: {j},Value of J: {arr[j]}, Index of J-Gap: {j-gap}, Value of J-Gap: {arr[j-gap]}");
                        Console.WriteLine();
                        arr[j] = arr[j - gap];
                        Console.WriteLine("<======================SWAP======================>");
                        Console.WriteLine($"New Value of J: {arr[j]} at Index: {j}");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("<======================Third Loop End======================>");
                    arr[j] = temp;
                    Console.WriteLine($"New Value of J: {arr[j]} at Index: {j}");
                    Console.WriteLine();
                }
            }
        }

        static int[] UserArray()
        {
            Console.WriteLine("Enter Array size");
            Console.Write("Here: ");
            int size = Convert.ToInt32(Console.ReadLine());
            var arr = new int[size];
            Console.WriteLine($"Enter integers for the array of size {size}");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Input {i+1}: ");
                string num = Console.ReadLine();
                if (Int32.TryParse(num, out int num1))
                {
                    arr[i] = num1;
                }
                else
                {
                    Console.WriteLine("Error: not a integer please enter an integer value.");
                    i--;
                }
            }
            return arr;
        }

        static void Print(int[] arr)
        {
            Console.Write("|");
            foreach (int i in arr)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }

    }
}
