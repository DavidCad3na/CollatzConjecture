namespace collatzConjecture
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int fNum = Convert.ToInt32(Console.ReadLine());
            while (fNum != 1)
            {
                if (fNum % 2 == 0)
                {
                    fNum = fNum / 2;
                    Console.WriteLine(fNum);
                }

                else
                {
                    fNum = (fNum * 3) + 1;
                    Console.WriteLine(fNum);
                }
            }
            return fNum;
        }
    }
}
