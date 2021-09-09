using System;
using System.Linq;
using LinqLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var fighters = ListManager.SampleList();

            //Skriver ut alla för och efternamn från listan. 
            Console.WriteLine("Lista av alla fighters");
            fighters.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();

            //Lista som endast innehåller Male Fighters
            var maleFighters = fighters.Where(x => x.gender == "Male").ToList();
            Console.WriteLine("Lista med alla Male Fighters");
            maleFighters.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();


            //lista som endast innehåller female fighters
            var femaleFighters = fighters.Where(x => x.gender == "Female").ToList();
            Console.WriteLine("Lista med alla Female Fighters");
            femaleFighters.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();

            //lista av alla fighters sorterad efter firstName (stigande)
            var ascendingName = fighters.OrderBy(x => x.firstName).ToList();
            Console.WriteLine("Alla fighters efter FirstName(Ascending");
            ascendingName.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();


            //lista av alla fighters sorterad efter firstName (fallande)
            var descendingName = fighters.OrderByDescending(x => x.firstName).ToList();
            Console.WriteLine("Alla fighters sorterade efter FirstName(Descending)");
            descendingName.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();

            //lista med alla Male fighters sorterad efter firstName (ascending)
            var maleAscendingName = fighters.Where(x => x.gender == "Male").OrderBy(x => x.firstName).ToList();
            Console.WriteLine("Male fighters sorterad efter first name (ascending)");
            maleAscendingName.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();


            //lista med alla Female fighters sorterad efter firstName (descending) 
            var femaleDescendingName =
                fighters.Where(x => x.gender == "Female").OrderByDescending(x => x.firstName).ToList();
            Console.WriteLine("Female fighters Descending first name");
            femaleDescendingName.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();


            //lista med alla fighters sorterad efter ålder (ascending)
            var fightersAscendingAge = fighters.OrderBy(x => x.age).ToList();
            Console.WriteLine("Alla fighters ascending age");
            fightersAscendingAge.ForEach(x => Console.WriteLine(x.FullName + ", " + x.age));
            Console.WriteLine();


            //lista med Female fighters sorterad efter ålder (ascending)
            var femaleAscendingAge = fighters.Where(x => x.gender == "Female").OrderBy(x => x.age).ToList();
            Console.WriteLine("Female fighters ascending age");
            femaleAscendingAge.ForEach(x => Console.WriteLine(x.FullName + ", " + x.age));
            Console.WriteLine();


            //lista med Male fighters sorterad efter ålder (Descending)
            var maleDescendingAge = fighters.Where(x => x.gender == "Male").OrderByDescending(x => x.age).ToList();
            Console.WriteLine("male fighters Descending age");
            maleDescendingAge.ForEach(x => Console.WriteLine(x.FullName + ", " + x.age));
            Console.WriteLine();

            //Alla fighters kombinerade ålder
            var combinedAge = fighters.Sum(x => x.age);
            Console.WriteLine("Alla fighters kombinerade age: " + combinedAge);
            Console.WriteLine();

            //Female fighters kombinerade ålder
            var femaleCombinedAge = fighters.Where(x => x.gender == "Female").Sum(x => x.age);
            Console.WriteLine($"Female figters kombinerade ålder: {femaleCombinedAge}");
            Console.WriteLine();

            //fighters under 30år
            var fightersUnderThirty = fighters.Where(x => x.age < 30).ToList();
            Console.WriteLine("Alla fighters under 30");
            fightersUnderThirty.ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
