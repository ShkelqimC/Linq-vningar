using System;
using System.Collections.Generic;
using System.Linq;
using LinqLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var fighters = ListManager.SampleList();
            var numbers = new List<int>() {1,7,9,5,8,6,4,3,2};



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

            //alla number i numbers listan
            Console.Write("Numbers listan:");
            numbers.ForEach(x=> Console.Write(x + ", "));
            Console.WriteLine();

            //alla numer i nummerlistan sorterade (ascending)
            List<int> numbersSortedAscending = numbers.OrderBy(x => x).ToList();
            Console.Write("numbers sorted ascending: ");
            numbersSortedAscending.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();

            //alla nummer i nummerlistan sorterade (descending)
            var numbersSortedDescending = numbers.OrderByDescending(x => x).ToList();
            Console.Write("numbers sorted descending: ");
            numbersSortedDescending.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();

            //alla jämna nummer i nummerlistan
            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            Console.Write("Jämna siffrorna: ");
            evenNumbers.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();

            //alla ojämna siffror sorterade (ascending)
            var oddNumbersAscending = numbers.Where(x => x % 2 != 0).OrderBy(x=> x).ToList();
            Console.Write("Ojämna siffrorna: ");
            oddNumbersAscending.ForEach(x => Console.Write(x + ", "));

            //summan av alla jämna siffror
            var sumOfEvenNumbers = numbers.Where(x => x % 2 == 0).Sum(x => x);
            Console.WriteLine("Summan av jämna siffrorna: " + sumOfEvenNumbers);

            //summan av alla siffror
            var sumOfAllNumbers = numbers.Sum(x => x);
            Console.WriteLine("summan av alla siffrorna: " + sumOfAllNumbers);

            //summan av alla siffror på annat sätt
            Console.WriteLine("summan av alla siffrorna (.Aggregate): " + numbers.Aggregate((x, y) => x + y));

            //alla siffrors kvadrat (ascending)
            var squareOfAllNumbers = numbers.OrderBy(x=> x).Select(x => x * x).ToList();
            Console.Write("Alla siffror i kvadrat: ");
            squareOfAllNumbers.ForEach(x=> Console.Write(x +", "));
            Console.WriteLine();

            //summan av alla siffrors kvadrat (ascending)
            var sumOfSquares = numbers.OrderBy(x => x).Select(x => x * x).ToList().Aggregate((x, y) => x + y);
            Console.Write("summan av alla kvadrater: " + sumOfSquares);
            Console.WriteLine();

            //genomsnittliga ålder på fighters
            Console.WriteLine("genomsnittsåldern på alla fighters: " + Math.Round(fighters.Average(x => x.age), 0));
            


            Console.ReadKey();
            
            
        }
    }
}
