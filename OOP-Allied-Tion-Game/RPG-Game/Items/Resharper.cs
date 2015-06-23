namespace RPG.Items
{
    public class Resharper : Item
    {
        private int maxEnergyBonus = 50;
        private bool isCollected = false;

        public Resharper(Position position)
            : base(position, 'R')
        {
            this.MaxFocusBonus = maxEnergyBonus;
            this.IsCollected = isCollected;
        }

        public int MaxFocusBonus { get; private set; }
        public bool IsCollected { get; set; }
    }
}
