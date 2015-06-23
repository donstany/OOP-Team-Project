namespace RPG.Items
{
    public class MemoryUpgrade : Item
    {
        private int maxFocusBonus = 20;
        private bool isCollected = false;

        public MemoryUpgrade(Position position)
            : base(position, 'M')
        {
            this.MaxFocusBonus = maxFocusBonus;
            this.IsCollected = isCollected;
        }

        public int MaxFocusBonus { get; private set; }
        public bool IsCollected { get; set; }
    }
}
