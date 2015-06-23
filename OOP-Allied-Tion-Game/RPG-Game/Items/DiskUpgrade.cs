namespace RPG.Items
{
    public class DiskUpgrade : Item
    {
        private int maxFocusBonus = 30;
        private bool isCollected = false;

        public DiskUpgrade(Position position)
            : base(position, 'D')
        {
            this.MaxFocusBonus = maxFocusBonus;
            this.IsCollected = isCollected;
        }

        public int MaxFocusBonus { get; private set; }
        public bool IsCollected { get; set; }
    }
}
