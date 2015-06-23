namespace RPG.Characters
{
    using System;
    using RPG.Interfaces;

    public abstract class Character : GameObject, ICharacter
    {
        private string name;
        private int focus;
        private int energy;

        public Character(Position position, char symbol, string name, int focus, int energy)
            : base(position, symbol)
        {
            this.Name = name;
            this.Focus = focus;
            this.Energy = energy;
        }

        public int Focus { get; set; }
        public int Energy { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be empty or null");
                }
                this.name = value;
            }
        }

        void IAttack.Attack(Character enemy)
        {
            enemy.Focus -= this.Energy;
        }
    }
}
