namespace RPG.UI
{
    using System;
    using RPG.Interfaces;

    public class ConsoleInputReader : IInputReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
