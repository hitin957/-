Main();
static void Main()
{
    Console.WriteLine("Белые клавиши: A, S, D, F, G, H");
    Console.WriteLine("Чёрные клавиши: W, E, R, T, J");
    Console.WriteLine("Октавы: F1, F2, F3");
    Console.WriteLine("Для выхода программы нажмите клавишу Escape");
    Console.WriteLine("Выберите октаву");
    ConsoleKeyInfo Key = Console.ReadKey();
    Console.Clear();
    switch (Key.Key)
    {
        case ConsoleKey.F1:
            FirtsOctave();
            break;
        case ConsoleKey.F2:
            SecondOctave();
            break;
        case ConsoleKey.F3:
            ThirdOctave();
            break;
        case ConsoleKey.Escape:
            Environment.Exit(0);
            break;
    }
}

static void FirtsOctave()
{
    int[] Octave = new int[]
        { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
    Note(Octave);
}

static void SecondOctave()
{
    int[] Octave = new int[]
        { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
    Note(Octave);

}

static void ThirdOctave()
{
    int[] Octave = new int[]
        { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
    Note(Octave);
}

static void Note(int[] Octave)
{
    Console.WriteLine("Если вы хотите вернутся в меню к выбору октавы, нажмите клавишу Backspace");
    Console.WriteLine("Для выхода программы нажмите клавишу Escape");
    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear();
        switch (key.Key)
        {
            case ConsoleKey.A:
                MakeSound(Octave[0]);
                break;
            case ConsoleKey.W:
                MakeSound(Octave[1]);
                break;
            case ConsoleKey.S:
                MakeSound(Octave[2]);
                break;
            case ConsoleKey.E:
                MakeSound(Octave[3]);
                break;
            case ConsoleKey.D:
                MakeSound(Octave[4]);
                break;
            case ConsoleKey.F:
                MakeSound(Octave[5]);
                break;
            case ConsoleKey.R:
                MakeSound(Octave[6]);
                break;
            case ConsoleKey.G:
                MakeSound(Octave[7]);
                break;
            case ConsoleKey.T:
                MakeSound(Octave[8]);
                break;
            case ConsoleKey.H:
                MakeSound(Octave[9]);
                break;
            case ConsoleKey.J:
                MakeSound(Octave[10]);
                break;
            case ConsoleKey.Backspace:
                Main();
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }
    }
}
static void MakeSound(int frequency)
{
    Console.Beep(frequency, 500);
    Console.Clear();
}