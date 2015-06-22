namespace RPG.Interfaces
{
    public interface ICharacter : IAttack, IDestroyable
    {
        Position Position { get; }

        string Name { get; }


    }
}
