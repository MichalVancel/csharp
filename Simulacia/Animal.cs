


using System.Security.Cryptography.X509Certificates;

namespace Simulacia
{
    public class Animal
    {
        private bool bylinozravec = false;
        public void setfood(bool sibylinozravec)
        {
            bylinozravec = sibylinozravec;
        }
        public bool CanEatOtherAnimal()
        {
            if (bylinozravec == true)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}

