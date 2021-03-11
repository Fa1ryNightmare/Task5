using System.IO;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            StreamReader sr = new StreamReader("Inlet.in");
            int N = int.Parse(sr.ReadLine());
            int[] nums = new int[N];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(sr.ReadLine());
            }
            sr.Close();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }
                int tmp = nums[i];
                nums[i] = nums[min];
                nums[min] = tmp;
            }
            string result = string.Join(" ", nums);
            File.WriteAllText("Outlet.out", result);
        }
    }
}
