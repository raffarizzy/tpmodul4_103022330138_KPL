﻿namespace tpmodul4_103022330138
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABLE-DRIVEN");
            Console.WriteLine("Kode Pos Kujangsari: " + KodePos.GetKodePos("Kujangsari"));
            Console.WriteLine("Kode Pos Maleer: " + KodePos.GetKodePos("Maleer"));

            try
            {
                Console.WriteLine("Kode Pos New York: " + KodePos.GetKodePos("NewYork"));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("");
            Console.WriteLine("STATED-BASED");
            DoorMachine doorMachine = new DoorMachine();
            doorMachine.Run();
        }
    }
}