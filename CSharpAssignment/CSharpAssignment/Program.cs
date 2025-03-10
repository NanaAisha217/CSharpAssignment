// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
class Program
{
    static void Main()
    {
        // Question 1
        // ValidateNumber();
        // FindMaximum();
        // ImageOrientation();
        // SpeedCamera();

        // Question 2
        // CountDivisibleByThree();
        // SumNumbers();
        // ComputeFactorial();
        // GuessingGame();
        // FindMaxFromList();

        // Question 3
        // LikePost();
        // ReverseName();
        // UniqueSortedNumbers();
        // UniqueNumbers();
        // SmallestNumbers();

        // Question 4
        // CheckConsecutive();
        // CheckDuplicates();
        // ValidateTime();
        // PascalCase();
        // CountVowels();

        // Question 5
        // WordCount();
        // LongestWord();


    }

    // Question 1a
    static void ValidateNumber()
    {
        Console.WriteLine(value: "Enter a number between 1 and 10: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(number >= 1 && number <= 10 ? "Valid" : "Invalid");
    }

    // Question 1b
    static void FindMaximum()
    {
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Max: " + (a > b ? a : b));
    }


    // Question 1c
    static void ImageOrientation()
    {
        Console.Write("Enter width and height: ");
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine(width > height ? "Landscape" : "Portrait");
    }

    // Question 1d
    static void SpeedCamera()
    {
        Console.Write("Speed limit: ");
        int limit = int.Parse(Console.ReadLine());
        Console.Write("Car speed: ");
        int speed = int.Parse(Console.ReadLine());

        if (speed <= limit)
        {
            Console.WriteLine("Ok");
            return;
        }

        int points = (speed - limit) / 5;
        Console.WriteLine("Demerit Points: " + points);
        if (points > 12) Console.WriteLine("License Suspended");
    }


    // Question 2a

    static void CountDivisibleByThree()
    {
        int count = Enumerable.Range(1, 100).Count(x => x % 3 == 0);
        Console.WriteLine("Count: " + count);
    }

    // Question 2b
    static void SumNumbers()
    {
        int sum = 0;
        while (true)
        {
            Console.Write("Enter a number or 'ok' to stop: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "ok") break;
            sum += int.Parse(input);
        }
        Console.WriteLine("Sum: " + sum);
    }

    // Question 2c
    static void ComputeFactorial()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int fact = 1;
        for (int i = num; i > 0; i--) fact *= i;
        Console.WriteLine($"{num}! = {fact}");
    }

    // Question 2d
    static void GuessingGame()
    {
        int secret = new Random().Next(1, 11);
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Guess the number: ");
            if (int.Parse(Console.ReadLine()) == secret)
            {
                Console.WriteLine("You won!");
                return;
            }
        }
        Console.WriteLine("You lost! The number was " + secret);
    }


    // Question 2e
    static void FindMaxFromList()
    {
        Console.Write("Enter numbers separated by commas: ");
        var numbers = Console.ReadLine().Split(',').Select(int.Parse);
        Console.WriteLine("Maximum: " + numbers.Max());
    }

    // Question 3a
    static void LikePost()
    {
        List<string> names = new List<string>();
        while (true)
        {
            Console.Write("Enter a name (or press Enter to finish): ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)) break;
            names.Add(name);
        }
        if (names.Count == 1)
            Console.WriteLine($"{names[0]} likes your post.");
        else if (names.Count == 2)
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        else if (names.Count > 2)
            Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post.");
    }


    // Question 3b
    static void ReverseName()
    {
        Console.Write("Enter your name: ");
        char[] name = Console.ReadLine().ToCharArray();
        Array.Reverse(name);
        Console.WriteLine(new string(name));
    }


    // Question 3c
    static void UniqueSortedNumbers()
    {
        HashSet<int> numbers = new HashSet<int>();
        while (numbers.Count < 5)
        {
            Console.Write("Enter a unique number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (!numbers.Add(num))
                Console.WriteLine("Number already entered. Try again.");
        }
        Console.WriteLine("Sorted Numbers: " + string.Join(", ", numbers.OrderBy(n => n)));
    }


    // Question 3d
    static void UniqueNumbers()
    {
        HashSet<int> numbers = new HashSet<int>();
        while (true)
        {
            Console.Write("Enter a number or 'Quit' to stop: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;
            numbers.Add(Convert.ToInt32(input));
        }
        Console.WriteLine("Unique Numbers: " + string.Join(", ", numbers));
    }


    // Question 3e
    static void SmallestNumbers()
    {
        while (true)
        {
            Console.Write("Enter numbers separated by commas: ");
            var input = Console.ReadLine();
            var numbers = input.Split(',').Select(int.Parse).ToList();
            if (numbers.Count < 5)
                Console.WriteLine("Invalid List. Try again.");
            else
            {
                Console.WriteLine("Smallest 3: " + string.Join(", ", numbers.OrderBy(n => n).Take(3)));
                break;
            }
        }
    }


    // Question 4a
    static void CheckConsecutive()
    {
        Console.Write("Enter numbers separated by hyphens: ");
        var numbers = Console.ReadLine().Split('-').Select(int.Parse).ToList();
        Console.WriteLine(numbers.Zip(numbers.Skip(1), (a, b) => b - a).Distinct().Count() == 1 ? "Consecutive" : "Not Consecutive");
    }


    // Question 4b
    static void CheckDuplicates()
    {
        Console.Write("Enter numbers separated by hyphens: ");
        var input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;
        var numbers = input.Split('-').Select(int.Parse).ToList();
        Console.WriteLine(numbers.Count != numbers.Distinct().Count() ? "Duplicate" : "No Duplicates");
    }


    // Question 4c
    static void ValidateTime()
    {
        Console.Write("Enter a time (24-hour format HH:mm): ");
        var input = Console.ReadLine();
        Console.WriteLine(TimeSpan.TryParse(input, out TimeSpan time) && time.TotalMinutes < 1440 ? "Ok" : "Invalid Time");
    }


    // Question 4d
    static void PascalCase()
    {
        Console.Write("Enter words: ");
        var words = Console.ReadLine().ToLower().Split(' ');
        Console.WriteLine(string.Concat(words.Select(w => char.ToUpper(w[0]) + w.Substring(1))));
    }


    // Question 4e
    static void CountVowels()
    {
        Console.Write("Enter a word: ");
        var word = Console.ReadLine().ToLower();
        Console.WriteLine("Vowel count: " + word.Count(c => "aeiou".Contains(c)));
    }


    // Question 5a
    static void WordCount()
    {
        Console.Write("Enter file path: ");
        var path = Console.ReadLine();
        Console.WriteLine("Word Count: " + File.ReadAllText(path).Split(' ').Length);
    }


    // Question 5b
    static void LongestWord()
    {
        Console.Write("Enter file path: ");
        var path = Console.ReadLine();
        Console.WriteLine("Longest Word: " + File.ReadAllText(path).Split(' ').OrderByDescending(w => w.Length).First());
    }

}

