namespace RPG
{
    using System;
    using Items;
    using System.Linq;
    using System.Collections.Generic;
    using RPG.Characters;

    public class MainClass
    {
        public static void Main()
        {
            MapLoader.LoadMap("../Maps/01.txt");
            List<Item> allItems = MapLoader.ItemsOnMap.ToList();
            List<Character> allCharacters = MapLoader.CharactersOnMap.ToList();
        }
    }
}
