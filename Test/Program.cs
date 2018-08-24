using System;

namespace Test
{
    class ProgramB
    {
        static void Main(string[] args)
        {
#if RELEASE
            Console.WriteLine("RELEASE");

#elif DEBUG
            Console.WriteLine("DEBUG");
#endif
            Console.ReadKey();
        }
    }
}
