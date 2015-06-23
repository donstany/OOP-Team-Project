namespace RPG.Characters
{
    public class Bug : Character
    {
        internal const int BugFocus = 30;
        private const int BugEnergy = 30;
        private const char BugSym = 'B';

        public Bug(Position position, string name)
            : base(position, BugSym,name, BugFocus, BugEnergy)
        {
        }
    }
}
