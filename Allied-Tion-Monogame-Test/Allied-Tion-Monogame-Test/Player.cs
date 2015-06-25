namespace TestMonogame
{
    using Microsoft.Xna.Framework.Graphics;

    class Player
    {
        public Player(string name, int x, int y, Texture2D skin)
        {
            this.Name = name;
            this.Skin = skin;
            this.X = x;
            this.Y = y;
        }

        public string Name { get; set; }

        public Texture2D Skin { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
    }
}

