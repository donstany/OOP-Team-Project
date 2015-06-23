namespace RPG.Characters
{
    using System;
    using RPG.Interfaces;

    public abstract class Character : GameObject, ICharacter
    {
        private string name;
        private int focus;
        private int energy;

        public Character(Position position, char objectSymbol, string name, int focus, int energy)
            : base(position, objectSymbol)
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


        public int Damage
        {
            get { throw new NotImplementedException(); }
        }

        public int Health
        {
            get { throw new NotImplementedException(); }
        }
    }
}
