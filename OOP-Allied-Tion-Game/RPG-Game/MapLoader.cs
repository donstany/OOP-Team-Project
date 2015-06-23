namespace RPG
{
    using RPG.Characters;
    using RPG.Interfaces;
    using RPG.Items;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class MapLoader
    {
        private static int mapRows = 16;
        private static int mapCols = 70;

        private static char[,] map = new char[mapRows, mapCols];

        public static List<Item> ItemsOnMap = new List<Item>();
        public static List<Character> CharactersOnMap = new List<Character>();

        public static char[,] LoadMap(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                try
                {
                    for (int row = 0; row < mapRows; row++)
                    {
                        string line = reader.ReadLine();
                        for (int col = 0; col < mapCols; col++)
                        {
                            map[row, col] = line[col];
                            switch (map[row, col])
                            {
                                case 'B': ItemsOnMap.Add(new Beer(new Position(row, col))); break;
                                case 'D': ItemsOnMap.Add(new DiskUpgrade(new Position(row, col))); break;
                                case 'M': ItemsOnMap.Add(new MemoryUpgrade(new Position(row, col))); break;
                                case 'N': ItemsOnMap.Add(new NakovBook(new Position(row, col))); break;
                                case 'P': ItemsOnMap.Add(new ProcessorUpgrade(new Position(row, col))); break;
                                case 'R': ItemsOnMap.Add(new Resharper(new Position(row, col))); break;
                                case 'U': ItemsOnMap.Add(new RedBull(new Position(row, col))); break;
                                case 'E': CharactersOnMap.Add(new ExamBoss(new Position(row, col))); break;
                                case 'G': CharactersOnMap.Add(new Bug(new Position(row, col))); break;
                                case 'X': CharactersOnMap.Add(new RPG.Characters.Exception(new Position(row, col))); break;
                                case 'Y': // add player depending on hero choise, require only 1 hero

                                default: break;
                            }
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    throw new FileLoadException(string.Format("Incorrect map format, columns should be {0} and rows should be {1}.", mapCols, mapRows));
                }
            }
            return map;
        }
    }
}
