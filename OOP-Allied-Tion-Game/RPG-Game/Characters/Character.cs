namespace RPG.Characters
{
    public abstract class Character : GameObject
    {
        private string name;
        private int health;
        private int damage;

        public Character(string name, int health, int damage) : base()
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public int Health { get; set; }
        public int Damage { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw ArgumentNullException("name", "Name cannot be empty or null");
                }
                this.name = value;
            }
        }
    }
}
