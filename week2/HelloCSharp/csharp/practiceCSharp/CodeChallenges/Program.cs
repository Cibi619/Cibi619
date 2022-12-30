using System;

namespace CSharp {
    public class Program {
        public static void Main(String[] args) {
            int n;
            Console.WriteLine("Enter the value of n : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"n : {n}");
            string[] answer = new string[n+1];
            for (int i = 1; i <= n; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                    answer[i] = "FizzBuzz";
                else if (i % 3 == 0)
                    answer[i] = "Fizz";
                else if (i % 5 == 0)
                    answer[i] = "Buzz";
                else    
                    answer[i] = i.ToString();
            }

            // printing the array
            for (int i = 1; i <= n; i++)
                Console.Write(answer[i] + " ");
        }
    }
}
