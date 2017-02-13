using System;
using System.Collections;

namespace ConsoleApplication1
{
	// HashTable Demo

        class Program
        {
            static void Main(string[] args)
            {
                Hashtable ht = new Hashtable();

                ht.Add("01", "Gautam");
                ht.Add("02", "Chaital");
                ht.Add("03", "Vimal");
                ht.Add("04", "Akash");
                
                if (ht.ContainsValue("Shaishan"))
                {
                    Console.WriteLine("This student name is already in the list");
                }
                else
                {
                    ht.Add("05", "Shaishan");
                }

                // Get a collection of the keys.
                ICollection key = ht.Keys;

                foreach (string k in key)
                {
                    Console.WriteLine(k + ": " + ht[k]);
                }

                Console.ReadKey();
            }
        }
		/*Output
		05: Shaishan
		02: Chaital
		03: Vimal
		04: Akash
		01: Gautam
		*/
}