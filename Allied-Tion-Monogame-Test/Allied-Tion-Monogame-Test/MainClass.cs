namespace TestMonogame
{
    using System;

#if WINDOWS || LINUX

    /// <summary>
    /// The main class.
    /// </summary>
    public static class MainClass
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }

#endif
}
