class Program
{
    static void Main()
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        SortRowsDescending(array);

        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void SortRowsDescending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            
            Array.Sort(GetRow(array, i), (a, b) => b.CompareTo(a));
        }
    }

    static int[] GetRow(int[,] array, int rowIndex)
    {
        int rowLength = array.GetLength(1);
        int[] row = new int[rowLength];
        for (int i = 0; i < rowLength; i++)
        {
            row[i] = array[rowIndex, i];
        }
        return row;
    }
}
