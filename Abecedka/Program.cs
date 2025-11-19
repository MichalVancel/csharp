using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Zadaj text");
string input  = Console.ReadLine();
string output = "";
foreach (char letter in input)
{
    output = output + GetLetter(letter.ToString());
}

string[,] matrix = new string[35, 130];
int offset = 0;

foreach (char intputletter in input)
{
    string outLetter = GetLetter(intputletter.ToString());
    string[] lines = outLetter.Split(Environment.NewLine);
    int letterWidth = 0;
    for (int i = 0; i < lines.Length; i++)
    {
        string character = lines[i];
        letterWidth = Math.Max(lines[i].Length, letterWidth);
        for (int j = 0; j < character.Length; j++)
        {
            matrix[i, j + offset] = character[j].ToString();
        }
    }
    offset = offset + letterWidth;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}














string GetLetter(string input)
{
    switch (input)
    {
        case "a":
        case "A":
        case "á":
        case "Á":
            
            return GetA();
        

        case "b":
        case "B":
            
            return GetB();
        case "c":
        case "C":
        
            return GetC();
        case "d":
        case "D":
       
            return GetletD();
        case "e":
        case "E":
      
            return GetE();
        case "f":
        case "F":
      
            return GetF();
        case "g":
        case "G":
            
            return GetG();
        case "h":
        case "H":
            
            return GetH();
        case "i":
        case "I":
            
            return GetI();
        case "j":
        case "J":
            
            return GetJ();
        case "k":
        case "K":
            
            return GetK();
        case "l":
        case "L":
            
            return GetL();
        case "m":
        case "M":
            
            return GetM();
        case "n":
        case "N":
            
            return GetN();
        case "o":
        case "O":
            
            return GetO();
        case "p":
        case "P":
            
            return GetP();
        case "q":
        case "Q":
            
            return GetQ();
        case "r":
        case "R":
           
            return GetR();
        case "s":
        case "S":
            
            return GetS();
        case "t":
        case "T":
           
            return GetT();
        case "u":
        case "U":
            
            return GetU();
        case "v":
        case "V":
            
            return GetV();
        case "w":
        case "W":
            
            return GetW();
        case "x":
        case "X":
            
            return GetX();
        case "y":
        case "Y":
            
            return GetY();
        case "z":
        case "Z":
            
            return GetZ();
        case "0":
            
            return Get0();
        case "1":
            
            return Get11();
        case "2":
            
            return Get2();
        case "3":
           
            return Get3();
        case "4":
            
            return Get4();
        case "5":
           
            return Get5();
        case "6":
           
            return Get6();
        case "7":
            
            return Get7();
        case "8":
           
            return Get8();
        case "9":
           
            return Get9();
        default: return "Zle";
    }
}





 string GetA()
{
    return @"
        
     _    
    / \   
   / _ \  
  / ___ \ 
 /_/   \_\
          
   ";     
}
string GetB()
{
    return @"
        
  ____  
 | __ ) 
 |  _ \ 
 | |_) |
 |____/ 
        
   ";
}
string GetC()
{
    return @"
        
   ____ 
  / ___|
 | |    
 | |___ 
  \____|
        
          
   ";

}
    string GetletD()
    {
        return @"
        
  ____  
 |  _ \ 
 | | | |
 | |_| |
 |____/ 
        
   ";
    }

string GetE()
{
    return @"
        
   _____ 
 | ____|
 |  _|  
 | |___ 
 |_____|
        
   ";
}
string GetF()
{
    return @"
        
  _____ 
 |  ___|
 | |_   
 |  _|  
 |_|    
        
   ";
}
string GetG()
{
    return @"
        
   ____ 
  / ___|
 | |  _ 
 | |_| |
  \____|
        
   ";
}
string GetH()
{
    return @"
        
  _   _ 
 | | | |
 | |_| |
 |  _  |
 |_| |_|
        
          
   ";
}
string GetI()
{
    return @"
        
  ___ 
 |_ _|
  | | 
  | | 
 |___|
      
   ";
}
string GetJ()
{
    return @"
        
      _ 
     | |
  _  | |
 | |_| |
  \___/ 
        
          
   ";
}
string GetK()
{
    return @"
        
  _  __
 | |/ /
 | ' / 
 | . \ 
 |_|\_\
       
   ";
}
string GetL()
{
    return @"
        
  _     
 | |    
 | |    
 | |___ 
 |_____|
        
   ";
}
string GetM()
{
    return @"
        
  __  __ 
 |  \/  |
 | |\/| |
 | |  | |
 |_|  |_|
         
   ";
}
string GetN()
{
    return @"
        
  _   _ 
 | \ | |
 |  \| |
 | |\  |
 |_| \_|
        
   ";
}
string GetO()
{
    return @"
        
   ___  
  / _ \ 
 | | | |
 | |_| |
  \___/ 
        
   ";
}
string GetP()
{
    return @"
        
  ____  
 |  _ \ 
 | |_) |
 |  __/ 
 |_|    
        
          
   ";
}
string GetQ()
{
    return @"
        
   ___  
  / _ \ 
 | | | |
 | |_| |
  \__\_\
        
   ";
}
string GetR()
{
    return @"
        
  ____  
 |  _ \ 
 | |_) |
 |  _ < 
 |_| \_\
        
   ";
}
string GetS()
{
    return @"
        
  ____  
 / ___| 
 \___ \ 
  ___) |
 |____/ 
        
   ";
}
string GetT()
{
    return @"
        
  _____ 
 |_   _|
   | |  
   | |  
   |_|  
        
   ";
}
string GetU()
{
    return @"
        
  _   _ 
 | | | |
 | | | |
 | |_| |
  \___/ 
        
   ";
}
string GetV()
{
    return @"
        
 __     __
 \ \   / /
  \ \ / / 
   \ V /  
    \_/   
          
   ";
}
string GetW()
{
    return @"
        
 __        __
 \ \      / /
  \ \ /\ / / 
   \ V  V /  
    \_/\_/   
             
          
   ";
}
string GetX()
{
    return @"
        
   __  __
 \ \/ /
  \  / 
  /  \ 
 /_/\_\
       
   ";
}
string GetY()
{
    return @"
        
 __   __
 \ \ / /
  \ V / 
   | |  
   |_|  
        
   ";
}
string GetZ()
{
    return @"
        
  _____
 |__  /
   / / 
  / /_ 
 /____|
       
   ";
}

string Get0()
{
    return @"

   ___  
  / _ \ 
 | | | |
 | |_| |
  \___/ 
        
    

";
}
string Get11()
{
    return @"

  _ 
 / |
 | |
 | |
 |_|
    

";
}

string Get2()
{
    return @"

  ____  
 |___ \ 
   __) |
  / __/ 
 |_____|
        

";
}
string Get3()
{
    return @"

  _____ 
 |___ / 
   |_ \ 
  ___) |
 |____/ 
        

";
}
string Get4()
{
    return @"

  _  _   
 | || |  
 | || |_ 
 |__   _|
    |_|  
         

";
}
string Get5()
{
    return @"

  ____  
 | ___| 
 |___ \ 
  ___) |
 |____/ 
        

";
}
string Get6()
{
    return @"

   __   
  / /_  
 | '_ \ 
 | (_) |
  \___/ 
        
";
}
string Get7()
{
    return @"

  _____ 
 |___  |
    / / 
   / /  
  /_/   
        

";
}
string Get8()
{
    return @"

   ___  
  ( _ ) 
  / _ \ 
 | (_) |
  \___/ 
        

";
}
string Get9()
{
    return @"

   ___  
  / _ \ 
 | (_) |
  \__, |
    /_/ 
        

";
}
