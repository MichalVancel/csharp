
namespace OOP
{
    public class Player
    {
        private string Name;
      private const int maxHP = 100;
      private const int MinHP = 0;
      private int currentHP = maxHP;
      private int Playerdamage = 20;
      private List<string> inventory = new List<string>();

       public bool DealDamage( Monster opponent)
        {
            opponent.TakeDamage(Playerdamage);
            return true;
        }

        public void TakeDamage(int playerdamage)
        {
            currentHP -= playerdamage;
        }

        public void SetName(string? playerName)
        {
           Name = playerName;
        }
    }

}
