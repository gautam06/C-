using System;

namespace ConsoleApplication1
{
    //Joining Strings

        class Program
        {
            static void Main(String[] args)
            {
                String[] starray = new String[]{"Down the way nights are dark",
                 "And the sun shines daily on the mountain top",
                 "I took a trip on a sailing ship",
                 "And when I reached Jamaica",
                 "I made a stop"};

                String str = String.Join("\n", starray);
                Console.WriteLine(str);
                Console.ReadKey();
            }
        }
}

/*Output

Down the way nights are dark
And the sun shines daily on the mountain top
I took a trip on a sailing ship
And when I reached Jamaica
I made a stop

*/