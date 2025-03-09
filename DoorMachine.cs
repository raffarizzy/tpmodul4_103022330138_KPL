using System;

namespace tpmodul4_103022330138
{
    public class DoorMachine
    {
        enum State { Terbuka, Terkunci };

        public void Run()
        {
            State state = State.Terkunci;
            string[] screenName = { "Terbuka", "Terkunci" };

            while (true)
            {
                Console.WriteLine("State saat ini: " + screenName[(int)state]);
                Console.Write("Masukan Command : ");

                string command = Console.ReadLine();

                switch (state)
                {
                    case State.Terbuka:
                        if (command == "KunciPintu")
                        {
                            state = State.Terkunci;
                            Console.WriteLine("Pintu terkunci");
                        }
                        else if (command == "BukaPintu")
                        {
                            state = State.Terbuka;
                            Console.WriteLine("Pintu tidak terkunci");
                        }
                        break;

                    case State.Terkunci:
                        if (command == "BukaPintu")
                        {
                            state = State.Terbuka;
                            Console.WriteLine("Pintu tidak terkunci");
                        }
                        else if (command == "KunciPintu")
                        {
                            state = State.Terkunci;
                            Console.WriteLine("Pintu terkunci");
                        }
                        break;
                }
            }
        }
    }
}