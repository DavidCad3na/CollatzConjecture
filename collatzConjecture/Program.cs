namespace collatzConjecture
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int fNum = Console.Read();

            if (fNum % 2 == 0)
            {
                fNum / 2;
            }

            else { 
                fNum * 3;

                fNum + 1;
            }
            Console.WriteLine(fNum);
            return fNum;
        }
    }
}
