
namespace OOP
{
    public class Monster
    {
        private const int maxHP = 200;
        private const int MinHP = 0;
        private int currentHP = maxHP;
        private int monsterdamage = 1;

        public bool DealDamage( Player opponent)
        {
            opponent.TakeDamage(monsterdamage);
            return true;
        }
        public void TakeDamage(int monsterdamage)
        {
           currentHP -= monsterdamage;
        }
    }
}