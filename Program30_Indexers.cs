using System;

namespace ConsoleApplication4
{
	// Indexers 

    class IndexNames
    {
        private string[] namelist = new string[size];
        static public int size = 6;
        public IndexNames()
        {
            for (int i = 0; i < size; i++)
                namelist[i] = "-";
        }
		
		//First Indexer
        public string this[int index]
        {
            get
            {
                string tmp_name;

                if (index >= 0 && index <= size - 1)
                {
                    tmp_name = namelist[index];
                }
                else
                {
                    tmp_name = "";
                }

                return tmp_name;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
		
		//Secomd Indexer
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (namelist[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }

        static void Main(string[] args)
        {
            IndexNames names = new IndexNames();
            names[0] = "Gautam";
            names[1] = "Ravi";
            names[2] = "Shyam";
            names[3] = "Kamal";
            names[4] = "Nikunj";
            names[5] = "Vimal";
            
            for (int i = 0; i < IndexNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(names["Nikunj"]);

            Console.ReadKey();
        }
    }
}
    /*Output
        Gautam
        Ravi
        Shyam
        Kamal
        Nikunj
        Vimal
        4
    */
	