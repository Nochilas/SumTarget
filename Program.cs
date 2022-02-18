namespace TwoSum
{
    class Program
    {
        static void Main()
        {
            int[] a1 = { 2, 7, 11, 15 };            
            int[] result = sumTarget(a1, 26);
            foreach(int i in result)
                Console.WriteLine(i);

            int[] a2 = { 3, 2, 4 };
            result = sumTarget(a2, 7);
            foreach(int i in result)
                Console.WriteLine(i);
        }

        static int[] sumTarget(int[] arr, int target)
        {
            int[] res = new int[2];

            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] + arr[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }

            return res;
        }
    }
}