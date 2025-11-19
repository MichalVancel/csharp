using static System.Net.Mime.MediaTypeNames;
string way = "MojSubor.txt";
Console.WriteLine(File.ReadAllText(way));
Console.WriteLine("Napíš niečo");
string text = Console.ReadLine();
 while (text != "koniec")
{
    
    File.AppendAllText(way, $"{text} \n ");
    text = Console.ReadLine();
    
   
}



