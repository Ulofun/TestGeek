class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите несколько слов через пробел: ");
        var str = Console.ReadLine().Split(" ");
        var str2 = String.Join("", str).ToCharArray();

        string[] str3 = new string[str2.Length / 3 + 1];

        for (int i = 0, k = 0; i < str2.Length / 3 + 1; i++, k += 3)
        {
            for (int j = 0; j < 3; j++)
            {
                if ((j + k) < str2.Length && str2[j + k] != null)
                {
                    str3[i] += "" + str2[j + k];
                }

            }

        }


        Console.WriteLine(String.Join(", ", str3));
    }
}