namespace RPG
{
    using System;
    using Items;
    using System.Linq;
    using System.Collections.Generic;
    using RPG.Characters;

    public class MainClass
    {
        private const string mapPath = "../../Maps/01.txt";

        public static void Main()
        {
            MapLoader.LoadMap(mapPath);
            List<Item> allItems = MapLoader.ItemsOnMap.ToList();
            List<Character> allCharacters = MapLoader.CharactersOnMap.ToList();
        }
    }
}
