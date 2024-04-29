using Kreta.Console.Models.SchoolCitizens;

AwardedStudent tunde = new AwardedStudent("Üveges Tünde", 17, 15000, false);
Console.WriteLine(tunde);
AwardedStudent denes = new AwardedStudent("Dolgozo Dénes", 18, 5000, true);
if (tunde.Age > denes.Age)
    Console.WriteLine($"{tunde.Name} idősebb, mint {denes.Name}!");
else if (denes.Age > tunde.Age)
    Console.WriteLine($"{denes.Name} idősebb, mint {tunde.Name}!");
else
    Console.WriteLine("A két diák ugyan annyi éves!");

