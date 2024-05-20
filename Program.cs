namespace Assisgnment3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[2,4]
            { {1 , 2, 3, 4 },
            {  5, 6, 7, 8}
            }; 

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
