namespace RPG.Items
{
    public class ProcessorUpgrade : Item
    {
        private int maxEnergyBonus = 20;
        private bool isCollected = false;

        public ProcessorUpgrade(Position position)
            : base(position, 'P')
        {
            this.MaxFocusBonus = maxEnergyBonus;
            this.IsCollected = isCollected;
        }

        public int MaxFocusBonus { get; private set; }
        public bool IsCollected { get; set; }
    }
}
