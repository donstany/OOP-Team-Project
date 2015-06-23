namespace RPG.Engine
{
    using RPG.Characters;
    using RPG.Interfaces;
    using RPG.Items;
    using System.Linq;
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        private IInputReader reader;
        private IRenderer renderer;
        private char[,] map;

        private List<Character> characters;
        private List<Item> items;

        public Engine(IInputReader reader, IRenderer renderer)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.characters = new List<Character>();
            this.items = new List<Item>();
        }

        public bool IsRunning { get; private set; }

        public void Run(string mapPath)
        {
            // prepare to run
            this.IsRunning = true;
            this.characters = MapLoader.CharactersOnMap.ToList();
            this.items = MapLoader.ItemsOnMap.ToList();
            this.map = MapLoader.LoadMap(mapPath);

            Console.CursorVisible = false;
            Console.BufferHeight = 19; // 16 rows for map + 3 for GUI

            // run endless cycle
            while (this.IsRunning)
            {
                byte right = 0;
                byte left = 1;
                byte down = 2;
                byte up = 3;
            }

            Position[] directions = new Position[]
            {
                new Position(0, 1), // right
                new Position(0, -1), // left
                new Position(1, 0), // down
                new Position(-1, 0) // up
            };


        }
    }
}
