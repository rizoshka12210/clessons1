int max = int.MinValue;
int x;
    while (true)
        {
            x = int.Parse(Console.ReadLine());

            if (x == 0)
                break;

            if (x > max)
                max = x;
        }
        Console.WriteLine(max);