namespace RPG.Characters
{
    using System;
    using RPG.Interfaces;

    public abstract class Character : GameObject, ICharacter
    {
        private string name;
        private int focus;
        private int energy;

        public Character(string name, int focus, int energy) : base()
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

        void IAttack.Attack(Enemy enemy)
        {
            enemy.Focus -= this.Energy;
        }
    }
}
