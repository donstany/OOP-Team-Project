namespace RPG
{
    using System;
    using Interfaces;
    using Exceptions;

    public abstract class GameObject : IMoveable
    {
        private Position position;
        private char objectSymbol;

        protected GameObject(Position position, char objectSymbol)
        {
            this.Position = position;
            this.ObjectSymbol = objectSymbol;
        }

        public Position Position
        {
            get
            {
                return this.position;
            }
            set
            {
                if (value.X < 0 || value.Y < 0)
                {
                    throw new ObjectOutOfMapException("Specified object position is outside the map.")
                }
                this.position = value;
            }
        }

        public char ObjectSymbol
        {
            get
            {
                return this.objectSymbol;
            }
            set
            {
                if (!char.IsUpper(value))
                {
                    throw new ArgumentOutOfRangeException("objectSymbol", "Object symbol must be uppercase letter.");
                }
                this.objectSymbol = value;
            }
        }
    }
}
