namespace RPG.Engine
{
    using RPG.Interfaces;
    using RPG.Items;
    using System.Collections.Generic;

    public class Engine
    {
        private IInputReader reader;
        private IRenderer renderer;

        private IList<ICharacter> characters;
        private IList<Item> items;

        public Engine(IInputReader reader, IRenderer renderer)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.characters = new List<ICharacter>();
            this.items = new List<Item>();
        }

        public bool IsRunning { get; private set; }

        public void Run()
        {
            this.IsRunning = true;

            while (this.IsRunning)
            {
                // magic happens here
            }
        }
    }
}
