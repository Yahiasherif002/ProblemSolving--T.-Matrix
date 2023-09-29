internal class Program
{
    static int sumOfDiagonal(int[,] arr)
    {
        int pim1 = 0;
        int pim2 = 0;
        int sum=0;
        for (int i = 0; i <arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if(i==j)
                {
                    pim1 += arr[i, j];
                }
                if(i+j==arr.GetLength(0)-1)
                {
                    pim2 += arr[i, j];
                }
            }
            
        }
        sum=Math.Abs(pim1-pim2);
        return sum;
    }   
    static void arrayIN(int[,] arr)
    {
        for (int i = 0; i <arr.GetLength(0); i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = int.Parse(input[j]);
            }
        }
    }
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        arrayIN(arr);
        Console.WriteLine(sumOfDiagonal(arr));
       
    }
}