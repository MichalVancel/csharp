using TrakTak;

Student student = new Student();
Console.WriteLine("Zadaj meno");
string StudentName = Console.ReadLine();
Console.WriteLine("Zadaj vek");
int StudentAge = int.Parse(Console.ReadLine());
student.Name(StudentName);
student.Age(StudentAge);
bool MozesLegalnePit = student.LegalDrinkAlc();
Console.WriteLine($" {StudentName} moze legalne pit? {MozesLegalnePit}");


// trieda student
// strudent bude mat meno, vek
//zistite od studenta, ci moze legalne pit alkohol
//nastavte jeho meno 
// Jozko Mrkvicka nemoze/moze pit alkohol