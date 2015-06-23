namespace RPG.Items
{
    public class Beer : Item
    {
        private int focusRestore = 40;

        public Beer(Position position) : base(position, 'B')
        {
            this.FocusRestore = focusRestore;
        }

        public int FocusRestore { get; private set; }
    }
}
