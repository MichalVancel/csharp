




using System.ComponentModel.Design;

namespace TrakTak
{
    internal class Student
    {
        private string name;
        private int age;
        

    

        public void Name(string? studentName)
        {
            name = studentName;
        }

        public bool LegalDrinkAlc()
        {
            if (age >= 18)
            {
                return true ;
            }
            else
                return false;
        }

        public void Age(int studentAge)
        {
            age = studentAge;
        }

       
    }
}
