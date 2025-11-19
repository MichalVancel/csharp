//trieda animal
using Simulacia;

Animal bylinozravec = new Animal();
bylinozravec.setfood(true);
bool mozejest = bylinozravec.CanEatOtherAnimal();
Animal masozravec = new Animal();
bool mozejestMasoz = masozravec.CanEatOtherAnimal();
Console.WriteLine($"Bylinozravec{mozejest} ");
Console.WriteLine($"Masozravec{mozejestMasoz} ");
