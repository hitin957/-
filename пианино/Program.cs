Console.WriteLine("Пианино");
Console.WriteLine(" Переключение A B и C ");

    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key != ConsoleKey.A)
    {octava_0();
            static void octava_0()
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine(key.Key);
        int[] Octave0 = new int[3] { 520, 125, 6 };
                Console.Beep (Octave0[1],Octave0[2]);
            }
            

        
        
    }
    if (key.Key != ConsoleKey.B);
    {octava_1();

            static void octava_1()
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine(key.Key);
        int[] Octave1 = new int[3] { 32, 70, 5 };
        Console.Beep(Octave1[1], Octave1[2]);
    }
            
    }
    if (key.Key != ConsoleKey.C)
    {
        
        octava_2();
            Console.WriteLine("Октава 2");
            static void octava_2()
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine(key.Key);
                int[] Octave2= new int[2] { 65, 41 };
        Console.Beep(Octave2[1], Octave2[2]);
    }
    }   