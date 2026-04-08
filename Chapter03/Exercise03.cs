using System;
using System.Text.RegularExpressions;

namespace Chapter03
{
    internal class Exercise03
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void ByteOverflowDemo()
        {
            int max = 500;

            // Warning before running beacuse byte can only hold values from 0 to 255, this loop will never end and will overflow back to 0 after reaching 255.
            if (max > byte.MaxValue)
            {
                Console.WriteLine("WARNING: max > byte.MaxValue (" + byte.MaxValue + "). Loop will overflow and never end!");
            }

            Console.WriteLine("Starting byte loop...");
            int count = 0;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
                count++;
                if (count > 10) break;  // Stop early to show it works but would be infinite
            }
            Console.WriteLine("Stopped after " + count + " iterations. (Would be infinite without the break)");
        }

        public static void RandomNumber()
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 4);  // 1, 2, or 3

            Console.WriteLine("Guess a number between 1 and 3:");
            string input = Console.ReadLine();
            int guess = int.Parse(input);

            if (guess < 1 || guess > 3)
            {
                Console.WriteLine("Your guess is outside the valid range (1-3).");
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }

        public static void PyrmaidPattern()
        {
            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void BirthDateCalculator()
        {
            DateTime birthDate = new DateTime(2001, 12, 21);  // Change this to your birth date
            DateTime today = DateTime.Today;

            int daysOld = (int)(today - birthDate).TotalDays;
            Console.WriteLine($"You are {daysOld} days old.");

            // Next 10,000 day anniversary
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = today.AddDays(daysToNextAnniversary);
            Console.WriteLine($"Next 10,000 day anniversary is on: {nextAnniversary:MMMM dd, yyyy}");
        }

        public static void GreetingByTime()
        {
            DateTime now = DateTime.Now;
            int hour = now.Hour;

            if (hour < 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (hour >= 12 && hour < 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (hour >= 17 && hour < 20)
            {
                Console.WriteLine("Good Evening");
            }

            if (hour >= 20 || hour < 6)
            {
                Console.WriteLine("Good Night");
            }
        }

        public static void CountTo24()
        {
            for (int increment = 1; increment <= 4; increment++)
            {
                for (int i = 0; i <= 24; i += increment)
                {
                    Console.Write(i);
                    if (i < 24)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void CopyArray()
        {
            // Create original array with 10 items
            int[] original = { 4, 5, 2, 3, 1, 0, 8, 9, 7, 6 };

            // Create copy using Length property
            int[] copy = new int[original.Length];

            // Copy using loop
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }

            // Print original
            Console.WriteLine("Original:");
            for (int i = 0; i < original.Length; i++)
            {
                Console.Write(original[i] + " ");
            }
            Console.WriteLine();

            // Print copy
            Console.WriteLine("Copy:");
            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write(copy[i] + " ");
            }
            Console.WriteLine();
        }


        public static void ManageList()
        {
            List<string> items = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string input = Console.ReadLine();

                if (input.StartsWith("+ "))
                {
                    string itemToAdd = input.Substring(2);
                    items.Add(itemToAdd);
                }
                else if (input.StartsWith("- "))
                {
                    string itemToRemove = input.Substring(2);
                    items.Remove(itemToRemove);
                }
                else if (input == "--")
                {
                    items.Clear();
                }

                Console.WriteLine("Current list:");
                if (items.Count == 0)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    foreach (string item in items)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.WriteLine();
            }
        }

        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int num = startNum; num <= endNum; num++)
            {
                bool isPrime = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime && num > 1)
                {
                    primes.Add(num);
                }
            }

            return primes.ToArray();
        }

        public static void RotateAndSum()
        {
            Console.Write("Enter n integers (space separated): ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr.Length;
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            
            int[] sum = new int[n];

            for (int r = 1; r <= k; r++)
            {
                for (int i = 0; i < n; i++)
                {
                    int newPos = (i + r) % n;
                    sum[newPos] += arr[i];
                }
            }

            Console.Write("sum[] = ");
            Console.WriteLine(string.Join(" ", sum));
        }

        public static void LongestSequence()
        {
            Console.Write("Enter integers (space separated): ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 1;
            int maxStart = 0;
            int currentLength = 1;
            int currentStart = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        maxStart = currentStart;
                    }
                    currentLength = 1;
                    currentStart = i;
                }
            }

            // Check final sequence
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxStart = currentStart;
            }

            Console.WriteLine($"Longest sequence length: {maxLength}");
            Console.Write("Sequence: ");
            for (int i = maxStart; i < maxStart + maxLength; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void LeftMostOccurence()
        {
            Console.Write("Enter integers (space separated): ");
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] nums = Array.ConvertAll(input, int.Parse);

            // Track (number, frequency, first_index) - lower index wins ties
            List<(int num, int freq, int firstIndex)> candidates = new List<(int, int, int)>();

            // Count frequencies and track first index
            Dictionary<int, (int freq, int firstIndex)> freqMap = new Dictionary<int, (int, int)>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!freqMap.ContainsKey(nums[i]))
                {
                    freqMap[nums[i]] = (0, i);
                }
                var current = freqMap[nums[i]];
                freqMap[nums[i]] = (current.freq + 1, current.firstIndex);
            }

            int maxFreq = 0;
            foreach (var kvp in freqMap)
            {
                candidates.Add((kvp.Key, kvp.Value.freq, kvp.Value.firstIndex));
                if (kvp.Value.freq > maxFreq)
                {
                    maxFreq = kvp.Value.freq;
                }
            }

            // Filter max freq and sort by firstIndex (leftmost first)
            var maxOnes = candidates.Where(c => c.freq == maxFreq)
                                   .OrderBy(c => c.firstIndex)
                                   .ToList();

            int resultNum = maxOnes[0].num;

            Console.WriteLine($"The number {resultNum} is the most frequent (occurs {maxFreq} times)");
        }

        public static void ReverseStringMethod1()
        {

            Console.Write("Enter Your string: ");
            string input = Console.ReadLine();

            // Convert to char array, reverse, convert back
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine(reversed);
        }

        public static void ReverseStringMethod2()
        {
            Console.Write("Enter Your string: ");
            string input = Console.ReadLine();

            // Print from last to first
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
        public static void ReverseWithPunctuations()
        {
            Console.Write("Enter Your string: ");
            string input = Console.ReadLine();

            // Separators: . , : ; = ( ) & [ ] " ' \ / ! ? (space)
            char[] separators = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };

            // Split into words and separators (preserves all)
            string[] tokens = input.Split(separators, StringSplitOptions.None);

            // Words are non-empty tokens without separators; reverse their order
            var words = tokens.Where(t => t.Length > 0 && Array.IndexOf(separators, t[0]) == -1).Reverse().ToArray();

            // Rebuild: replace word positions with reversed words
            int wordIndex = 0;
            string result = Regex.Replace(input, @"[^\s|.|,|:|;|=|(|)|&|\[|\](""|\'|\\|\/|!|\?)]+", match => words[wordIndex++]);

            Console.WriteLine(result);
        }


        public static void Palindrome()
        {
            Console.Write("Enter Your string: ");
            string text = Console.ReadLine().ToLower();

            List<string> palindromes = new List<string>();

            // Try all possible substrings
            for (int i = 0; i < text.Length; i++)
            {
                // Odd length palindromes
                for (int j = 0; i - j >= 0 && i + j < text.Length; j++)
                {
                    string candidate = text.Substring(i - j, 2 * j + 1);
                    if (IsPalindrome(candidate) && candidate.Length > 1)
                    {
                        palindromes.Add(candidate);
                    }
                }

                // Even length palindromes
                for (int j = 0; i - j >= 0 && i + j + 1 < text.Length; j++)
                {
                    string candidate = text.Substring(i - j, 2 * j + 2);
                    if (IsPalindrome(candidate))
                    {
                        palindromes.Add(candidate);
                    }
                }
            }

            // Unique, sorted, print
            var result = palindromes.Distinct().OrderBy(p => p).ToList();
            Console.WriteLine(string.Join(", ", result));
        }
        static bool IsPalindrome(string s)
        {
            return s == new string(s.Reverse().ToArray());
        }


        public static void URLParser()
        {
            Console.Write("Enter Your string: ");
            string url = Console.ReadLine();

            string protocol = "";
            string server = "";
            string resource = "";

            // Step 1: Extract protocol (optional) - look for "://"
            int protocolEnd = url.IndexOf("://");
            if (protocolEnd >= 0)
            {
                protocol = url.Substring(0, protocolEnd);
                url = url.Substring(protocolEnd + 3); // skip "://"
            }

            // Step 2: Extract resource (optional) - look for "/"
            int slashIndex = url.IndexOf('/');
            if (slashIndex >= 0)
            {
                server = url.Substring(0, slashIndex);
                resource = url.Substring(slashIndex + 1);
            }
            else
            {
                server = url; // no slash, whole thing is server
            }

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }

    }
}

    
