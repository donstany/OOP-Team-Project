namespace RPG.Characters
{
    public class ExamBoss : Character
    {
        private const int BossFocus = Bug.BugFocus + Exception.ExcFocus;
        private const int BossEnergy = 30;
        private const char BossSym = 'B';

            public ExamBoss(Position position, string name)
                : base(position,BossSym, name, BossFocus, BossEnergy)
            {
            }
    }
}
