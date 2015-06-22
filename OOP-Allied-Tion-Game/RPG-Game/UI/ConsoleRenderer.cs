namespace RPG.UI
{
    using System;
    using RPG.Interfaces;

    public class ConsoleRenderer : IRenderer
    {
        public void WriteLine(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
