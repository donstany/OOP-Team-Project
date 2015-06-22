using RPG.Characters;
namespace RPG.Interfaces
{
    public interface IAttack
    {
        void Attack(Enemy enemy);
        
        int Damage { get; }
    }
}
