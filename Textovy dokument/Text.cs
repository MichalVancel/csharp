

namespace Textovy_dokument
{
    public class Text
    {
        private const string Way = @"C:\Users\Lenovo\Desktop\Prax\Dokumnet.txt";

        public int CountWords()
        {
            string text = File.ReadAllText(Way);
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}

