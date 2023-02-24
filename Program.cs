class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Digite a quantidade de linhas da pirâmide: ");
        string quantidade = Console.ReadLine();

        int num_linhas = Convert.ToInt32(quantidade);

        for (int i = 0; i < num_linhas; i++)
        {
            for (int k = 0; k < i + 1; k++)
            {
                int fib = Fibonacci(k);
                Console.Write($"{fib} ");
            }
            Console.WriteLine();
        }
    }
}